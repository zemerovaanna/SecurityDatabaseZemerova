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

namespace WorkDbZemerova
{
    public partial class FormAuthorization : Form
    {
        private int usID; //Номер пользователя для передачи в форму для смены пароля.
        string NowYearMonthDay;

        bool registration;
        SqlConnection connect = new SqlConnection(@"Data Source=HOME-PC;Initial Catalog=SecurityDb;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable table;

        public FormAuthorization()
        {
            InitializeComponent();

            NowYearMonthDay = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}";
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

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form signin = new FormAuthorization();
            signin.ShowDialog();

            this.Close();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registration = new FormAuthorization();
            registration.ShowDialog();

            this.Close();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            ConnectionDb();
        }

        static bool CheckDate(DataTable table)
        {
            bool changepassword = false;

            string NowYearMonthDay = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}";
            DateTime dateUser = Convert.ToDateTime(table.Rows[0][4]);
            dateUser = dateUser.AddDays(14);

            //Проверка на неизменность пароля в течении 14 и более дней.
            if (DateTime.Compare(dateUser, DateTime.Now) < 0)
            {
                changepassword = true;
            }

            return changepassword;
        }

        private void ButtonSighIn_Click(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text != "" && TextBoxPassword.Text != "")
            {


                string username = $"SELECT * FROM UserTable Where Login = '{TextBoxLogin.Text}'";
                connect.Open();
                adapter = new SqlDataAdapter(username, connect);
                table = new DataTable();
                adapter.Fill(table);
                string password = table.Rows[0][2].ToString();
                connect.Close();

                if (table.Rows.Count <= 1)
                {


                    DateTime date = Convert.ToDateTime(table.Rows[0][4]);
                    TimeSpan dateSpan = date - DateTime.Now;


                    if (Convert.ToInt32(dateSpan.ToString("dd")) > 30)
                    {


                        connect.Open();
                        adapter = new SqlDataAdapter($"Update UserTable set Active = 'False' where login = '{TextBoxLogin.Text}'", connect);
                        connect.Close();
                        table = new DataTable();
                        adapter.Fill(table);
                        ConnectionDb();
                        MessageBox.Show("Вы заблокированы. Обратитесь к Администратору Cистемы для разблокировки учетной записи.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        SqlDataAdapter AdpterUpdater = new SqlDataAdapter($"Update UserTable set date = '{NowYearMonthDay}' Where Login = '{TextBoxLogin.Text}'", connect);

                        if (TextBoxPassword.Text == password)
                        {

                            if (table.Rows[0][6].ToString() == "Admin" && table.Rows[0][5].ToString() == "True")
                            {



                                bool changepassword = CheckDate(table);


                                if (changepassword == true)
                                {


                                    Form UpdatePassword = new FormUpdatePassword(Convert.ToInt32(table.Rows[0][0].ToString()));
                                    UpdatePassword.ShowDialog();

                                    connect.Open();
                                    connect.Close();
                                    table = new DataTable();
                                    AdpterUpdater.Fill(table);


                                }
                                else
                                {
                                    Form admin = new FormAdmin();
                                    admin.ShowDialog();

                                    connect.Open();
                                    connect.Close();
                                    table = new DataTable();
                                    AdpterUpdater.Fill(table);
                                }

                                ConnectionDb();
                            }
                            else if (table.Rows[0][5].ToString() == "True")
                            {


                                bool changepassword = CheckDate(table);


                                if (changepassword == true)
                                {


                                    Form UpdatePassword = new FormUpdatePassword(Convert.ToInt32(table.Rows[0][0].ToString()));

                                    UpdatePassword.ShowDialog();
                                    connect.Open();
                                    connect.Close();
                                    table = new DataTable();
                                    AdpterUpdater.Fill(table);


                                }
                                else
                                {


                                    Form Root = new FormRoot(table.Rows[0][1].ToString(), table.Rows[0][3].ToString(), table.Rows[0][6].ToString());
                                    Root.ShowDialog();

                                    connect.Open();
                                    connect.Close();
                                    table = new DataTable();
                                    AdpterUpdater.Fill(table);


                                }

                                ConnectionDb();

                            }

                            else MessageBox.Show("Этот пользователь забанен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {


                            int count = Convert.ToInt32(table.Rows[0][3].ToString());

                            if (count >= 3)
                            {
                                connect.Open();
                                adapter = new SqlDataAdapter($"Update UserTable set Active = 'False' Where Login = '{TextBoxLogin.Text}'", connect);
                                connect.Close();
                                table = new DataTable();
                                adapter.Fill(table);
                                ConnectionDb();
                                MessageBox.Show("Этот пользователь забанен.", $"Уведомление для пользователя {TextBoxLogin.Text}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                count++;
                                connect.Open();
                                adapter = new SqlDataAdapter($"Update UserTable set Count = {count} Where Login = '{TextBoxLogin.Text}'", connect);
                                connect.Close();
                                table = new DataTable();
                                adapter.Fill(table);
                                ConnectionDb();
                                MessageBox.Show("Вы ввели неверный пароль. Пожалуйста, проверьте ещё раз введенные данные.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }


                    }


                }
                else
                {
                    MessageBox.Show("Вы ввели неверный логин. Пожалуйста проверьте ещё раз введенные данные.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        static string CheckLogin(string login)
        {
            string message = "";
            foreach (char symbol in login)
            {
                if (!char.IsLetter(symbol))
                {
                    message = "Логин может содержать только буквы.";
                    break;
                }
            }
            return message;
        }

        static string ConfirmPassword(string password, string confirmation)
        {
            string message = "";
            if (password != confirmation)
            {
                message = "Пароли не совпадают.";
            }
            return message;
        }

        public string CheckPassword(string password)
        {
            string message = "";
            foreach (char symbol in password)
            {
                if (!char.IsDigit(symbol) && !char.IsLetter(symbol))
                {
                    message = "Обнаружены запрещённые символы в пароле.";
                    break;
                }
            }
            return message;
        }

        private void ButtonSighUp_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            string passwordverification = TextBoxVeficitaion.Text;

            if (login != "" && password != "" && passwordverification != "")
            {
                string message = "";

                message = CheckLogin(login);

                if (message != "")
                {
                    MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    message = CheckPassword(password);

                    if (message != "")
                    {
                        MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        message = ConfirmPassword(password, passwordverification);

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

                            if (table.Rows.Count < 1)
                            {
                                connect.Open();

                                string date = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}";
                                string query = $"INSERT INTO dbo.UserTable(Login, Password, Count, Date, Active, Role) VALUES('{TextBoxLogin.Text}','{TextBoxPassword.Text}',0,'{date}','True','User')";

                                adapter = new SqlDataAdapter(query, connect);
                                table = new DataTable();
                                adapter.Fill(table);
                                DataGridView.DataSource = table;
                                connect.Close();
                                ConnectionDb();

                                MessageBox.Show("Пользователь зарегистрирован.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form signin = new FormAuthorization();
                                signin.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Такой пользователь уже существует.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }



                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Поля не могут быть пустые.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}