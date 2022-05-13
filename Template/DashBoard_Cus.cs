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

namespace Template
{
    public partial class DashBoard_Cus : Form
    {
        MY_DB db = new MY_DB();
        public DashBoard_Cus()
        {
            InitializeComponent();
        }

        private void DashBoard_Cus_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        void fillgrid()
        {
            DataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.getAll_BI_User(@search, @id)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 100).Value = Globals.idUser;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.ColumnHeadersHeight = 30;
            DataGridView1.RowTemplate.Height = 30;
            int n = dt.Rows.Count;
            DataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < n; i++)
            {
                DataGridView1.Rows.Add(1);
                DataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["Borrowed_Information_ID"];
                DataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["usersname"];
                DataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["Book_Name"];
                DataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["Borrowed_Date"].ToString().Split(' ')[0];
                DataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["Return_Day"].ToString().Split(' ')[0];
                DataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["Current_Status"];
                if (dt.Rows[i]["Current_Status"].ToString() == "compensated" ||
                    dt.Rows[i]["Current_Status"].ToString() == "waiting for compensation")
                    DataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                else
                {
                    DataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
            }
        }
    }
}
