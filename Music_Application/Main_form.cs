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
    public partial class Main_form : Form
    {
        private string usr_login;
        private string usr_pass;
        private string avatar_patch;
        private int t = 1;
        public Main_form()
        {
            InitializeComponent();
        }
        public Main_form(string login, string pass)
        {
            InitializeComponent();
            usr_login = login;
            usr_pass = pass;

            ///final init////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label t = new Label();
            Label t2 = new Label();
            t2.Text = this.t + "плейлист";
            MyPl_pl_table.Controls.Add(t2, 0, MyPl_pl_table.RowCount - 1);
            t.Text = this.t + "песня";
            MyPl_track_table.Controls.Add(t, 0, MyPl_track_table.RowCount - 1);
            //this.MyPl_pl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MyPl_pl_table.RowCount++;
            MyPl_track_table.RowCount++;
            this.t++;

        }

        private void avatarChoice_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                avatar_patch = openFileDialog1.FileName;
                //MessageBox.Show(avatar_patch);
                avatar_picturebox.Image = new Bitmap(avatar_patch);
            }

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            //edit request(log,pass,avatar_patch)
        }



        private void tab_panel_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc;
            tc = (TabControl)sender;
            //MessageBox.Show(tc.SelectedIndex.ToString());
            switch (tc.SelectedIndex)
            {
                case 0:
                    {//news
                        break;
                    }

                case 1:
                    {//charts
                        break;
                    }
                case 2:
                    {//Artists
                        break;
                    }
                case 3:
                    {//Tracks
                        break;
                    }
                case 4:
                    {//Playlists
                        break;
                    }
                case 5:
                    {//Settings
                        login_textBox.Text = usr_login;
                        password_textBox.Text = usr_pass;
                        //avatar_picturebox.Image = new Bitmap(avatar_patch);
                        break;
                    }
            }
        }
    }
}
