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

namespace Template.Publish_Company
{
    public partial class AddPublish : Form
    {
        private MY_DB db = new MY_DB();
        public AddPublish()
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
                SqlCommand cmd = new SqlCommand("insert_Publishing_Company", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Publishing_Company_Name", SqlDbType.NVarChar, 100).Value = tb_name.Text;
                cmd.Parameters.Add("@Headquarters", SqlDbType.NVarChar, 100).Value = tb_address.Text;

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
