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
    public partial class Registration_form : Form
    {
        private string avatar_patch="default";
        private string login;
        private string password;

        public Registration_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void avatarChoice_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                avatar_patch = openFileDialog1.FileName;
                //MessageBox.Show(avatar_patch);
                avatar_picturebox.Image = new Bitmap(avatar_patch);
            }
            //add to bd
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password_textBox.UseSystemPasswordChar){
                password_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_textBox.UseSystemPasswordChar = true;
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            login = login_textBox.Text.Trim(' ');
            password = password_textBox.Text.Trim(' ');
            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Прверьте правильность ввода");
            }
            else
            {
                //добавить запись в бд
                Dispose();
            }
        }
    }
}
