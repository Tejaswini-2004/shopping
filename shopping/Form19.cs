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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\Product.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from product", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

            conn.Close();
            MessageBox.Show("Data Select Succesfully .... :)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\Product.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete product where productid=@productid", conn);
            cmd.Parameters.AddWithValue("@productid", int.Parse(textBox1.Text));
            
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" product data deleted Successfully.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            SqlCommand cmd1 = new SqlCommand("select * from product", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            MessageBox.Show(" product data selected Successfully.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();   
                form.ShowDialog();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
