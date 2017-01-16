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
            this.character_box_2 = new System.Windows.Forms.PictureBox();
            this.character_box_1 = new System.Windows.Forms.PictureBox();
            this.avatar_box = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dialogue = new System.Windows.Forms.Label();
            this.character_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_1)).BeginInit();
            this.avatar_box.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "開啟遊戲";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 保存進度ToolStripMenuItem
            // 
            this.保存進度ToolStripMenuItem.Name = "保存進度ToolStripMenuItem";
            this.保存進度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存進度ToolStripMenuItem.Text = "保存進度";
            // 
            // 載入進度ToolStripMenuItem
            // 
            this.載入進度ToolStripMenuItem.Name = "載入進度ToolStripMenuItem";
            this.載入進度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.載入進度ToolStripMenuItem.Text = "載入進度";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.panel1.Controls.Add(this.character_box_2);
            this.panel1.Controls.Add(this.character_box_1);
            this.panel1.Controls.Add(this.avatar_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 705);
            this.panel1.TabIndex = 1;
            // 
            // character_box_2
            // 
            this.character_box_2.Image = ((System.Drawing.Image)(resources.GetObject("character_box_2.Image")));
            this.character_box_2.Location = new System.Drawing.Point(64, 172);
            this.character_box_2.Name = "character_box_2";
            this.character_box_2.Size = new System.Drawing.Size(286, 330);
            this.character_box_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_2.TabIndex = 3;
            this.character_box_2.TabStop = false;
            // 
            // character_box_1
            // 
            this.character_box_1.Image = ((System.Drawing.Image)(resources.GetObject("character_box_1.Image")));
            this.character_box_1.Location = new System.Drawing.Point(664, 172);
            this.character_box_1.Name = "character_box_1";
            this.character_box_1.Size = new System.Drawing.Size(286, 330);
            this.character_box_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character_box_1.TabIndex = 2;
            this.character_box_1.TabStop = false;
            // 
            // avatar_box
            // 
            this.avatar_box.Controls.Add(this.panel2);
            this.avatar_box.Controls.Add(this.character_name);
            this.avatar_box.Controls.Add(this.pictureBox2);
            this.avatar_box.Location = new System.Drawing.Point(12, 502);
            this.avatar_box.Name = "avatar_box";
            this.avatar_box.Size = new System.Drawing.Size(984, 191);
            this.avatar_box.TabIndex = 1;
            this.avatar_box.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dialogue);
            this.panel2.Location = new System.Drawing.Point(194, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 156);
            this.panel2.TabIndex = 4;
            // 
            // dialogue
            // 
            this.dialogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogue.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dialogue.Location = new System.Drawing.Point(0, 0);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(787, 156);
            this.dialogue.TabIndex = 4;
            this.dialogue.Text = "字幕";
            // 
            // character_name
            // 
            this.character_name.AutoSize = true;
            this.character_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.character_name.Location = new System.Drawing.Point(194, 8);
            this.character_name.Name = "character_name";
            this.character_name.Size = new System.Drawing.Size(86, 24);
            this.character_name.TabIndex = 3;
            this.character_name.Text = "腳色名稱";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 705);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVGCreator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character_box_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character_box_1)).EndInit();
            this.avatar_box.ResumeLayout(false);
            this.avatar_box.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel avatar_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label character_name;
        private System.Windows.Forms.Label dialogue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox character_box_1;
        private System.Windows.Forms.PictureBox character_box_2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

