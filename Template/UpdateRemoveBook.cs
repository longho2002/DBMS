using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Template.Author;
using Template.Location;
using Template.Publish_Company;

namespace Template
{
    public partial class UpdateRemoveBook : Form
    {
        MY_DB db = new MY_DB();
        private string idA = "";
        private string idP = "";
        private string idPos = "";
        private bool flag = false;
        public UpdateRemoveBook()
        {
            InitializeComponent();
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            AddAuthor a = new AddAuthor();
            a.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_author.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon tac gia de chinh sua!");
                return;
            }
            Globals.setIDAuth(cb_author.SelectedValue.ToString());

            EditAuthor a = new EditAuthor();
            a.Show(this);
        }

        private void btn_publisher_Click(object sender, EventArgs e)
        {
            AddPublish a = new AddPublish(); a.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cb_author.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon NXB de chinh sua!");
                return;
            }
            string text = cb_nxb.SelectedValue.ToString().Trim();
            Globals.setIDAuth(text);
            EditPublish a = new EditPublish(); a.Show(this);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            AddLoc a = new AddLoc(); a.Show(this);
        }

        private void UpdateRemoveBook_Load(object sender, EventArgs e)
        {
            if (Globals.idBook_Infor != null)
            {
                try
                {
                    loadAuthor();
                    loadPos();
                    loadPublish();
                    SqlCommand command = new SqlCommand("SELECT* FROM All_of_Book where Book_ID = '" + Globals.idBook_Infor + "'", db.getConnection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Not Found!");
                        this.Close();
                    }

                    tb_name.Text = dt.Rows[0]["Book_Name"].ToString();
                    date_buy.Value = (DateTime)dt.Rows[0]["Pruchase_Date"];
                    tb_cat.Text = dt.Rows[0]["Book_Category"].ToString();


                    foreach (DataRowView a in cb_author.Items)
                    {
                        if (a.Row.ItemArray[1].ToString().Equals(dt.Rows[0]["Author_Name"].ToString()))
                        {
                            idA = a[0].ToString();
                            break;
                        }
                    }
                    foreach (DataRowView a in cb_nxb.Items)
                    {
                        if (a.Row.ItemArray[1].ToString().Equals(dt.Rows[0]["Publishing_Company_Name"].ToString()))
                        {
                            idP = a[0].ToString();
                            break;
                        }
                    }
                    
                    cb_pos.SelectedValue = idPos = dt.Rows[0]["Position"].ToString();
                    cb_author.SelectedText = dt.Rows[0]["Author_Name"].ToString();
                    cb_nxb.SelectedText = dt.Rows[0]["Publishing_Company_Name"].ToString();
                    tb_price.Text = dt.Rows[0]["Price"].ToString();
                    publish_date.Value = (DateTime)dt.Rows[0]["Publication_Date"];
                    Globals.SetidBook(dt.Rows[0]["Book_Information_ID"].ToString());
                    Globals.setIDBook(dt.Rows[0]["Book_ID"].ToString());
                    Byte[] data = new Byte[0];
                    data = dt.Rows[0]["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "icon-password-3.jpg")) : (Byte[])(dt.Rows[0]["picture"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromStream(mem);
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if (Globals.role.Equals("customer"))
            {
                btn_author.Visible = false;
                btn_pos.Visible = false;
                btn_publisher.Visible = false;
                btn_update.Visible = false;
                btn_chooseIMG.Visible = false;
                btn_editAuth.Visible = false;
                btn_xoa.Visible = false;
                btn_editPub.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_pos.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon Vi tri de chinh sua!");
                return;
            }
            string text = cb_pos.SelectedValue.ToString().Trim();
            Globals.setIDPos(text);
            EditLoc a = new EditLoc(); a.Show(this);
        }
        private void loadAuthor()
        {
            SqlCommand cmd = new SqlCommand("select  Author_ID, author_name from author", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_author.DataSource = dt;
            cb_author.DisplayMember = "author_name";
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
            SqlCommand cmd = new SqlCommand("select Position from Position_Book where current_status = 'False'", db.getConnection);
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
                SqlCommand cmd = new SqlCommand("spUpdateBook", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar).Value = Globals.idBook_Infor;
                cmd.Parameters.Add("@Purchase_Date", SqlDbType.Date).Value = date_buy.Value;
                cmd.Parameters.Add("@Book_Information_ID", SqlDbType.VarChar).Value = Globals.idBook;
                cmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = tb_name.Text;
                cmd.Parameters.Add("@Publication_Date", SqlDbType.Date).Value = publish_date.Value.Date;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = Convert.ToInt32(tb_price.Text.ToString());
                cmd.Parameters.Add("@Book_Category", SqlDbType.NVarChar).Value = tb_cat.Text.ToString();
                cmd.Parameters.Add("@ID_User", SqlDbType.VarChar).Value = Globals.idUser;
                cmd.Parameters.Add("@ID_Author", SqlDbType.VarChar).Value = cb_author.SelectedValue == null ? idA : (string)cb_author.SelectedValue;
                cmd.Parameters.Add("@ID_Publish", SqlDbType.VarChar).Value = cb_nxb.SelectedValue == null ? idP : (string)cb_nxb.SelectedValue;
                cmd.Parameters.Add("@ID_Pos", SqlDbType.VarChar).Value = cb_pos.SelectedValue == null ? idPos : cb_pos.SelectedValue.ToString();
                cmd.Parameters.Add("@picture", SqlDbType.Image).Value = pic.ToArray();
                db.openConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                db.closeConnection();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteBook", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar, 30).Value = Globals.idBook_Infor;
                cmd.Parameters.Add("@ID_User", SqlDbType.VarChar, 30).Value = Globals.idUser;
                //set breakpoint
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Xoa thanh cong");
                this.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void btn_chooseIMG_Click(object sender, EventArgs e)
        {

        }
    }
}
