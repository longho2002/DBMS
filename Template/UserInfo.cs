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
    public partial class UserInfo : Form
    {
        MY_DB  db = new MY_DB();
        public static bool flag = false;

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
                tb_Name.Text = item[1].ToString();
                tb_Address.Text = item["Adress"].ToString();
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
                    ? Image.FromFile(Application.StartupPath + "\\Resources\\" + "icon-password-3.jpg")
                    : Image.FromFile(Application.StartupPath + "\\Resources\\" + "icon-password-3.jpg");

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                
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
