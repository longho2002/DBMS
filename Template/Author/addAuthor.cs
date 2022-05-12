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

namespace Template.Author
{
    public partial class AddAuthor : Form
    {
        private MY_DB db = new MY_DB();
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_Author", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Author_Name", SqlDbType.NVarChar, 100).Value = tb_Name.Text;
                cmd.Parameters.Add("@Date_of_Birth", SqlDbType.Date, 100).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@HomeTown", SqlDbType.NVarChar, 100).Value = tb_address.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit, 100).Value = radioButtonMale.Checked == true ? 1 :0;
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

        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
