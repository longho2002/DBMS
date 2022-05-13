using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Template
{
    public partial class OverviewUser : Form
    {
        private MY_DB db = new MY_DB();
        public OverviewUser()
        {
            InitializeComponent();
            Globals.setIDUsertmp(Globals.idUser);
        }

        private void OverviewUser_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from users where users_ID ='" + Globals.idUser + "'", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 100).Value = Globals.idUser;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                lb_phone.Text = dt.Rows[0]["Phone_Number"].ToString();
                lb_name.Text = dt.Rows[0]["usersname"].ToString();
                lb_adrs.Text = dt.Rows[0]["Address"].ToString();
                lb_date.Text = ((DateTime)dt.Rows[0]["Date_of_Birth"]).ToString().Split(' ')[0];
                lb_gender.Text = dt.Rows[0]["Gender"].ToString() == "True" ? "Nam" : "Nữ";
                int total = Convert.ToInt32(dt.Rows[0]["toatal_book_borrow"]);
                gunaCircleProgressBar1.Value = total;
                if (total < 5)
                {
                    lb_total.Text = "Can them " + (5 - total).ToString() + " cuon sach de len bac tiep theo";
                    gunaCircleProgressBar1.Value = total / 5 * 100;
                }
                else if (total < 20)
                {
                    lb_total.Text = "Can muon them " + (20 - total).ToString() + " cuon sach de len bac tiep theo";
                    gunaCircleProgressBar1.Value = total / 20 * 100;
                }
                else
                {
                    gunaCircleProgressBar1.Value = 100;
                    lb_total.Text = "Ban da bac cao nhat";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
