using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class Form1 : Form
    {
        private string login;
        private string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = login_textBox.Text.Trim(' ');
            password = password_textBox.Text.Trim(' ');
            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Прверьте правильность ввода");
            }
            else
            {
                //if exists
                if (true)
                {
                    new Main_form(login, password).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                
            }
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            new Registration_form().ShowDialog();
        }
    }
}
