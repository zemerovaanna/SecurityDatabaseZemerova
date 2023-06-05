using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkDbZemerova
{
    public partial class FormRoot : Form
    {
        public FormRoot(string login, string count, string role)
        {
            InitializeComponent();

            TextLogin.Text = $"Здравствуйте, {login}";
            TextCount.Text = $"Count: {count}";
            TextRole.Text = $"Role: {role}";
        }

        private void ButtonExite_Click(object sender, EventArgs e)
        {
            Form exite = new FormAuthorization();
            exite.ShowDialog();
            this.Close();
            this.Close();
        }
    }
}