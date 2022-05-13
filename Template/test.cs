using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Borrow : Form
    {
        private MY_DB db = new MY_DB();
        private string idUser = "";
        private Panel book_borrow = new Panel()
        {
            Visible = false,
        };

        private string nameB = "";
        private int choose = 0;
        public Borrow()
        {
            InitializeComponent();
            renderListbook();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pan_bookBorrow.Controls.Count == 0 || Globals.idUser == "")
            {
                MessageBox.Show("Empty user or book!!!!");
                return;
            }
            SqlCommand cmd = new SqlCommand("select dbo.Check_Borrow_User(@users_ID, @num)", db.getConnection);
            cmd.Parameters.Add("@users_ID", SqlDbType.VarChar).Value = Globals.idUsertmp;
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = pan_bookBorrow.Controls.Count;
            db.openConnection();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
           
            if (result == 0)
            {
                MessageBox.Show("Muon qua so sach quy dinh!");
                return;
            }
            try
            {
                cmd = new SqlCommand("insert_Borrowed_Information", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Panel item in pan_bookBorrow.Controls)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@Borrowed_Date", SqlDbType.Date, 100).Value = DateTime.Now.Date;
                    cmd.Parameters.Add("@Payment_Appointment_Date", SqlDbType.Date, 100).Value =
                        (item.Controls[2] as DateTimePicker).Value.Date;
                    cmd.Parameters.Add("@users_ID", SqlDbType.VarChar).Value = Globals.idUsertmp;
                    cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar).Value = Globals.idUser;
                    cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar).Value = item.Controls[0].Text;
                    cmd.ExecuteNonQuery();
                }
                // commit
                MessageBox.Show("Muon thanh cong~");
                db.closeConnection();
                pan_bookBorrow.Controls.Clear();
                book_borrow.Controls.Clear();
                GC.Collect();
                GC.Collect();
                GC.Collect();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE users_ID = '" + tb_searchUser.Text + "'", db.getConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    lb_name.Text = "";
                    lb_date.Text = "";
                    lb_country.Text = "";
                    lb_gender.Text = "";
                    throw new Exception("Not Found!");
                }
                rjCircularPictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "user.jpg");
                Globals.setIDUsertmp(dt.Rows[0][0].ToString());
                lb_name.Text = dt.Rows[0][1].ToString();
                lb_date.Text = dt.Rows[0][2].ToString().Split(' ')[0];
                lb_country.Text = dt.Rows[0][3].ToString();
                lb_gender.Text = dt.Rows[0]["Gender"].ToString() == "True" ? "Nam" : "Nữ";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void tb_searchBook_TextChanged(object sender, EventArgs e)
        {
            renderListbook();
            renderListbookBorrow();
        }
        //
        // book
        //
        private void renderListbook()
        {

            string tmp = tb_searchBook.Text.Trim().Equals("") ? " " : tb_searchBook.Text.Trim();
            string list ="";
            if (book_borrow.Controls.Count == 0)
            {
                list = " ";
            }
            else
            {
                foreach (Panel item in book_borrow.Controls)
                {
                    list +=item.Controls[0].Text + ",";
                }
                list = list.Remove(list.Length - 1, 1);
            }
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("searchBook", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = tmp;
            cmd.Parameters.Add("@list", SqlDbType.NVarChar).Value = list;
            da.SelectCommand = cmd;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "result_name");
            DataTable dt = ds.Tables["result_name"];

            pan_listBook.Controls.Clear();
            string s;
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                s = "";
                s += item["Book_Name"].ToString() + " (" + item["Author_Name"].ToString() + ")";
                pan_listBook.Controls.Add(createBook(item["Book_ID"].ToString(), s, 8, 17 + (17 + 15) * i));
                i++;
            }
        }
        private Panel createBook(string id, string name, int x, int y)
        {
            // 
            // label8
            // 8, 17
            Label book = new Label();
            book.AutoSize = true;
            book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book.Location = new System.Drawing.Point(13, 15);
            book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            book.Size = new System.Drawing.Size(210, 16);
            book.Text = name;
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };
            //event

            book.MouseHover += changecolorRed;
            book.Click += borrowBook;
            book.MouseLeave += changecolorBlack;

            Panel panBook = new Panel();
            panBook.Controls.Add(lb_id);
            panBook.Controls.Add(book);
            panBook.Location = new System.Drawing.Point(x, y);
            panBook.Size = new System.Drawing.Size(442, 44);

            return panBook;
        }
        private void changecolorRed(object sender, EventArgs e)
        {
            Label a = sender as Label;
            a.ForeColor = Color.Red;
        }
        private void changecolorBlack(object sender, EventArgs e)
        {
            Label a = sender as Label;
            a.ForeColor = Color.Black;
        }
        private void borrowBook(object sender, EventArgs e)
        {
            book_borrow.Controls.Add((sender as Label).Parent as Panel);
            renderListbook();
            renderListbookBorrow();
        }
        //
        //book borrow
        //
        private void renderListbookBorrow()
        {
            //3, 17
            pan_bookBorrow.Controls.Clear();
            int i = 0;
            foreach (Panel VARIABLE in book_borrow.Controls)
            {
                    pan_bookBorrow.Controls.Add(createBookBorrow( (VARIABLE as Panel).Controls[0].Text, (VARIABLE as Panel).Controls[1].Text,3, 17 + (68 + 15) * i));
                    i++;
            }
        }

        private Panel createBookBorrow(string id, string title, int x, int y)
        {
            Label book = new Label();
            book.AutoSize = true;
            book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book.Location = new System.Drawing.Point(11, 15);
            book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            book.Size = new System.Drawing.Size(210, 16);
            book.Text = title;

            Label lb_del = new Label();
            lb_del.AutoSize = true;
            lb_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_del.ForeColor = System.Drawing.Color.Red;
            lb_del.Location = new System.Drawing.Point(356, 30);
            lb_del.Size = new System.Drawing.Size(56, 20);
            lb_del.Text = "Delete";


            DateTimePicker d = new DateTimePicker();
            d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            d.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            d.Location = new System.Drawing.Point(100, 40);
            d.Size = new System.Drawing.Size(127, 20);

            Label lb_ngaytra = new Label();
            lb_ngaytra.AutoSize = true;
            lb_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_ngaytra.Location = new System.Drawing.Point(11, 41);
            lb_ngaytra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_ngaytra.Size = new System.Drawing.Size(61, 16);
            lb_ngaytra.Text = "Ngày trả:";
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };

            lb_del.Click += deleteBookBorrow;
            Panel pan_bookQueue = new Panel();
            pan_bookQueue.Controls.Add(lb_id);// +
            pan_bookQueue.Controls.Add(lb_ngaytra);
            pan_bookQueue.Controls.Add(d); // +
            pan_bookQueue.Controls.Add(lb_del);
            pan_bookQueue.Controls.Add(book);
            pan_bookQueue.Location = new System.Drawing.Point(x, y);
            pan_bookQueue.Size = new System.Drawing.Size(447, 68);

            return pan_bookQueue;
        }

        private void deleteBookBorrow(object sender, EventArgs e)
        {
            Panel tmp = (sender as Label).Parent as Panel;
            int c = 0;
            foreach (Panel VARIABLE in pan_bookBorrow.Controls)
            {
                if (VARIABLE != tmp)
                    c++;
                else
                {
                    break;
                }
            }
            // list_bookBorrow.RemoveAt(c);
            //render lai 2 cai list
            // khi co du lieu thi thay 0 bang c
            //book_borrow
            book_borrow.Controls.RemoveAt(c);
            renderListbook();
            renderListbookBorrow(); // xong
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tb_searchUser.Text = "";
            lb_name.Text = "";
            lb_date.Text = "";
            lb_country.Text = "";
            lb_gender.Text = "";
        }
    }
}
