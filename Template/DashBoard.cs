using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Template
{
    public partial class DashBoard : Form
    {
        private int option = 0;
        private MY_DB db = new MY_DB();
        public DashBoard()
        {
            InitializeComponent();
            //createQuaHan();
            //createMuon();
            //createLoi();
            //createTra();
            //createDenbu();
        }
        private void Guna2Button13_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            option = 0;
            CreateMuon();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            option = 1;
            CreateTra();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            option = 2;
            CreateLoi();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            option = 3;
            CreateQuaHan();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            option = 4;
            CreateDenbu();
        }
        private void btn_Borrow_Now_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update_Borrowed_Information", db.getConnection);
                cmd.Parameters.Add("@Borrowed_Information_ID", SqlDbType.Date, 100).Value = ((sender as Guna2Button).Parent as Panel).Controls[0].Text;
                cmd.Parameters.Add("@Librarian_ID", SqlDbType.Date, 100).Value = Globals.idUser;
                cmd.Parameters.Add("@Option", SqlDbType.Date, 100).Value = 1;

                db.openConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                db.closeConnection();
            }
        }




        private void CreateQuaHan()
        {
            //pan_quahan.Location = new Point(10, 175);
            //pan_quahan.Name = "pan_quahan";
            //pan_quahan.Size = new Size(781, 100);
            panMain.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.getAll_Book_OutofDate(@search)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Byte[] data = new Byte[0];
                data = item["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "book.jpg")) : (Byte[])(item["picture"]);
                MemoryStream mem = new MemoryStream(data);
                panMain.Controls.Add(QuaHan(item["Borrowed_Information_ID"].ToString(), item["usersname"].ToString(), item["Book_Name"].ToString(), item["Borrowed_Date"].ToString().Split(' ')[0], item["days"].ToString().Split(' ')[0], Image.FromStream(mem), 45, 30 + 100 * i + 20 * i));
                i++;
            }
            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }
        private void CreateMuon()
        {
            //pan_quahan.Location = new Point(10, 175);
            //pan_quahan.Name = "pan_quahan";
            //pan_quahan.Size = new Size(781, 100);
            panMain.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.get_All_Book_Borrowing(@search)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Byte[] data = new Byte[0];
                data = item["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "book.jpg")) : (Byte[])(item["picture"]);
                MemoryStream mem = new MemoryStream(data);
                panMain.Controls.Add(Muon(item["Borrowed_Information_ID"].ToString(),  item["Book_Name"].ToString(), item["usersname"].ToString(), item["Borrowed_Date"].ToString().Split(' ')[0], Image.FromStream(mem), 45, 30 + 100 * i + 20 * i));
                i++;
            }

            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }
        private void CreateLoi()
        {
            //pan_quahan.Location = new Point(10, 175);
            //pan_quahan.Name = "pan_quahan";
            //pan_quahan.Size = new Size(781, 100);
            panMain.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.getAll_Book_waitingForCompensation(@search)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Byte[] data = new Byte[0];
                data = item["picture"].ToString() == "" ? System.IO.File.ReadAllBytes(Application.StartupPath + "\\Resources\\" + "book.jpg") : (Byte[])(item["picture"]);
                MemoryStream mem = new MemoryStream(data);
                panMain.Controls.Add(Loi(item["Borrowed_Information_ID"].ToString(), item["Book_Name"].ToString(), item["usersname"].ToString(), item["Borrowed_Date"].ToString().Split(' ')[0], item["Price"].ToString(), Image.FromStream(mem), 45, 30 + 100 * i + 20 * i));
                i++;
            }
            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }
        private void CreateTra()
        {
            panMain.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.get_All_Book_Paid(@search)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                //System.IO.File.ReadAllBytes(@"path/to/image.extension");
                Byte[] data = new Byte[0];
                data = item["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "book.jpg")) : (Byte[])(item["picture"]);
                MemoryStream mem = new MemoryStream(data);
                panMain.Controls.Add(Tra(item["Borrowed_Information_ID"].ToString(), item["Book_Name"].ToString(), item["usersname"].ToString(), item["Borrowed_Date"].ToString().Split(' ')[0], item["Return_Day"].ToString().Split(' ')[0], Image.FromStream(mem), 45, 30 + 100 * i + 20 * i));
                i++;
            }

            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }
        private void CreateDenbu()
        {
            panMain.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select * from dbo.getAll_book_compensated(@search)", db.getConnection);
            cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_search.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                Byte[] data = new Byte[0];
                data = item["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "book.jpg")) : (Byte[])(item["picture"]);
                MemoryStream mem = new MemoryStream(data);
                panMain.Controls.Add(Denbu(item["Borrowed_Information_ID"].ToString(), item["Book_Name"].ToString(), item["usersname"].ToString(), item["Borrowed_Date"].ToString().Split(' ')[0], item["Return_Day"].ToString().Split(' ')[0], Image.FromStream(mem), item["Price"].ToString(), 45, 30 + 100 * i + 20 * i));
                i++;
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    panMain.Controls.Add(Denbu(45, 30 + 100 * i + 20 * i));
            //}
            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }

        private Panel QuaHan(string id, string nameU, string nameB, string dateBorrow, string dateQH, Image image, int x, int y)
        {
            Panel pan_quahan = new Panel();
            // 
            // label8
            // 
            Label lb_quahan = new Label();
            lb_quahan.AutoSize = true;
            lb_quahan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_quahan.Location = new Point(526, 53);
            lb_quahan.Size = new Size(70, 20);
            lb_quahan.Text = "Quá hạn";
            // 
            // label7
            // 
            Label lb_ngaymuon = new Label();
            lb_ngaymuon.AutoSize = true;
            lb_ngaymuon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_ngaymuon.Location = new Point(526, 24);
            lb_ngaymuon.Size = new Size(89, 20);
            lb_ngaymuon.Text = "Ngày mượn";
            // 
            // label6
            // 
            Label lb_datequahan = new Label();
            lb_datequahan.AutoSize = true;
            lb_datequahan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_datequahan.ForeColor = Color.Red;
            lb_datequahan.Location = new Point(631, 53);
            lb_datequahan.Size = new Size(65, 20);
            lb_datequahan.Text = dateQH + " ngày";
            // 
            // label2
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = SystemColors.ActiveCaptionText;
            lb_book.Location = new Point(110, 52);
            lb_book.Size = new Size(121, 19);
            lb_book.Text = "Book: " + nameB;
            lb_book.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 

            Label date_muon = new Label();
            date_muon.AutoSize = true;
            date_muon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            date_muon.Location = new Point(631, 24);
            date_muon.Size = new Size(80, 20);
            date_muon.Text = dateBorrow;
            // 
            // label5
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(110, 24);
            lb_name.Size = new Size(190, 19);
            lb_name.Text = "Name: " + nameU;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            Guna2PictureBox pic = new Guna2PictureBox();
            pic.BackColor = Color.Transparent;
            pic.BorderRadius = 30;
            pic.Location = new Point(6, 6);
            pic.Name = "guna2PictureBox2";
            pic.Size = new Size(85, 89);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.TabStop = false;
            pic.Image = image;
            //
            // pan_quahan
            // 
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };

            pan_quahan.Controls.Add(lb_id);
            pan_quahan.Controls.Add(lb_name);
            pan_quahan.Controls.Add(lb_quahan);
            pan_quahan.Controls.Add(lb_ngaymuon);
            pan_quahan.Controls.Add(lb_datequahan);
            pan_quahan.Controls.Add(lb_book);
            pan_quahan.Controls.Add(date_muon);
            pan_quahan.Controls.Add(pic);
            pan_quahan.Location = new Point(x, y);
            pan_quahan.Name = "pan_quahan";
            pan_quahan.Size = new Size(794, 100);
            pan_quahan.Margin = new Padding(0, 0, 0, 100);

            return pan_quahan;
        }
        private Panel Muon(string id, string nameB, string nameU, string dateMuon, Image image, int x, int y)
        {
            // 
            // label4
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = SystemColors.ActiveCaptionText;
            lb_book.Location = new Point(110, 52);
            lb_book.Size = new Size(121, 19);
            lb_book.Text = "Book: " + nameB;
            lb_book.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_date_muon
            // 
            Label lb_date_muon = new Label();
            lb_date_muon.AutoSize = true;
            lb_date_muon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_date_muon.Location = new Point(435, 44);
            lb_date_muon.Size = new Size(80, 20);
            lb_date_muon.Text = dateMuon;
            // 
            // lb_name
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(110, 24);
            lb_name.Size = new Size(190, 19);
            lb_name.Text = "Name: " + nameU;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            Guna2Button btn_add = new Guna2Button();
            btn_add.Animated = true;
            btn_add.BackColor = Color.Transparent;
            btn_add.BorderColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            btn_add.BorderRadius = 10;
            btn_add.BorderThickness = 1;
            btn_add.FillColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_add.ForeColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            btn_add.HoverState.FillColor = Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            btn_add.HoverState.ForeColor = Color.Black;
            btn_add.Location = new Point(688, 36);
            btn_add.Size = new Size(64, 32);
            btn_add.Text = "Báo lỗi";
            btn_add.Click += btn_Loi_click;
            // 
            // btn_Borrow_Now
            // 
            Guna2Button btn_Borrow_Now = new Guna2Button();
            btn_Borrow_Now.Animated = true;
            btn_Borrow_Now.BackColor = Color.Transparent;
            btn_Borrow_Now.BorderRadius = 10;
            btn_Borrow_Now.FillColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            btn_Borrow_Now.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_Borrow_Now.ForeColor = Color.White;
            btn_Borrow_Now.HoverState.FillColor = Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            btn_Borrow_Now.Location = new Point(597, 36);
            btn_Borrow_Now.Size = new Size(64, 34);
            btn_Borrow_Now.Text = "Trả";
            // 
            // guna2PictureBox1
            // 
            Guna2PictureBox guna2PictureBox1 = new Guna2PictureBox();
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BorderRadius = 30;
            guna2PictureBox1.Location = new Point(6, 6);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.Size = new Size(85, 89);
            guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Image = image;
            // 
            // pan_Borrow
            // 
            btn_Borrow_Now.Click += btn_Tra_click;
            Panel pan_Borrow = new Panel();
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };
            pan_Borrow.Controls.Add(lb_id);
            pan_Borrow.Controls.Add(lb_book);
            pan_Borrow.Controls.Add(lb_date_muon);
            pan_Borrow.Controls.Add(lb_name);
            pan_Borrow.Controls.Add(guna2PictureBox1);
            pan_Borrow.Controls.Add(btn_add);
            pan_Borrow.Controls.Add(btn_Borrow_Now);
            pan_Borrow.Location = new Point(x, y);
            pan_Borrow.Name = "pan_Borrow";
            pan_Borrow.Size = new Size(794, 100);

            return pan_Borrow;
        }
        private Panel Loi(string id, string nameB, string nameU, string dateMuon, string price, Image image, int x, int y)
        {
            // 
            // label10
            // 
            Label lb_ngaymuon = new Label();
            lb_ngaymuon.AutoSize = true;
            lb_ngaymuon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_ngaymuon.Location = new Point(404, 24);
            lb_ngaymuon.Size = new Size(89, 20);
            lb_ngaymuon.Text = "Ngày mượn";
            // 
            // label12
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = SystemColors.ActiveCaptionText;
            lb_book.Location = new Point(110, 52);
            lb_book.Size = new Size(121, 19);
            lb_book.Text = "Book: " + nameB;
            lb_book.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            Label lb_date = new Label();
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_date.Location = new Point(509, 24);
            lb_date.Size = new Size(80, 20);
            lb_date.Text = dateMuon;
            // 
            // label14
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(110, 24);
            lb_name.Name = "label14";
            lb_name.Size = new Size(190, 19);
            lb_name.TabIndex = 43;
            lb_name.Text = "Name: " + nameU;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button5
            // 
            Guna2Button btn_denbu = new Guna2Button();
            btn_denbu.Animated = true;
            btn_denbu.BackColor = Color.Transparent;
            btn_denbu.BorderRadius = 10;
            btn_denbu.FillColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            btn_denbu.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_denbu.ForeColor = Color.White;
            btn_denbu.HoverState.FillColor = Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            btn_denbu.Location = new Point(681, 35);
            btn_denbu.Size = new Size(76, 34);
            btn_denbu.Text = "Đền bù";
            btn_denbu.Click += btn_Denbu_click;
            // 
            // label9
            // 
            Label lb_giatien = new Label();
            lb_giatien.AutoSize = true;
            lb_giatien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_giatien.Location = new Point(404, 52);
            lb_giatien.Size = new Size(64, 20);
            lb_giatien.Text = "Giá tiền";
            // 
            // label11
            // 
            Label lb_money = new Label();
            lb_money.AutoSize = true;
            lb_money.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_money.Location = new Point(509, 52);
            lb_money.Size = new Size(101, 20);
            lb_money.Text = price + " VND";
            // 
            // guna2PictureBox3
            // 
            Guna2PictureBox guna2PictureBox31 = new Guna2PictureBox();
            guna2PictureBox31.BackColor = Color.Transparent;
            guna2PictureBox31.BorderRadius = 30;
            guna2PictureBox31.Location = new Point(6, 6);
            guna2PictureBox31.Size = new Size(85, 89);
            guna2PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            guna2PictureBox31.TabStop = false;
            guna2PictureBox31.Image = image;
            // 
            // pan_Offset
            // 
            Panel pan_err = new Panel();

            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };
            pan_err.Controls.Add(lb_id);
            pan_err.Controls.Add(lb_giatien);
            pan_err.Controls.Add(lb_money);
            pan_err.Controls.Add(btn_denbu);
            pan_err.Controls.Add(lb_ngaymuon);
            pan_err.Controls.Add(lb_book);
            pan_err.Controls.Add(lb_date);
            pan_err.Controls.Add(lb_name);
            pan_err.Controls.Add(guna2PictureBox31);
            pan_err.Location = new Point(x, y);
            pan_err.Size = new Size(794, 100);
            pan_err.TabIndex = 130;

            return pan_err;
        }
        private Panel Tra(string id, string nameB, string nameU, string dateMuon, string dateTra, Image image, int x, int y)
        {
            // 
            // label8
            // 
            Label lb_ngaytra = new Label();
            lb_ngaytra.AutoSize = true;
            lb_ngaytra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_ngaytra.Location = new Point(535, 53);
            lb_ngaytra.Size = new Size(68, 20);
            lb_ngaytra.Text = "Ngày trả:";
            // 
            // label7
            // 
            Label lb_ngaymuon = new Label();
            lb_ngaymuon.AutoSize = true;
            lb_ngaymuon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_ngaymuon.Location = new Point(535, 24);
            lb_ngaymuon.Size = new Size(89, 20);
            lb_ngaymuon.Text = "Ngày mượn:";
            // 
            // label6
            // 
            Label lb_dateReturn = new Label();
            lb_dateReturn.AutoSize = true;
            lb_dateReturn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_dateReturn.Location = new Point(640, 53);
            lb_dateReturn.Size = new Size(80, 20);
            lb_dateReturn.Text = dateTra;
            // 
            // label2
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = SystemColors.ActiveCaptionText;
            lb_book.Location = new Point(110, 52);
            lb_book.Size = new Size(121, 19);
            lb_book.Text = "Book: " + nameB;
            lb_book.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            Label dateBorrow = new Label();
            dateBorrow.AutoSize = true;
            dateBorrow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dateBorrow.Location = new Point(640, 24);
            dateBorrow.Size = new Size(80, 20);
            dateBorrow.Text = dateMuon;
            // 
            // label5
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(110, 24);
            lb_name.Size = new Size(190, 19);
            lb_name.Text = "Name: " + nameU;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            Guna2PictureBox guna2PictureBox2 = new Guna2PictureBox();
            guna2PictureBox2.BackColor = Color.Transparent;
            guna2PictureBox2.BorderRadius = 30;
            guna2PictureBox2.Location = new Point(6, 6);
            guna2PictureBox2.Size = new Size(85, 89);
            guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabStop = false;
            guna2PictureBox2.Image = image;

            // 
            // pan_Return
            // 
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };
            Panel pan_return = new Panel();
            pan_return.Controls.Add(lb_id);
            pan_return.Controls.Add(lb_ngaytra);
            pan_return.Controls.Add(lb_ngaymuon);
            pan_return.Controls.Add(lb_dateReturn);
            pan_return.Controls.Add(lb_book);
            pan_return.Controls.Add(dateBorrow);
            pan_return.Controls.Add(lb_name);
            pan_return.Controls.Add(guna2PictureBox2);
            pan_return.Location = new Point(x, y);
            pan_return.Size = new Size(794, 100);

            return pan_return;
        }
        private Panel Denbu(string id, string nameB, string nameU, string dateMuon, string dateTra, Image image, string price, int x, int y)
        {
            // 
            // label1
            // 
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(637, 23);
            label1.Size = new Size(83, 20);
            label1.Text = "Đã đền bù";
            // 
            // label4
            // 
            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new Point(378, 24);
            label4.Size = new Size(89, 20);
            label4.Text = "Ngày mượn";
            // 
            // label9
            // 
            Label lb_money = new Label();
            lb_money.AutoSize = true;
            lb_money.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_money.ForeColor = Color.Red;
            lb_money.Location = new Point(637, 55);
            lb_money.Size = new Size(110, 20);
            lb_money.Text = price + " VND";
            // 
            // label10
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = SystemColors.ActiveCaptionText;
            lb_book.Location = new Point(110, 52);
            lb_book.Size = new Size(121, 19);
            lb_book.Text = "Book: " + nameB;
            lb_book.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            Label lb_date = new Label();
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_date.Location = new Point(483, 24);
            lb_date.Size = new Size(80, 20);
            lb_date.Text = dateMuon;
            // 
            // label12
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(110, 24);
            lb_name.Size = new Size(190, 19);
            lb_name.Text = "Name: " + nameU;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            Guna2PictureBox guna2PictureBox1 = new Guna2PictureBox();
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BorderRadius = 30;
            guna2PictureBox1.Location = new Point(6, 6);
            guna2PictureBox1.Size = new Size(85, 89);
            guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Image = image;
            // 
            // label13
            // 
            Label label13 = new Label();
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new Point(378, 55);
            label13.Size = new Size(68, 20);
            label13.Text = "Ngày trả";
            // 
            // label14
            // 
            Label date_return = new Label();
            date_return.AutoSize = true;
            date_return.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            date_return.Location = new Point(483, 55);
            date_return.Size = new Size(80, 20);
            date_return.Text = dateTra;

            // 
            // pannel_denbu
            // 
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };

            Panel pannel_denbu = new Panel();

            pannel_denbu.Controls.Add(lb_id);
            pannel_denbu.Controls.Add(label13);
            pannel_denbu.Controls.Add(date_return);
            pannel_denbu.Controls.Add(label1);
            pannel_denbu.Controls.Add(label4);
            pannel_denbu.Controls.Add(lb_money);
            pannel_denbu.Controls.Add(lb_book);
            pannel_denbu.Controls.Add(lb_date);
            pannel_denbu.Controls.Add(lb_name);
            pannel_denbu.Controls.Add(guna2PictureBox1);
            pannel_denbu.Location = new Point(x, y);
            pannel_denbu.Size = new Size(794, 100);
            return pannel_denbu;
        }

        private void btn_Tra_click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirm return book~", "return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update_Borrowed_Information", db.getConnection);
                    cmd.Parameters.Add("@Borrowed_Information_ID", SqlDbType.VarChar, 100).Value = ((sender as Guna2Button).Parent as Panel).Controls[0].Text;
                    cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                    cmd.Parameters.Add("@Option", SqlDbType.Int, 100).Value = 0;

                    db.openConnection();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    CreateMuon();
                    db.closeConnection();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                    db.closeConnection();
                }

            }
        }
        private void btn_Loi_click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Báo lỗi", "Error book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                 DialogResult.Yes))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update_Borrowed_Information", db.getConnection);
                    cmd.Parameters.Add("@Borrowed_Information_ID", SqlDbType.VarChar, 100).Value =
                        ((sender as Guna2Button).Parent as Panel).Controls[0].Text;
                    cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                    cmd.Parameters.Add("@Option", SqlDbType.Int, 100).Value = 1;

                    db.openConnection();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    CreateMuon();
                    db.closeConnection();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                    db.closeConnection();
                }
            }
        }
        private void btn_Denbu_click(object sender, EventArgs e)
        {
            Panel a = ((sender as Guna2Button).Parent as Panel);
            string money = a.Controls[2].Text;
            if ((MessageBox.Show("Da thanh toan so tien " + money, "Error book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update_Borrowed_Information", db.getConnection);
                    cmd.Parameters.Add("@Borrowed_Information_ID", SqlDbType.VarChar, 100).Value =
                        ((sender as Guna2Button).Parent as Panel).Controls[0].Text;
                    cmd.Parameters.Add("@Librarian_ID", SqlDbType.VarChar, 100).Value = Globals.idUser;
                    cmd.Parameters.Add("@Option", SqlDbType.Int, 100).Value = 2;
                    db.openConnection();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    CreateLoi();
                    db.closeConnection();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                    db.closeConnection();
                }

            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //CreateTra();
            CreateMuon();        
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (option == 0)
            {
                CreateMuon();
            }
            else if (option == 1)
            {
                CreateTra();
            }
            else if (option == 2)
            {
                CreateLoi();
            }else if (option == 3)
            {
                CreateQuaHan();
            }
            else
            {
                CreateDenbu();
            }
        }
    }
}
