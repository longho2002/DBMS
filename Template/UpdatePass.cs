using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Template
{
    public partial class UpdatePass : Form
    {
        MY_DB db = new MY_DB();
        public UpdatePass()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text != tb_repass.Text)
            {
                MessageBox.Show("Not Match Password!");
                return;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("update_Password", db.getConnection);
                cmd.Parameters.Add("@executor_id", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@affected_id", SqlDbType.VarChar).Value = Globals.idUsertmp;
                cmd.Parameters.Add("@old_pwd", SqlDbType.VarChar).Value = tb_oldpass.Text;
                cmd.Parameters.Add("@new_pwd", SqlDbType.VarChar).Value = tb_pass.Text;
                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucess");
                db.closeConnection();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
