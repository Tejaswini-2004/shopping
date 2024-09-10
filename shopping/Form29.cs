using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
{
    public partial class Form29 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\cart.mdf;Integrated Security=True;Connect Timeout=30");
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public Form29()
        {
            InitializeComponent();
            InitializePrintComponents();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\cart.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(cost) from cart2 ", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

            conn.Close();
            MessageBox.Show("Your Cart..");
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(W, H);
            this.Hide();
        }
        public void AddRow(DataGridViewRow row)
        {
            if (dataGridView1.ColumnCount == 0)
            {
                foreach (DataGridViewColumn column in row.DataGridView.Columns)
                {
                    if (column.Name != "SELECT")
                    {
                        dataGridView1.Columns.Add((DataGridViewColumn)column.Clone());

                    }
                }
            }
            int rowIndex = dataGridView1.Rows.Add();
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.DataGridView.Columns[i].Name != "SELECT")
                {
                    dataGridView1.Rows[rowIndex].Cells[row.DataGridView.Columns[i].Name].Value = row.Cells[i].Value;
                }

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Teju\\OneDrive\\Documents\\cart.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(cost) from cart2 ", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

            conn.Close();
            MessageBox.Show(" Your cart.. ", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }
        private void InitializePrintComponents()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font footerFont = new Font("Arial", 10, FontStyle.Italic);


            float headerHeight = e.Graphics.MeasureString("Header Text", headerFont).Height + 10;
            float footerHeight = e.Graphics.MeasureString("Footer Text", footerFont).Height + 10;


            string headerText = "                                          SHOPPING EXPERIENCE                          ";
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - headerHeight);


            string footerText = $"sasas {DateTime.Now.ToString()}";
            e.Graphics.DrawString(footerText, footerFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + footerHeight / 2);
            Rectangle adjustedBounds = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + (int)headerHeight, e.MarginBounds.Width, e.MarginBounds.Height - (int)headerHeight - (int)footerHeight);


            Bitmap bitmap = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(bitmap, adjustedBounds);
        }
        public void PrintDataGridView()
        {
            printPreviewDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
