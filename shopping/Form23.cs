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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\cart.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into cart2 values(@productid,@name,@cost)", conn);

            cmd.Parameters.AddWithValue("@productid",int.Parse( textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@cost", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show(" Added to cart.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            conn.Close();

        }

        private void Form23_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\cart.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into cart2 values(@productid,@name,@cost)", conn);

            cmd.Parameters.AddWithValue("@productid", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@name", textBox5.Text);
            cmd.Parameters.AddWithValue("@cost", int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show(" Added to cart.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.ShowDialog();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();   
            form24.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.ShowDialog();    
        }
    }
}
