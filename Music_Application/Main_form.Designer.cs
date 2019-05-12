namespace Music_Application
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.tab_panel = new System.Windows.Forms.TabControl();
            this.news_tab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.News_track_table = new System.Windows.Forms.TableLayoutPanel();
            this.charts_tab = new System.Windows.Forms.TabPage();
            this.artists_tab = new System.Windows.Forms.TabPage();
            this.Art_artisits_table = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Art_track_table = new System.Windows.Forms.TableLayoutPanel();
            this.tracks_tab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Tr_track_table = new System.Windows.Forms.TableLayoutPanel();
            this.playlists_tab = new System.Windows.Forms.TabPage();
            this.MyPl_pl_table = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyPl_track_table = new System.Windows.Forms.TableLayoutPanel();
            this.config_page = new System.Windows.Forms.TabPage();
            this.apply_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.avatarChoice_button = new System.Windows.Forms.Button();
            this.avatar_picturebox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player_play_button = new System.Windows.Forms.Button();
            this.Player_pause_button = new System.Windows.Forms.Button();
            this.Player_TrackName_label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tab_panel.SuspendLayout();
            this.news_tab.SuspendLayout();
            this.artists_tab.SuspendLayout();
            this.tracks_tab.SuspendLayout();
            this.playlists_tab.SuspendLayout();
            this.config_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_panel
            // 
            this.tab_panel.Controls.Add(this.news_tab);
            this.tab_panel.Controls.Add(this.charts_tab);
            this.tab_panel.Controls.Add(this.artists_tab);
            this.tab_panel.Controls.Add(this.tracks_tab);
            this.tab_panel.Controls.Add(this.playlists_tab);
            this.tab_panel.Controls.Add(this.config_page);
            this.tab_panel.Location = new System.Drawing.Point(1, 1);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.SelectedIndex = 0;
            this.tab_panel.Size = new System.Drawing.Size(665, 346);
            this.tab_panel.TabIndex = 0;
            this.tab_panel.SelectedIndexChanged += new System.EventHandler(this.tab_panel_SelectedIndexChanged);
            // 
            // news_tab
            // 
            this.news_tab.Controls.Add(this.label9);
            this.news_tab.Controls.Add(this.News_track_table);
            this.news_tab.Location = new System.Drawing.Point(4, 22);
            this.news_tab.Name = "news_tab";
            this.news_tab.Padding = new System.Windows.Forms.Padding(3);
            this.news_tab.Size = new System.Drawing.Size(657, 320);
            this.news_tab.TabIndex = 0;
            this.news_tab.Text = "Новости";
            this.news_tab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Последние добавленные:";
            // 
            // News_track_table
            // 
            this.News_track_table.AutoSize = true;
            this.News_track_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.News_track_table.ColumnCount = 1;
            this.News_track_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.News_track_table.Location = new System.Drawing.Point(29, 63);
            this.News_track_table.Name = "News_track_table";
            this.News_track_table.RowCount = 1;
            this.News_track_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.News_track_table.Size = new System.Drawing.Size(557, 20);
            this.News_track_table.TabIndex = 5;
            // 
            // charts_tab
            // 
            this.charts_tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.charts_tab.Location = new System.Drawing.Point(4, 22);
            this.charts_tab.Name = "charts_tab";
            this.charts_tab.Padding = new System.Windows.Forms.Padding(3);
            this.charts_tab.Size = new System.Drawing.Size(657, 320);
            this.charts_tab.TabIndex = 1;
            this.charts_tab.Text = "Популярное";
            this.charts_tab.UseVisualStyleBackColor = true;
            // 
            // artists_tab
            // 
            this.artists_tab.AutoScroll = true;
            this.artists_tab.Controls.Add(this.Art_artisits_table);
            this.artists_tab.Controls.Add(this.label7);
            this.artists_tab.Controls.Add(this.label8);
            this.artists_tab.Controls.Add(this.Art_track_table);
            this.artists_tab.Location = new System.Drawing.Point(4, 22);
            this.artists_tab.Name = "artists_tab";
            this.artists_tab.Size = new System.Drawing.Size(657, 320);
            this.artists_tab.TabIndex = 2;
            this.artists_tab.Text = "Исполнители";
            this.artists_tab.UseVisualStyleBackColor = true;
            // 
            // Art_artisits_table
            // 
            this.Art_artisits_table.AutoSize = true;
            this.Art_artisits_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Art_artisits_table.ColumnCount = 1;
            this.Art_artisits_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Art_artisits_table.Location = new System.Drawing.Point(535, 41);
            this.Art_artisits_table.Name = "Art_artisits_table";
            this.Art_artisits_table.RowCount = 1;
            this.Art_artisits_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Art_artisits_table.Size = new System.Drawing.Size(99, 20);
            this.Art_artisits_table.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Треки:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Исполнители:";
            // 
            // Art_track_table
            // 
            this.Art_track_table.AutoSize = true;
            this.Art_track_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Art_track_table.ColumnCount = 1;
            this.Art_track_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Art_track_table.Location = new System.Drawing.Point(27, 72);
            this.Art_track_table.Name = "Art_track_table";
            this.Art_track_table.RowCount = 1;
            this.Art_track_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Art_track_table.Size = new System.Drawing.Size(465, 20);
            this.Art_track_table.TabIndex = 6;
            // 
            // tracks_tab
            // 
            this.tracks_tab.AutoScroll = true;
            this.tracks_tab.Controls.Add(this.label6);
            this.tracks_tab.Controls.Add(this.Tr_track_table);
            this.tracks_tab.Location = new System.Drawing.Point(4, 22);
            this.tracks_tab.Name = "tracks_tab";
            this.tracks_tab.Size = new System.Drawing.Size(657, 320);
            this.tracks_tab.TabIndex = 3;
            this.tracks_tab.Text = "Треки";
            this.tracks_tab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Треки:";
            // 
            // Tr_track_table
            // 
            this.Tr_track_table.AutoSize = true;
            this.Tr_track_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Tr_track_table.ColumnCount = 1;
            this.Tr_track_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tr_track_table.Location = new System.Drawing.Point(11, 51);
            this.Tr_track_table.Name = "Tr_track_table";
            this.Tr_track_table.RowCount = 1;
            this.Tr_track_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tr_track_table.Size = new System.Drawing.Size(557, 20);
            this.Tr_track_table.TabIndex = 4;
            // 
            // playlists_tab
            // 
            this.playlists_tab.AutoScroll = true;
            this.playlists_tab.Controls.Add(this.MyPl_pl_table);
            this.playlists_tab.Controls.Add(this.button1);
            this.playlists_tab.Controls.Add(this.label5);
            this.playlists_tab.Controls.Add(this.label4);
            this.playlists_tab.Controls.Add(this.MyPl_track_table);
            this.playlists_tab.Location = new System.Drawing.Point(4, 22);
            this.playlists_tab.Name = "playlists_tab";
            this.playlists_tab.Size = new System.Drawing.Size(657, 320);
            this.playlists_tab.TabIndex = 4;
            this.playlists_tab.Text = "Мои плейлисты";
            this.playlists_tab.UseVisualStyleBackColor = true;
            // 
            // MyPl_pl_table
            // 
            this.MyPl_pl_table.AutoSize = true;
            this.MyPl_pl_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MyPl_pl_table.ColumnCount = 1;
            this.MyPl_pl_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MyPl_pl_table.Location = new System.Drawing.Point(522, 41);
            this.MyPl_pl_table.Name = "MyPl_pl_table";
            this.MyPl_pl_table.RowCount = 1;
            this.MyPl_pl_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MyPl_pl_table.Size = new System.Drawing.Size(99, 20);
            this.MyPl_pl_table.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Треки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Плейлисты:";
            // 
            // MyPl_track_table
            // 
            this.MyPl_track_table.AutoSize = true;
            this.MyPl_track_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MyPl_track_table.ColumnCount = 1;
            this.MyPl_track_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MyPl_track_table.Location = new System.Drawing.Point(14, 72);
            this.MyPl_track_table.Name = "MyPl_track_table";
            this.MyPl_track_table.RowCount = 1;
            this.MyPl_track_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MyPl_track_table.Size = new System.Drawing.Size(465, 20);
            this.MyPl_track_table.TabIndex = 1;
            // 
            // config_page
            // 
            this.config_page.Controls.Add(this.apply_button);
            this.config_page.Controls.Add(this.checkBox1);
            this.config_page.Controls.Add(this.avatarChoice_button);
            this.config_page.Controls.Add(this.avatar_picturebox);
            this.config_page.Controls.Add(this.label3);
            this.config_page.Controls.Add(this.label2);
            this.config_page.Controls.Add(this.password_textBox);
            this.config_page.Controls.Add(this.login_textBox);
            this.config_page.Controls.Add(this.label1);
            this.config_page.Location = new System.Drawing.Point(4, 22);
            this.config_page.Name = "config_page";
            this.config_page.Size = new System.Drawing.Size(657, 320);
            this.config_page.TabIndex = 5;
            this.config_page.Text = "Настройки";
            this.config_page.UseVisualStyleBackColor = true;
            // 
            // apply_button
            // 
            this.apply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply_button.Location = new System.Drawing.Point(190, 244);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(205, 73);
            this.apply_button.TabIndex = 16;
            this.apply_button.Text = "Сохранить изменения";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // avatarChoice_button
            // 
            this.avatarChoice_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avatarChoice_button.Location = new System.Drawing.Point(496, 238);
            this.avatarChoice_button.Name = "avatarChoice_button";
            this.avatarChoice_button.Size = new System.Drawing.Size(108, 33);
            this.avatarChoice_button.TabIndex = 14;
            this.avatarChoice_button.Text = "Выбрать аватар";
            this.avatarChoice_button.UseVisualStyleBackColor = true;
            this.avatarChoice_button.Click += new System.EventHandler(this.avatarChoice_button_Click);
            // 
            // avatar_picturebox
            // 
            this.avatar_picturebox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avatar_picturebox.Location = new System.Drawing.Point(478, 57);
            this.avatar_picturebox.Name = "avatar_picturebox";
            this.avatar_picturebox.Size = new System.Drawing.Size(141, 175);
            this.avatar_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_picturebox.TabIndex = 13;
            this.avatar_picturebox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login:";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(86, 149);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 10;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(86, 102);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 20);
            this.login_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки пользователя";
            // 
            // Player_play_button
            // 
            this.Player_play_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player_play_button.BackgroundImage")));
            this.Player_play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_play_button.Location = new System.Drawing.Point(8, 349);
            this.Player_play_button.Name = "Player_play_button";
            this.Player_play_button.Size = new System.Drawing.Size(32, 32);
            this.Player_play_button.TabIndex = 1;
            this.Player_play_button.UseVisualStyleBackColor = true;
            // 
            // Player_pause_button
            // 
            this.Player_pause_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player_pause_button.BackgroundImage")));
            this.Player_pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_pause_button.Location = new System.Drawing.Point(42, 349);
            this.Player_pause_button.Name = "Player_pause_button";
            this.Player_pause_button.Size = new System.Drawing.Size(32, 32);
            this.Player_pause_button.TabIndex = 2;
            this.Player_pause_button.UseVisualStyleBackColor = true;
            // 
            // Player_TrackName_label
            // 
            this.Player_TrackName_label.AutoSize = true;
            this.Player_TrackName_label.Location = new System.Drawing.Point(80, 359);
            this.Player_TrackName_label.Name = "Player_TrackName_label";
            this.Player_TrackName_label.Size = new System.Drawing.Size(88, 13);
            this.Player_TrackName_label.TabIndex = 3;
            this.Player_TrackName_label.Text = "Трек не выбран";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 385);
            this.Controls.Add(this.Player_TrackName_label);
            this.Controls.Add(this.Player_pause_button);
            this.Controls.Add(this.Player_play_button);
            this.Controls.Add(this.tab_panel);
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.tab_panel.ResumeLayout(false);
            this.news_tab.ResumeLayout(false);
            this.news_tab.PerformLayout();
            this.artists_tab.ResumeLayout(false);
            this.artists_tab.PerformLayout();
            this.tracks_tab.ResumeLayout(false);
            this.tracks_tab.PerformLayout();
            this.playlists_tab.ResumeLayout(false);
            this.playlists_tab.PerformLayout();
            this.config_page.ResumeLayout(false);
            this.config_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_panel;
        private System.Windows.Forms.TabPage news_tab;
        private System.Windows.Forms.TabPage charts_tab;
        private System.Windows.Forms.TabPage artists_tab;
        private System.Windows.Forms.TabPage tracks_tab;
        private System.Windows.Forms.TabPage playlists_tab;
        private System.Windows.Forms.TabPage config_page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel MyPl_track_table;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button avatarChoice_button;
        private System.Windows.Forms.PictureBox avatar_picturebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TableLayoutPanel MyPl_pl_table;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel News_track_table;
        private System.Windows.Forms.TableLayoutPanel Art_artisits_table;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel Art_track_table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel Tr_track_table;
        private System.Windows.Forms.Button Player_play_button;
        private System.Windows.Forms.Button Player_pause_button;
        private System.Windows.Forms.Label Player_TrackName_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}