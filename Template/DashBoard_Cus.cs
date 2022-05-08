using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class DashBoard_Cus : Form
    {
        public DashBoard_Cus()
        {
            InitializeComponent();
        }

        private void DashBoard_Cus_Load(object sender, EventArgs e)
        {
            
            DataGridView1.ColumnHeadersHeight = 30;
            DataGridView1.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value = "123";
                DataGridView1.Rows[i].Cells[1].Value = "Cilacap";
                DataGridView1.Rows[i].Cells[2].Value = "Dian";
                DataGridView1.Rows[i].Cells[3].Value = "(239)555-2020";
                DataGridView1.Rows[i].Cells[4].Value = "Cilacap";
                DataGridView1.Rows[i].Cells[5].Value = "Jan 21,2020 -13:30";
            }
            DataGridView1.RowTemplate.Height = 30;
        }
    }
}
