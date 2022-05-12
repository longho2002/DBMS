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
    public partial class EditAuthor : Form
    {
        private MY_DB db = new MY_DB();
        public EditAuthor()
        {
            InitializeComponent();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete_Author", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Author_ID", SqlDbType.VarChar, 100).Value = Globals.idAuth;
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
            try
            {
                SqlCommand cmd = new SqlCommand("update_Author", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idAuth;
                cmd.Parameters.Add("@Author_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Author_Name", SqlDbType.NVarChar, 100).Value = tb_Name.Text;
                cmd.Parameters.Add("@Date_of_Birth", SqlDbType.Date, 100).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@HomeTown", SqlDbType.NVarChar, 100).Value = tb_address.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit, 100).Value = radioButtonMale.Checked == true ? 1 : 0;
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

        private void EditAuthor_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from author where author_id = '" + Globals.idAuth + "'", db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            tb_Name.Text = dt.Rows[0][1].ToString();
            tb_address.Text = dt.Rows[0][3].ToString();
            dateTimePicker1.Value = (DateTime)dt.Rows[0][3];
            if (dt.Rows[0][4].ToString() == "1")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }
    }
}
