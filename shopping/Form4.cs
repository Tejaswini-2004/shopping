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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f= new Form5();   
                f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();  
                form9.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form30   f= new Form30(); 
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
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
