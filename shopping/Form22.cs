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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\userdetailss.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from userr where userid=@userid AND userpassword=@userpassword", conn);
            cmd.Parameters.AddWithValue("@userid", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@userpassword", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show(" Login Successfull.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.Hide();
                Form23 f = new Form23();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials,please register!..", "Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
                form20.ShowDialog();
        }
    }
}
