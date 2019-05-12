using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Music_Application
{
    public partial class Form1 : Form
    {
        private string login;
        private string password;
        private string connStr = "server=localhost;user=root;database=musicdb;password=root;";
        private MySqlConnection conn;
        private string sql;
        private string avatar_path;
        private string id;
        bool is_found = false;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
            conn.Open();
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
                sql = "SELECT * FROM user WHERE login = '"+login+"' and pwd = '"+password+"';";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    is_found = true;
                    avatar_path = reader[3].ToString();
                    id = reader[0].ToString();
                }
                reader.Close();
                if (is_found)
                {
                    conn.Close();
                    this.Hide();
                    new Main_form(login, password,avatar_path,id).ShowDialog();
                    
                    Dispose();
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
