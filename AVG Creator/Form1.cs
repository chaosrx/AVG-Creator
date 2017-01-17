using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVG_Creator
{

    public partial class Form1 : Form
    {
        int script_lines = 0;
        int current_line = 0;
        string[] script_content;
        string[] game_info; //[0]=遊戲名稱,[1]=作者,[2]=備註,[3]=AVG Creator版本,[4]=遊戲版本
        bool game_loaded = false;

        public Form1()
        {
            InitializeComponent();

            background.Controls.Add(character_box_1);
            background.Controls.Add(character_box_2);
            character_box_1.BackColor = Color.Transparent;
            character_box_2.BackColor = Color.Transparent; //將角色圖案設為透明
        }

        public void Load_Next_Scene()
        {
            string process;
            try
            {
                if (current_line < script_lines && game_loaded == true)
                {
                    process = script_content[current_line].Substring(0, 2);
                    if (process == "//")
                    {
                        current_line++; //Do nothing
                        Load_Next_Scene();
                    }
                    else
                    {
                        process = script_content[current_line].Substring(0, 6);
                        switch (process)
                        {
                            case "[info]":
                                game_info = new string[5];
                                process = script_content[current_line].Remove(0,6);
                                string[] info = process.Split(',');
                                for( int i = 0; i<5; i++ )
                                {
                                    game_info[i] = info[i];
                                }
                                this.Text = game_info[0] + " " + game_info[4];
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[bgim]":
                                process = script_content[current_line].Remove(0, 6);
                                background.Image = Image.FromFile("assets\\" + process);
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[dial]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] dial = process.Split(',');
                                character_name.Text = dial[0];
                                dialogue.Text = dial[1];
                                avatar.Image = Image.FromFile("assets\\" + dial[2]);
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[char]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] character = process.Split(',');
                                if( character[0] == "1" )
                                {
                                    character_box_1.Image = Image.FromFile("assets\\" + character[1]);
                                    character_box_1.Location = new Point(Int32.Parse(character[2]), Int32.Parse(character[3]));
                                    character_box_1.Size = new Size(Int32.Parse(character[4]), Int32.Parse(character[5]));
                                }
                                if (character[0] == "2")
                                {
                                    character_box_2.Image = Image.FromFile("assets\\" + character[1]);
                                    character_box_2.Location = new Point(Int32.Parse(character[2]), Int32.Parse(character[3]));
                                    character_box_2.Size = new Size(Int32.Parse(character[4]), Int32.Parse(character[5]));
                                }
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[next]":
                                current_line++;
                            break;

                            case "[crcl]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] crcl = process.Split(',');
                                if (crcl[0] == "1")
                                {
                                    character_box_1.Image = null;
                                }
                                if (crcl[0] == "2")
                                {
                                    character_box_2.Image = null;
                                }

                                if (crcl[0] == "3")
                                {
                                    character_box_1.Image = null;
                                    character_box_2.Image = null;
                                }
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[dlcl]":
                                character_name.Text = "";
                                dialogue.Text = "";
                                avatar.Image = null;
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[plmc]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] plmc = process.Split(',');
                                background_player.URL = "assets\\" + plmc[0];
                                background_player.settings.volume = Int32.Parse(plmc[1]);
                                background_player.Ctlcontrols.play();
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[stmc]":
                                background_player.Ctlcontrols.stop();
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[plau]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] plau = process.Split(',');
                                audio_player.URL = "assets\\" + plau[0];
                                audio_player.settings.volume = Int32.Parse(plau[1]);
                                audio_player.Ctlcontrols.play();
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[full]":
                                avatar_box.Visible = false;
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[show]":
                                avatar_box.Visible = true;
                                current_line++;
                                Load_Next_Scene();
                            break;
                        }

                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("載入腳本時發生錯誤：\r" + e, "錯誤訊息",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("確定要退出嗎？","訊息", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void 關於軟體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // 背景设成透明还是必要的，控件上的图形在后面画
            avatar_box.BackColor = Color.Transparent;
            Rectangle rect = e.ClipRectangle;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 画控件上的图形，这里以一个线性渐变的图为例。
            // 注意此处，128是透明度，范围是0-255。
            // 如果控件上放一个不透明的图片，则须先将其处理为透明的。
            LinearGradientBrush baseBackground = new LinearGradientBrush(rect,
                        Color.FromArgb(128, 191, 191, 191),
                        Color.FromArgb(128, 255, 255, 255),
                        270, false);
            e.Graphics.FillRectangle((Brush)baseBackground, rect);
            e.Graphics.Flush();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            script_lines = 0;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Assembly.GetExecutingAssembly().Location;
            openFileDialog1.Filter = "AVG Creator(*.avgcreator)|*.avgcreator";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true; //使用 openFileDialog 來讀取腳本文件

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string line;
                    // Read the file and display it line by line.
                    System.IO.StreamReader file =
                       new System.IO.StreamReader(openFileDialog1.FileName);

                    script_content = new string[100000];

                    while ((line = file.ReadLine()) != null)
                    {
                        script_content[script_lines] = line.ToString();
                        script_lines++;
                    }

                    //script_content = new string[script_lines];

                    file.Close();

                    game_loaded = true;
                    Load_Next_Scene();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取文件時發生錯誤：" + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Load_Next_Scene();
        }

        private void dialogue_Click(object sender, EventArgs e)
        {
            Load_Next_Scene();
        }

        private void 關於遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( game_loaded == true )
            {
                MessageBox.Show(game_info[2] + "\nPowered by AVG Creator v" + game_info[3], game_info[0] + " " + game_info[4] + " by " + game_info[1]);
            } else
            {
                MessageBox.Show("尚未載入遊戲","訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
