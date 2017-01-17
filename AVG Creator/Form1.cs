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
        int answer = 0;
        int software_version = 1000;
        int last_dialog_point = 0;
        int last_background_point = 0;
        int last_summon_point = 0;
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
                                if( Int32.Parse(game_info[3]) > software_version )
                                {
                                    DialogResult result;
                                    result = MessageBox.Show("這款遊戲使用了較高版本的 AVG Creator 製作，如果採用目前版本執行的話有可能會發生錯誤情況。\n要忽略警告訊息繼續載入嗎？", "警告", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                                    if (result == System.Windows.Forms.DialogResult.No)
                                    {
                                        this.Close();
                                    }
                                }
                                this.Text = game_info[0] + " " + game_info[4];
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[bgim]":
                                last_background_point = current_line - 1;
                                process = script_content[current_line].Remove(0, 6);
                                background.Image = Image.FromFile("assets\\" + process);
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[dial]":
                                last_dialog_point = current_line - 1;
                                process = script_content[current_line].Remove(0, 6);
                                string[] dial = process.Split(',');
                                character_name.Text = dial[0];
                                dialogue.Text = dial[1];
                                avatar.Image = Image.FromFile("assets\\" + dial[2]);
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[char]":
                                last_summon_point = current_line - 1;
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

                            case "[goto]":
                                process = script_content[current_line].Remove(0, 6);
                                current_line = Int32.Parse(process)-1;
                                Load_Next_Scene();
                            break;

                            case "[sect]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] sect = process.Split(',');
                                dialogue.Visible = false;
                                if( sect[0] != "null" )
                                {
                                    select_1.Visible = true;
                                    select_1.Text = sect[0];
                                }
                                if (sect[1] != "null")
                                {
                                    select_2.Visible = true;
                                    select_2.Text = sect[1];
                                }
                                if (sect[2] != "null")
                                {
                                    select_3.Visible = true;
                                    select_3.Text = sect[2];
                                }
                                if (sect[3] != "null")
                                {
                                    select_4.Visible = true;
                                    select_4.Text = sect[3];
                                }
                                current_line++;
                                Load_Next_Scene();
                            break;

                            case "[answ]":
                                process = script_content[current_line].Remove(0, 6);
                                string[] answ = process.Split(',');
                                dialogue.Visible = true;

                                select_1.Visible = false;
                                select_2.Visible = false;
                                select_3.Visible = false;
                                select_4.Visible = false;

                                if ( answer == 1 && answ[0] != null )
                                {
                                    current_line = Int32.Parse(answ[0])-1;
                                }
                                if (answer == 2 && answ[1] != null)
                                {
                                    current_line = Int32.Parse(answ[1])-1;
                                }
                                if (answer == 3 && answ[2] != null)
                                {
                                    current_line = Int32.Parse(answ[2]) - 1;
                                }
                                if (answer == 4 && answ[3] != null)
                                {
                                    current_line = Int32.Parse(answ[3]) - 1;
                                }
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

                    file.Close();

                    game_loaded = true;
                    avatar_box.Visible = true;
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

        private void select_1_Click(object sender, EventArgs e)
        {
            answer = 1;
            Load_Next_Scene();
        }

        private void select_2_Click(object sender, EventArgs e)
        {
            answer = 2;
            Load_Next_Scene();
        }

        private void select_3_Click(object sender, EventArgs e)
        {
            answer = 3;
            Load_Next_Scene();
        }

        private void select_4_Click(object sender, EventArgs e)
        {
            answer = 4;
            Load_Next_Scene();
        }

        private void 保存進度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( game_loaded == true )
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "AVG Creator save(*.avgsave)|*.avgsave";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                    }
                    using (StreamWriter newTask = new StreamWriter(saveFileDialog1.FileName, false))
                    {
                        newTask.WriteLine(Math.Min(Math.Min(last_background_point, last_dialog_point), last_summon_point).ToString());
                    }
                }
            } else {
                MessageBox.Show("尚未載入遊戲", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void 載入進度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(game_loaded == true)
            {
                int current;

                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.InitialDirectory = Assembly.GetExecutingAssembly().Location;
                openFileDialog2.Filter = "AVG Creator save(*.avgsave)|*.avgsave";
                openFileDialog2.FilterIndex = 2;
                openFileDialog2.RestoreDirectory = true; //使用 openFileDialog 來讀取腳本文件

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog2.FileName);
                    current = Int32.Parse(sr.ReadToEnd());
                    sr.Close();
                    current_line = current;
                    Load_Next_Scene();
                }
            } else {
                MessageBox.Show("尚未載入遊戲", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
