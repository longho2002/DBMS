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
    public partial class BorrowInfo : Form
    {
        MY_DB db = new MY_DB();
        public BorrowInfo()
        {
            InitializeComponent();
        }

        private void BorrowInfo_Load(object sender, EventArgs e)
        {
            lb_idbook.Text = Globals.idBook_Infor;
            try
            {
                SqlCommand command = new SqlCommand("SELECT* FROM All_of_Book where Book_ID = '" + Globals.idBook_Infor + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    this.Close();
                }
                lb_namebook.Text = dt.Rows[0]["Book_Name"].ToString();
                lb_idbook.Text = dt.Rows[0]["Book_ID"].ToString();
                lb_dateborrow.Text = DateTime.Now.ToString().Split(' ')[0];
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_iduser.Text.Trim() == "")
                {
                    MessageBox.Show("Vui long chon nguoi muon ");
                    return;
                }
                SqlCommand cmd = new SqlCommand("insert_Borrowed_Information", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                db.openConnection();
                cmd.Parameters.Add("@Borrowed_Date", SqlDbType.Date, 100).Value = DateTime.Now.Date;
                cmd.Parameters.Add("@Payment_Appointment_Date", SqlDbType.Date, 100).Value =
                    dateReturn.Value.Date;
                cmd.Parameters.Add("@users_ID", SqlDbType.VarChar).Value = Globals.idUsertmp;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar).Value = lb_idbook.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("thanh cong");
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
          

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE users_ID = '" + tb_searchUser.Text + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    lb_nameuser.Text = "";
                    tb_searchUser.Text = "";
                    lb_dateofbirth.Text = "";
                    lb_iduser.Text = "";
                    rjCircularPictureBox1.Image = null;
                    throw new Exception("Not Found!");
                }
                Globals.setIDUsertmp(dt.Rows[0][0].ToString());
                lb_nameuser.Text = dt.Rows[0][1].ToString();
                lb_dateofbirth.Text = dt.Rows[0][2].ToString().Split(' ')[0];
                lb_iduser.Text = dt.Rows[0][0].ToString();
                rjCircularPictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "user.jpg");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
