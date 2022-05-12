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
using Template.Author;
using Template.Publish_Company;

namespace Template
{
    public partial class bookInfo : Form
    {
        MY_DB db = new MY_DB();
        public bookInfo()
        {
            InitializeComponent();
        }

        private void bookInfo_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT* FROM All_of_Book where Book_ID = '" + Globals.idBook_Infor + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                if(dt.Rows.Count ==0)
                {
                    MessageBox.Show("Not Found!");
                    this.Close();
                }

                tb_name.Text = dt.Rows[0]["Book_Name"].ToString();
                tb_pos.Text = dt.Rows[0]["Position"].ToString();
                date_buy.Value = (DateTime)dt.Rows[0]["Pruchase_Date"];
                tb_cat.Text = dt.Rows[0]["Book_Category"].ToString();
                tb_auth.Text = dt.Rows[0]["Author_Name"].ToString();
                tb_nxb.Text = dt.Rows[0]["Publishing_Company_Name"].ToString();
                tb_price.Text = dt.Rows[0]["Price"].ToString();
                date_publish.Value = (DateTime)dt.Rows[0]["Publication_Date"];
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            AddAuthor a = new AddAuthor();
            a.btn_add.Visible = false;
             try
            {
                SqlCommand command = new SqlCommand("SELECT Author_Name, Date_of_Birth, HomeTown, Gender FROM Book join author on author.Author_ID = book.Author_ID where Book_ID = '" + Globals.idBook_Infor + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                if(dt.Rows.Count ==0)
                {
                    MessageBox.Show("Not Found!");
                    this.Close();
                }

                a.tb_Name.Text = dt.Rows[0]["Author_Name"].ToString();
                a.tb_address.Text = dt.Rows[0]["HomeTown"].ToString();
                if(dt.Rows[0]["Gender"].ToString().Equals("True"))
                    a.radioButtonMale.Checked = true;
                else
                {
                    a.radioButtonFemale.Checked = true;
                }

                a.dateTimePicker1.Value = (DateTime)dt.Rows[0]["Date_of_Birth"];
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            a.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPublish a = new AddPublish();
            a.btn_add.Visible = false;
            try
            {
                SqlCommand command = new SqlCommand("SELECT Headquarters,Publishing_Company_Name FROM Book join Publishing_Company on Publishing_Company.Publishing_Company_ID = book.Publishing_Company_ID where Book_ID = '" + Globals.idBook_Infor + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    this.Close();
                }

                a.tb_name.Text = dt.Rows[0]["Publishing_Company_Name"].ToString();
                a.tb_address.Text = dt.Rows[0]["Headquarters"].ToString();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            a.ShowDialog();
        }
    }
}
