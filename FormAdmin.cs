using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkDbZemerova
{
    public partial class FormAdmin : Form
    {
        private int usID; //Номер пользователя для передачи в форму для смены пароля.
        string NowYearMonthDay;

        bool registration;
        SqlConnection connect = new SqlConnection(@"Data Source=HOME-PC;Initial Catalog=SecurityDb;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table;

        public FormAdmin()
        {
            InitializeComponent();
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

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "securityDbDataSet.UserTable". При необходимости она может быть перемещена или удалена.
            this.userTableTableAdapter.Fill(this.securityDbDataSet.UserTable);
            ConnectionDb();
        }

        private void ButtonSearchId_Click(object sender, EventArgs e)
        {
            string reguest = $"SELECT * FROM UserTable Where id = '{TextBoxSerchId.Text}'";

            connect.Open();
            adapter = new SqlDataAdapter(reguest, connect);
            table = new DataTable();
            adapter.Fill(table);
            connect.Close();

            if (table.Rows.Count <= 1)
            {
                TextBoxLogin.Text = Convert.ToString(table.Rows[0][1]);
                TextBoxPassword.Text = Convert.ToString(table.Rows[0][2]);
                TextBoxCount.Text = Convert.ToString(table.Rows[0][3]);
                DomainUpDownRole.Text = Convert.ToString(table.Rows[0][6]);
                DomainUpDownActive.Text = Convert.ToString(table.Rows[0][5]);
            }
            else
            {
                MessageBox.Show("Такой пользователь не найден.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string CheckLogin(string login)
        {
            string message = "";
            for (int i = 0; i < login.Length; i++)
            {
                if (login[i] < 'A' && login[i] > 'Z')
                {
                    message = "Логин может содержать только английские буквы буквы.";
                }
            }
            return message;
        }

        public string CheckPassword(string password)
        {
            string message = "";
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ',' && password[i] == ':' && password[i] == ';' && password[i] == '"' && password[i] == '\'')
                {
                    message = "Обнаружены запрещённые символы в пароле.";
                }
            }
            return message;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string id = TextBoxSerchId.Text;
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            string count = TextBoxCount.Text;
            string role = DomainUpDownRole.Text;
            string active = DomainUpDownActive.Text;

            string message = "";

            message = CheckLogin(login);

            if (message != "")
            {
                MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                message = CheckPassword(login);

                if (message != "")
                {
                    MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string reguest = $"SELECT * FROM UserTable Where Login = '{login}'";

                    connect.Open();
                    adapter = new SqlDataAdapter(reguest, connect);
                    table = new DataTable();
                    adapter.Fill(table);
                    connect.Close();

                    if (table.Rows.Count <= 1)
                    {
                        connect.Open();
                        adapter = new SqlDataAdapter($"Update UserTable set Login = '{login}', Password = '{password}', Count = '{count}', Role = '{role}', Active = '{active}'  Where ID = '{id}'", connect);
                        connect.Close();
                        table = new DataTable();
                        adapter.Fill(table);
                        MessageBox.Show("Изменено успешно.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не изменено.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ButtonExite_Click(object sender, EventArgs e)
        {
            Form exite = new FormAuthorization();
            exite.ShowDialog();
            
            this.Close();
        }
    }
}