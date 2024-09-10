using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
                form8.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f=new Form6();
                f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 f=new Form15();
            f.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f=new Form16();
                f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.ShowDialog();
        }
    }
}
