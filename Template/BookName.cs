using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Template
{
    public partial class BookName : Form
    {
        private MY_DB db = new MY_DB();
        public BookName()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Globals.setIDBook(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a book name");
                return;
            }
            SqlCommand cmd = new SqlCommand("select Book_Information_ID, Book_Name from Book_Information", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            DataGridView1.Columns[0].Width = 200;
            DataGridView1.Columns[1].Width = 200;
        }

        private void BookName_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Book_Information_ID, Book_Name from Book_Information", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            DataGridView1.Columns[0].Width = 200;
            DataGridView1.Columns[1].Width = 200;
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Book_Information_ID, Book_Name from Book_Information where concat(Book_Information_ID, Book_Name) like '%"+tb_Search.Text.Trim()+"%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataGridView1.DataSource = null;
            DataGridView1.Rows.Clear();
            DataGridView1.DataSource = dt;
            DataGridView1.Columns[0].Width = 200;
            DataGridView1.Columns[1].Width = 200;
        }
    }
}