using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shopping
{
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form31 form = new Form31();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 f = new Form19();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form32 form32 = new Form32();   
                form32.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form20 form32 = new Form20();
            form32.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form32 = new Form2();
            form32.ShowDialog();
        }
    }
}
