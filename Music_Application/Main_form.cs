using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using MySql.Data.MySqlClient;
using System.IO;

namespace Music_Application
{
    public partial class Main_form : Form
    {
        private string usr_login;
        private string usr_pass;
        private string avatar_patch;
        private int t = 1;
        private WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private string connStr = "server=localhost;user=root;database=musicdb;password=root;";
        private MySqlConnection conn;
        private string sql;
        private string id;
        public Main_form()
        {
            InitializeComponent();
        }
        public Main_form(string login, string pass, string avatar_patch, string id)
        {
            InitializeComponent();
            usr_login = login;
            usr_pass = pass;
            this.avatar_patch = avatar_patch;
            this.id = id;
            conn = new MySqlConnection(connStr);
            conn.Open();
            ///final init////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TrackLabel t = new TrackLabel("", "","",1,"1.mp3");
            //t.Click +=new System.EventHandler(this.trackLabel_Click);
            Label t2 = new Label();
            t2.Text = this.t + "плейлист";
            MyPl_pl_table.Controls.Add(t2, 0, MyPl_pl_table.RowCount - 1);
           // t.Text = this.t + "песня";
            //MyPl_track_table.Controls.Add(t, 0, MyPl_track_table.RowCount - 1);
            //this.MyPl_pl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MyPl_pl_table.RowCount++;
            MyPl_track_table.RowCount++;
            this.t++;

        }

        private void trackLabel_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = "";
            TrackLabel t;
            t = (TrackLabel)sender;
            Player_TrackName_label.Text = t.Text;
            using (System.IO.FileStream fs = new System.IO.FileStream("qwe.mp3", FileMode.OpenOrCreate))
            {
                fs.Write(t.data, 0, t.data.Length);
                
            }

            player.URL= "qwe.mp3";
        }

        private void playlistLabel_Click(object sender, EventArgs e)
        {
            PlaylistLabel tp = (PlaylistLabel)sender;
            MyPl_track_table.Controls.Clear();
            string sql = "SELECT tracks.* FROM tracks INNER JOIN playlists_track ON tracks.idtracks = playlists_track.idTrack  LEFT JOIN playlists ON playlists.idPlayLists = playlists_track.idPlayList  WHERE playlists.idPlayLists = "+tp.id+" GROUP BY tracks.trackName";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] data = ((byte[])reader.GetValue(6));

                TrackLabel t = new TrackLabel(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), data);
                t.Click += new System.EventHandler(this.trackLabel_Click);
                t.Text = reader[1].ToString();
                MyPl_track_table.Controls.Add(t, 0, MyPl_track_table.RowCount - 1);
            }
            reader.Close();
        }
        private void groupLabel_Click(object sender, EventArgs e)
        {
            GroupLabel tp = (GroupLabel)sender;
            Art_track_table.Controls.Clear();
            string sql = "SELECT tracks.* FROM tracks INNER JOIN track_group ON tracks.idtracks = track_group.idTrack LEFT JOIN `group` ON `group`.idGroup = track_group.idGroup WHERE `group`.idGroup = "+tp.id+" GROUP BY tracks.trackName";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] data = ((byte[])reader.GetValue(6));

                TrackLabel t = new TrackLabel(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), data);
                t.Click += new System.EventHandler(this.trackLabel_Click);
                t.Text = reader[1].ToString();
                Art_track_table.Controls.Add(t, 0, MyPl_track_table.RowCount - 1);
            }
            reader.Close();
        }
        private void avatarChoice_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                avatar_picturebox.Image.Dispose();
                avatar_patch = openFileDialog1.FileName;
                //MessageBox.Show(avatar_patch);
                avatar_picturebox.Image = new Bitmap(avatar_patch);
                
            }

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            avatar_patch = "image/" + login_textBox.Text + ".jpg";            
            //edit request(log,pass,avatar_patch)
            sql = "UPDATE user SET login = '"+login_textBox.Text+"',pwd = '"+password_textBox.Text+"',avatar = '"+avatar_patch+"' WHERE idUser = '"+id+"'; ";
            MySqlCommand command = new MySqlCommand(sql, conn);
            if (command.ExecuteNonQuery() > 0)
            {
                try
                {
                    avatar_picturebox.Image.Save(avatar_patch);
                }
                catch (Exception ex)
                {
                    File.Delete(avatar_patch);
                    avatar_picturebox.Image.Save(avatar_patch);
                }
                
                usr_login = login_textBox.Text;
                usr_pass = password_textBox.Text;
                MessageBox.Show("Изменения сохранены!");
                
            }
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
                        News_track_table.Controls.Clear();
                        string sql = "SELECT * from tracks;";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            byte[] data = ((byte[])reader.GetValue(6));
                            TrackLabel t = new TrackLabel(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), data);
                            t.Click += new System.EventHandler(this.trackLabel_Click);
                            t.Text = reader[1].ToString();
                            News_track_table.Controls.Add(t, 0, Tr_track_table.RowCount - 1);
                        }
                        reader.Close();
                        break;
                    }

                case 1:
                    {//charts
                        Charts_track_table.Controls.Clear();
                        string sql = "SELECT * FROM tracks ORDER BY countListens DESC LIMIT 10; ";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            byte[] data = ((byte[])reader.GetValue(6));
                            TrackLabel t = new TrackLabel(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), data);
                            t.Click += new System.EventHandler(this.trackLabel_Click);
                            t.Text = reader[1].ToString();
                            Charts_track_table.Controls.Add(t, 0, Tr_track_table.RowCount - 1);
                        }
                        reader.Close();
                        break;
                    }
                case 2:
                    {//Artists
                        Art_artisits_table.Controls.Clear();
                        string sql = "SELECT * FROM `group`;";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            GroupLabel t = new GroupLabel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                            t.Click += new System.EventHandler(this.groupLabel_Click);
                            t.Text = reader[1].ToString();
                            Art_artisits_table.Controls.Add(t, 0, Art_artisits_table.RowCount - 1);
                        }
                        reader.Close();
                        break;
                    }
                case 3:
                    {//Tracks
                        Tr_track_table.Controls.Clear();
                        string sql = "SELECT * from tracks;";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            byte[] data =((byte[])reader.GetValue(6)); 
                            TrackLabel t = new TrackLabel(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), data);
                            t.Click += new System.EventHandler(this.trackLabel_Click);
                            t.Text = reader[1].ToString();
                            Tr_track_table.Controls.Add(t,0,Tr_track_table.RowCount-1);
                        }
                        reader.Close();
                        break;
                    }
                case 4:
                    {//Playlists
                        MyPl_pl_table.Controls.Clear();
                        string sql = "SELECT playlists.* FROM playlists INNER JOIN user_playlist ON user_playlist.idPlayList = playlists.idPlayLists LEFT JOIN user ON user_playlist.idUser = user.idUser WHERE user.idUser = "+id+" GROUP BY playlists.playListName";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            PlaylistLabel t = new PlaylistLabel(reader[0].ToString(), reader[1].ToString());
                            t.Click += new System.EventHandler(this.playlistLabel_Click);
                            t.Text = reader[1].ToString();
                            MyPl_pl_table.Controls.Add(t, 0, MyPl_pl_table.RowCount - 1);
                        }
                        reader.Close();
                        break;
                    }
                case 5:
                    {//Settings
                        login_textBox.Text = usr_login;
                        password_textBox.Text = usr_pass;
                        //Bitmap t = new Bitmap(avatar_patch);
                        avatar_picturebox.Image = new Bitmap(avatar_patch);
                        //t.Dispose();
                        break;
                    }
            }
        }

        private void Player_play_button_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void Player_pause_button_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
