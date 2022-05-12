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
    public partial class EditLoc : Form
    {
        private MY_DB db = new MY_DB();
        public EditLoc()
        {
            InitializeComponent();
        }

        private void editLoc_Load(object sender, EventArgs e)
        {
            tb_loc.Text = Globals.idPos;
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete_Position_Book", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Position", SqlDbType.VarChar, 100).Value = Globals.idPos;
       
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                db.closeConnection();
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
