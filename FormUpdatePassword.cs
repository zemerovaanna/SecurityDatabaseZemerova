using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkDbZemerova
{
    public partial class FormUpdatePassword : Form
    {
        private int usID;
        SqlConnection connect = new SqlConnection(@"Data Source=HOME-PC;Initial Catalog=SecurityDb;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table;

        public FormUpdatePassword(int usID)
        {
            InitializeComponent();
            this.usID = usID;
        }

        public void ConnectionDb()
        {
            connect.Open();
            adapter = new SqlDataAdapter("select * from UserTable", connect);
            table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
            connect.Close();
        }

        private void FormUpdatePassword_Load(object sender, EventArgs e)
        {
            ConnectionDb();
        }

        //Проверка пароля.
        public string checkPassword(string password)
        {
            string message = "";
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ',' && password[i] == ':' && password[i] == ';' && password[i] == '"' && password[i] == '\'')
                {
                    message = "Обнаружены запрещённые символы";
                }
            }
            return message;
        }

        private void UpdatePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            connect.Open();
            adapter = new SqlDataAdapter($"Select password from UserTable Where id = '{usID}'", connect);
            connect.Close();
            table = new DataTable();
            adapter.Fill(table);

            string message = "";

            if (TextBoxOldPassword.Text != "" && TextBoxNewPassword.Text != "" && TextBoxPasswordConfirmation.Text != "")
            {
                //Проверка на совпадение со старым паролем.
                if (TextBoxOldPassword.Text == table.Rows[0][0].ToString())
                {
                    message = checkPassword(TextBoxNewPassword.ToString());

                    if (message == "")
                    {
                        //Проверка на совпадение новых паролей.
                        if (TextBoxNewPassword.Text == TextBoxPasswordConfirmation.Text)
                        {
                            //Проверка на разность старого и нового паролей.
                            if (TextBoxOldPassword.Text != TextBoxNewPassword.Text)
                            {
                                connect.Open();
                                adapter = new SqlDataAdapter($"Update UserTable set Password = '{TextBoxNewPassword.Text}' where Id = '{usID}'", connect);
                                connect.Close();
                                table = new DataTable();
                                adapter.Fill(table);

                                MessageBox.Show("Пароль изменён успешно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Старый и новый пароль не должны совпадать.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Новые пароли не совпадают.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Старые пароли не совпадают.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Поля не могут быть пустыми для смены пароля.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}