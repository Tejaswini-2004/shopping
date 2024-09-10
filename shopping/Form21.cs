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

namespace shopping
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\userdetailss.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into userr values(@userid,@name,@mailid,@mobileno,@gender,@userpassword,@address)", conn);
            cmd.Parameters.AddWithValue("@userid", int.Parse(textBox5.Text)); 
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@mailid", textBox3.Text);
            cmd.Parameters.AddWithValue("@mobileno", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@gender", textBox4.Text);
            cmd.Parameters.AddWithValue("@userpassword", textBox6.Text);
            cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Saved successfully ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Form22 form22 = new Form22();   
            form22.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
