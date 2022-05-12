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
    public partial class Register : Form
    {
        private string role;
        private MY_DB db = new MY_DB();
        public Register()
        {
            InitializeComponent();
            Globals.SetUser("AD-004", "admin", "Cozark");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!tb_repass.Text.Equals(tb_pass.Text))
                MessageBox.Show("Wrong re-pass", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (verif())
                try
                {

                    //tb_adrs.Text
                    //tb_name.Text
                    //tb_pass.Text
                    //tb_phone.Text
                    //tb_repass.Text
                    //tb_username.Text;
                    //dateTimePicker1.Value.Date
                    //int gender = rBtn_male.Checked == true ? 1 : 0;
                    //string role = cb_role.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand("create_Account", db.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Creater_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = tb_username.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = tb_pass.Text;
                    cmd.Parameters.Add("@Role", SqlDbType.VarChar, 100).Value = role;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = tb_name.Text;
                    cmd.Parameters.Add("@Date_of_Birth", SqlDbType.Date, 100).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.Add("@Gender", SqlDbType.Bit, 100).Value = rBtn_male.Checked == true ? 1 : 0;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100).Value = tb_adrs.Text;
                    cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar, 100).Value = tb_phone.Text;
                    //set breakpoint
                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    db.closeConnection();
                    MessageBox.Show("Sucesss!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
                MessageBox.Show("Empty Fields", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private bool verif()
        {
            if (tb_adrs.Text.Trim() == "" || tb_name.Text.Trim() == "" || tb_pass.Text.Trim() == "" ||
                tb_phone.Text.Trim() == "" || tb_repass.Text.Trim() == "" || tb_username.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cb_role_SelectedValueChanged(object sender, EventArgs e)
        {
            role = cb_role.SelectedItem.ToString();
            role = role == "Customer" ? "cus" : cb_role.SelectedValue.ToString().ToLower();
        }
    }
}
