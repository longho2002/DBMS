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
    
    public partial class EditPublish : Form
    {
        private MY_DB db = new MY_DB();
        public EditPublish()
        {
            InitializeComponent();
        }

        private void EditPublish_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Publishing_Company where Publishing_Company_ID = '" + Globals.idAuth + "'", db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            tb_name.Text = dt.Rows[0][1].ToString();
            tb_address.Text = dt.Rows[0][2].ToString();
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

        private void btn_can_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update_Publishing_Company", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Publishing_Company_ID", SqlDbType.VarChar, 100).Value = Globals.idPublish;
                cmd.Parameters.Add("@Publishing_Company_Name", SqlDbType.NVarChar, 100).Value = tb_name.Text;
                cmd.Parameters.Add("@Headquarters", SqlDbType.NVarChar, 100).Value = tb_address.Text;
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap nhat thanh cong");
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
