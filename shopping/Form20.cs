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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21  f=new Form21();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }
    }
}
