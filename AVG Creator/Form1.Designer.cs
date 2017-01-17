namespace AVG_Creator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存進度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入進度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於軟體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.audio_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.background_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.character_box_2 = new System.Windows.Forms.PictureBox();
            this.character_box_1 = new System.Windows.Forms.PictureBox();
            this.avatar_box = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.select_4 = new System.Windows.Forms.Button();
            this.select_3 = new System.Windows.Forms.Button();
            this.select_2 = new System.Windows.Forms.Button();
            this.select_1 = new System.Windows.Forms.Button();
            this.dialogue = new System.Windows.Forms.Label();
            this.character_name = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.character_box_3 = new System.Windows.Forms.PictureBox();
            this.character_box_4 = new System.Windows.Forms.PictureBox();
            this.character_box_5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audio_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_1)).BeginInit();
            this.avatar_box.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_5)).BeginInit();
            this.SuspendLayout();
            // 
            // 遊戲ToolStripMenuItem
            // 
            this.遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.保存進度ToolStripMenuItem,
            this.載入進度ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem";
            this.遊戲ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.遊戲ToolStripMenuItem.Text = "遊戲";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "開啟遊戲";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 保存進度ToolStripMenuItem
            // 
            this.保存進度ToolStripMenuItem.Name = "保存進度ToolStripMenuItem";
            this.保存進度ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.保存進度ToolStripMenuItem.Text = "保存進度";
            this.保存進度ToolStripMenuItem.Click += new System.EventHandler(this.保存進度ToolStripMenuItem_Click);
            // 
            // 載入進度ToolStripMenuItem
            // 
            this.載入進度ToolStripMenuItem.Name = "載入進度ToolStripMenuItem";
            this.載入進度ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.載入進度ToolStripMenuItem.Text = "載入進度";
            this.載入進度ToolStripMenuItem.Click += new System.EventHandler(this.載入進度ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.退出ToolStripMenuItem.Text = "結束";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於遊戲ToolStripMenuItem,
            this.關於軟體ToolStripMenuItem});
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // 關於遊戲ToolStripMenuItem
            // 
            this.關於遊戲ToolStripMenuItem.Name = "關於遊戲ToolStripMenuItem";
            this.關於遊戲ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.關於遊戲ToolStripMenuItem.Text = "關於遊戲";
            this.關於遊戲ToolStripMenuItem.Click += new System.EventHandler(this.關於遊戲ToolStripMenuItem_Click);
            // 
            // 關於軟體ToolStripMenuItem
            // 
            this.關於軟體ToolStripMenuItem.Name = "關於軟體ToolStripMenuItem";
            this.關於軟體ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.關於軟體ToolStripMenuItem.Text = "關於軟體";
            this.關於軟體ToolStripMenuItem.Click += new System.EventHandler(this.關於軟體ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.character_box_5);
            this.panel1.Controls.Add(this.character_box_4);
            this.panel1.Controls.Add(this.character_box_3);
            this.panel1.Controls.Add(this.audio_player);
            this.panel1.Controls.Add(this.background_player);
            this.panel1.Controls.Add(this.character_box_2);
            this.panel1.Controls.Add(this.character_box_1);
            this.panel1.Controls.Add(this.avatar_box);
            this.panel1.Controls.Add(this.background);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 705);
            this.panel1.TabIndex = 1;
            // 
            // audio_player
            // 
            this.audio_player.Enabled = true;
            this.audio_player.Location = new System.Drawing.Point(677, 85);
            this.audio_player.Name = "audio_player";
            this.audio_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audio_player.OcxState")));
            this.audio_player.Size = new System.Drawing.Size(236, 50);
            this.audio_player.TabIndex = 5;
            this.audio_player.Visible = false;
            // 
            // background_player
            // 
            this.background_player.Enabled = true;
            this.background_player.Location = new System.Drawing.Point(677, 29);
            this.background_player.Name = "background_player";
            this.background_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("background_player.OcxState")));
            this.background_player.Size = new System.Drawing.Size(236, 50);
            this.background_player.TabIndex = 4;
            this.background_player.Visible = false;
            // 
            // character_box_2
            // 
            this.character_box_2.Location = new System.Drawing.Point(147, 172);
            this.character_box_2.Name = "character_box_2";
            this.character_box_2.Size = new System.Drawing.Size(86, 330);
            this.character_box_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_2.TabIndex = 3;
            this.character_box_2.TabStop = false;
            this.character_box_2.Click += new System.EventHandler(this.character_box_2_Click);
            // 
            // character_box_1
            // 
            this.character_box_1.Location = new System.Drawing.Point(48, 172);
            this.character_box_1.Name = "character_box_1";
            this.character_box_1.Size = new System.Drawing.Size(93, 330);
            this.character_box_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_1.TabIndex = 2;
            this.character_box_1.TabStop = false;
            this.character_box_1.Click += new System.EventHandler(this.character_box_1_Click);
            // 
            // avatar_box
            // 
            this.avatar_box.Controls.Add(this.panel2);
            this.avatar_box.Controls.Add(this.character_name);
            this.avatar_box.Controls.Add(this.avatar);
            this.avatar_box.Location = new System.Drawing.Point(12, 502);
            this.avatar_box.Name = "avatar_box";
            this.avatar_box.Size = new System.Drawing.Size(984, 191);
            this.avatar_box.TabIndex = 1;
            this.avatar_box.Visible = false;
            this.avatar_box.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.select_4);
            this.panel2.Controls.Add(this.select_3);
            this.panel2.Controls.Add(this.select_2);
            this.panel2.Controls.Add(this.select_1);
            this.panel2.Controls.Add(this.dialogue);
            this.panel2.Location = new System.Drawing.Point(194, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 156);
            this.panel2.TabIndex = 4;
            // 
            // select_4
            // 
            this.select_4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_4.Location = new System.Drawing.Point(378, 72);
            this.select_4.Name = "select_4";
            this.select_4.Size = new System.Drawing.Size(352, 53);
            this.select_4.TabIndex = 8;
            this.select_4.Text = "button1";
            this.select_4.UseVisualStyleBackColor = true;
            this.select_4.Visible = false;
            this.select_4.Click += new System.EventHandler(this.select_4_Click);
            // 
            // select_3
            // 
            this.select_3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_3.Location = new System.Drawing.Point(378, 13);
            this.select_3.Name = "select_3";
            this.select_3.Size = new System.Drawing.Size(352, 53);
            this.select_3.TabIndex = 7;
            this.select_3.Text = "button1";
            this.select_3.UseVisualStyleBackColor = true;
            this.select_3.Visible = false;
            this.select_3.Click += new System.EventHandler(this.select_3_Click);
            // 
            // select_2
            // 
            this.select_2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_2.Location = new System.Drawing.Point(20, 72);
            this.select_2.Name = "select_2";
            this.select_2.Size = new System.Drawing.Size(352, 53);
            this.select_2.TabIndex = 6;
            this.select_2.Text = "button1";
            this.select_2.UseVisualStyleBackColor = true;
            this.select_2.Visible = false;
            this.select_2.Click += new System.EventHandler(this.select_2_Click);
            // 
            // select_1
            // 
            this.select_1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select_1.Location = new System.Drawing.Point(20, 13);
            this.select_1.Name = "select_1";
            this.select_1.Size = new System.Drawing.Size(352, 53);
            this.select_1.TabIndex = 5;
            this.select_1.Text = "button1";
            this.select_1.UseVisualStyleBackColor = true;
            this.select_1.Visible = false;
            this.select_1.Click += new System.EventHandler(this.select_1_Click);
            // 
            // dialogue
            // 
            this.dialogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogue.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dialogue.Location = new System.Drawing.Point(0, 0);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(787, 156);
            this.dialogue.TabIndex = 4;
            this.dialogue.Click += new System.EventHandler(this.dialogue_Click);
            // 
            // character_name
            // 
            this.character_name.AutoSize = true;
            this.character_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.character_name.Location = new System.Drawing.Point(194, 8);
            this.character_name.Name = "character_name";
            this.character_name.Size = new System.Drawing.Size(0, 24);
            this.character_name.TabIndex = 3;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(8, 6);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(180, 180);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1008, 705);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // character_box_3
            // 
            this.character_box_3.Location = new System.Drawing.Point(239, 172);
            this.character_box_3.Name = "character_box_3";
            this.character_box_3.Size = new System.Drawing.Size(86, 330);
            this.character_box_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_3.TabIndex = 6;
            this.character_box_3.TabStop = false;
            this.character_box_3.Click += new System.EventHandler(this.character_box_3_Click);
            // 
            // character_box_4
            // 
            this.character_box_4.Location = new System.Drawing.Point(331, 172);
            this.character_box_4.Name = "character_box_4";
            this.character_box_4.Size = new System.Drawing.Size(86, 330);
            this.character_box_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_4.TabIndex = 7;
            this.character_box_4.TabStop = false;
            this.character_box_4.Click += new System.EventHandler(this.character_box_4_Click);
            // 
            // character_box_5
            // 
            this.character_box_5.Location = new System.Drawing.Point(423, 172);
            this.character_box_5.Name = "character_box_5";
            this.character_box_5.Size = new System.Drawing.Size(86, 330);
            this.character_box_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_5.TabIndex = 8;
            this.character_box_5.TabStop = false;
            this.character_box_5.Click += new System.EventHandler(this.character_box_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVG Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.audio_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_1)).EndInit();
            this.avatar_box.ResumeLayout(false);
            this.avatar_box.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 保存進度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入進度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於軟體ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Panel avatar_box;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label character_name;
        private System.Windows.Forms.Label dialogue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox character_box_1;
        private System.Windows.Forms.PictureBox character_box_2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer background_player;
        private AxWMPLib.AxWindowsMediaPlayer audio_player;
        private System.Windows.Forms.Button select_4;
        private System.Windows.Forms.Button select_3;
        private System.Windows.Forms.Button select_2;
        private System.Windows.Forms.Button select_1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox character_box_5;
        private System.Windows.Forms.PictureBox character_box_4;
        private System.Windows.Forms.PictureBox character_box_3;
    }
}

