using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVG_Creator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(character_box_1);
            pictureBox1.Controls.Add(character_box_2);
            character_box_1.BackColor = Color.Transparent;
            character_box_2.BackColor = Color.Transparent;
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
            dialogue.Text = "不管是排水孔阻塞，豬頭，我的，廢話少說，妳好，呼叫總部，年假結束了，做到了，鑽地，你表現得很棒，射擊，動作大一點，等等我啊，等等嘛！喝完热咖啡，白天总有点头疼，只有中國酒店，我聞到妳身上的香味，效果一样。只剩傾盆的思念獨處的時候，好想你我好想你，更適合飛翔，就這一次，一雙眼和一雙眼從此不交會讓我心情可以很好，一定最瘋狂，逆著風，改變既有的模式！今天的咖啡煮浓了……去趟超市，都有可能。老闆";
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
    }
}
