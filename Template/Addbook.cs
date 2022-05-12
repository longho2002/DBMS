using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Template.Author;
using Template.Location;
using Template.Publish_Company;

namespace Template
{
    public partial class Addbook : Form
    {
        private MY_DB db = new MY_DB();

        public Addbook()
        {
            InitializeComponent();
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            AddAuthor a = new AddAuthor();
            a.Show(this);
            loadAuthor();
        }

        private void btn_publisher_Click(object sender, EventArgs e)
        {
            AddPublish a = new AddPublish();
            a.Show(this);
            loadPublish();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            AddLoc a = new AddLoc();
            a.Show(this);
            loadPos();
        }

        private void Addbook_Load(object sender, EventArgs e)
        {
            loadAuthor();
            loadPos();
            loadPublish();
            cb_nxb.SelectedItem = null;
            cb_pos.SelectedItem = null;
            cb_author.SelectedItem = null;
          
        }

        private void loadAuthor()
        {
            SqlCommand cmd = new SqlCommand("select  Author_ID, Author_Name from author", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_author.DataSource = dt;
            cb_author.DisplayMember = "Author_Name";
            cb_author.ValueMember = "Author_ID";
        }
        private void loadPublish()
        {
            SqlCommand cmd = new SqlCommand("select Publishing_Company_ID, Publishing_Company_Name from Publishing_Company", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_nxb.DataSource = dt;
            cb_nxb.DisplayMember = "Publishing_Company_Name";
            cb_nxb.ValueMember = "Publishing_Company_ID";
        }
        private void loadPos()
        {
            SqlCommand cmd = new SqlCommand("select Position from Position_Book where current_status = 0", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_pos.DataSource = dt;
            cb_pos.DisplayMember = "Position";
            cb_pos.ValueMember = "Position";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                SqlCommand cmd = new SqlCommand("spInsertBook", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Purchase_Date", SqlDbType.Date).Value =date_buy.Value;
                cmd.Parameters.Add("@Book_Information_ID", SqlDbType.VarChar).Value = Globals.idBook_Infor;
                cmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = tb_name.Text;
                cmd.Parameters.Add("@Publication_Date", SqlDbType.Date).Value = publish_date.Value.Date;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = Convert.ToInt32(tb_price.Text.ToString());
                cmd.Parameters.Add("@Book_Category", SqlDbType.NVarChar).Value = tb_cat.Text.ToString();
                cmd.Parameters.Add("@ID_User", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@ID_Author", SqlDbType.VarChar).Value = cb_author.SelectedValue.ToString();
                cmd.Parameters.Add("@ID_Publish", SqlDbType.VarChar).Value = cb_nxb.SelectedValue.ToString();
                cmd.Parameters.Add("@ID_Pos", SqlDbType.VarChar).Value = cb_pos.SelectedValue.ToString();
                cmd.Parameters.Add("@picture", SqlDbType.Image).Value = pic.ToArray();
                db.openConnection();
                if ((cmd.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Success!");
                    db.closeConnection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Text = opf.FileName.Split('\\').Last();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Borrow_Now_Click(object sender, EventArgs e)
        {
            Globals.setIDBook("");
            BookName a = new BookName();
            a.ShowDialog();
            ///// đổ chức năng vào đây
            ///

            SqlCommand cmd = new SqlCommand("select * from Book_Information where Book_Information_id = '" + Globals.idBook_Infor + "'", db.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return;
            tb_name.Text = dt.Rows[0][1].ToString();
            publish_date.Value = (DateTime)dt.Rows[0][2];
            tb_cat.Text = dt.Rows[0][3].ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
