using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Template
{
    public partial class UserInfo : Form
    {
        MY_DB  db = new MY_DB();
        public bool flag = false;

        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Globals.idUsertmp;
            radioButtonMale.Checked = true;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select* from users where users_ID = '" + Globals.idUsertmp + "'", db.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                cmd = new SqlCommand("select* from Librarian where Librarian_ID ='" + Globals.idUsertmp + "'", db.getConnection);
                dt.Rows.Clear();
                da.SelectCommand = cmd;
                da.Fill(dt);
                flag = true;
            }
            //select* from users where users_ID = 'AD-004'
            //select* from Librarian where Librarian_ID = 'AD-004'
            foreach (DataRow item in dt.Rows)
            {
                tb_Name.Text = flag == false ?  item["usersname"].ToString() : item["Librarian_Name"].ToString();
                tb_Address.Text = item["Address"].ToString();
                tb_Phone.Text = item["Phone_Number"].ToString();
                if (item["Gender"].ToString() == "True")
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }
                rjCircularPictureBox1.Image = flag == true
                    ? Image.FromFile(Application.StartupPath + "\\Resources\\" + "user.jpg")
                    : Image.FromFile(Application.StartupPath + "\\Resources\\" + "staff.jpg");
                dateTimePicker1.Value = (DateTime) item["Date_of_Birth"];

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("update_InfPersonal_trans", db.getConnection);
                cmd.Parameters.Add("@executor_id", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@affected_id", SqlDbType.VarChar).Value = Globals.idUsertmp;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("@date_of_Birth", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = radioButtonMale.Checked == true ? 1 : 0;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = tb_Phone.Text;

                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                db.closeConnection();
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("delete_Account", db.getConnection);
                cmd.Parameters.Add("@executor_id", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@affected_id", SqlDbType.VarChar).Value = Globals.idUsertmp;
                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                db.closeConnection();
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePass a = new UpdatePass();
            a.ShowDialog();
        }
    }
}
