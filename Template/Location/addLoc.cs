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

namespace Template.Location
{
    public partial class AddLoc : Form
    {
        private MY_DB db = new MY_DB();
        public AddLoc()
        {
            InitializeComponent();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_Position_Book", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 100).Value = tb_name.Text;
                cmd.Parameters.Add("@Current_Status", SqlDbType.Bit, 100).Value = 0;

                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                db.closeConnection();
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
           
        }
    }
}
