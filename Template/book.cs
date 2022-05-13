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
using Guna.UI.Animation.Material;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;

namespace Template
{
    public partial class book : Form
    {
        private int width = 335;
        private int height = 180;
        private int option = 1;
        private string cat = "all";
        MY_DB db = new MY_DB();
        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            fillGrid();
            if (Globals.role.Equals("customer"))
                btn_addbook.Visible = false;
            SqlCommand cmd = new SqlCommand("SELECT distinct book_category FROM All_of_Book", db.getConnection);
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt1);
            cb_cat.Items.Add("all");
            foreach (DataRow i in dt1.Rows)
            {
                cb_cat.Items.Add(i[0].ToString());
            }
            cb_cat.SelectedItem = "all";
            cb_cat.SelectedValueChanged += (a, args) =>
            {

            };
        }

        private MaterialCard create(string idBook, string title, string auth, string status, MemoryStream picture, int x = 0, int y = 0)
        {
            MaterialCard card = new MaterialCard();
            card.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))),
                ((int)(((byte)(255)))));

            // btn_btn_Borrow_Now
            // 
            Guna2Button btn_Borrow_Now = new Guna2Button();
            btn_Borrow_Now.Animated = true;
            btn_Borrow_Now.BackColor = Color.Transparent;
            btn_Borrow_Now.BorderRadius = 10;
            btn_Borrow_Now.FillColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))),
                ((int)(((byte)(101)))));
            btn_Borrow_Now.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_Borrow_Now.ForeColor = Color.White;
            btn_Borrow_Now.HoverState.FillColor = Color.FromArgb(((int)(((byte)(110)))),
                ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            btn_Borrow_Now.Location = new Point(247, 139);
            btn_Borrow_Now.Size = new Size(78, 32);
            btn_Borrow_Now.Text = "Edit book";
            btn_Borrow_Now.Click += (sender, e) =>
            {
                Globals.setIDBook(((sender as Guna2Button).Parent as MaterialCard).Controls[0].Text);
                UpdateRemoveBook a = new UpdateRemoveBook();
                a.ShowDialog(this);
            };
            // 
            // Guna2ImageButton3
            // 
            Guna2ImageButton Guna2ImageButton3 = new Guna2ImageButton();
            Guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            Guna2ImageButton3.HoverState.ImageSize = new Size(25, 25);
            //this.Guna2ImageButton3.Image = ((Image)(resources.GetObject("Guna2ImageButton3.Image")));
            Guna2ImageButton3.ImageOffset = new Point(0, 0);
            Guna2ImageButton3.ImageSize = new Size(25, 25);
            Guna2ImageButton3.Location = new Point(286, 9);
            Guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            Guna2ImageButton3.Size = new Size(39, 36);
            // 
            // btn_add
            // 
            Guna2Button btn_add = new Guna2Button();
            btn_add.Animated = true;
            btn_add.BackColor = Color.Transparent;
            btn_add.BorderColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))),
                ((int)(((byte)(101)))));
            btn_add.BorderRadius = 10;
            btn_add.BorderThickness = 1;
            btn_add.FillColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_add.ForeColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))),
                ((int)(((byte)(101)))));
            btn_add.HoverState.FillColor = Color.FromArgb(((int)(((byte)(110)))),
                ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            btn_add.HoverState.ForeColor = Color.Black;
            btn_add.Location = new Point(145, 139);
            btn_add.Size = new Size(87, 32);

            btn_add.Text = "Borrow Now";
            btn_add.Click += (sender, e) =>
            {
                Globals.setIDBook(((sender as Guna2Button).Parent as MaterialCard).Controls[0].Text);

                BorrowInfo a = new BorrowInfo();
                a.ShowDialog(this);
                GC.Collect();
                GC.Collect();
                GC.Collect();
                fillGrid();
            };
            // 
            // lb_ratting
            // /
            Label lb_ratting = new Label();
            lb_ratting.AutoSize = true;
            lb_ratting.Font = new Font("Segoe UI", 10F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(0)));
            lb_ratting.ForeColor = SystemColors.ActiveCaptionText;
            lb_ratting.Location = new Point(210, 102);
            lb_ratting.Size = new Size(37, 19);
            lb_ratting.Text = status;
            if (status == "unactive")
            {
                lb_ratting.ForeColor = Color.Yellow;
            }
            else if (status == "deleted")
            {
                lb_ratting.ForeColor = Color.Red;
            }
            else
            {
                lb_ratting.ForeColor = Color.LawnGreen;
            }
            lb_ratting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = SystemColors.ActiveCaptionText;
            lb_name.Location = new Point(141, 49);
            lb_name.Size = new Size(155, 38);
            lb_name.Text = title;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_author
            // 
            Label lb_author = new Label();
            lb_author.AutoSize = true;
            lb_author.Font = new Font("Segoe UI", 9F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(0)));
            lb_author.ForeColor = SystemColors.ControlDark;
            lb_author.Location = new Point(141, 16);
            lb_author.Size = new Size(112, 15);
            lb_author.Text = auth;

            // label2
            //
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(142, 104);
            label2.Size = new Size(51, 15);
            label2.Text = "Status: ";

            // Guna2PictureBox13
            //
            Guna2PictureBox Guna2PictureBox13 = new Guna2PictureBox();
            Guna2PictureBox13.BackColor = Color.Transparent;
            Guna2PictureBox13.BorderRadius = 30;
            Guna2PictureBox13.Location = new Point(10, 9);
            Guna2PictureBox13.Size = new Size(121, 162);
            Guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Guna2PictureBox13.TabStop = false;
            Guna2PictureBox13.Image = Image.FromStream(picture);

            card.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))),
                ((int)(((byte)(255)))));

            Label lb_id = new Label()
            {
                Text = idBook,
                Visible = false,
            };



            card.Depth = 0;
            card.ForeColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))),
                ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            card.Location = new Point(x, y);
            card.Margin = new System.Windows.Forms.Padding(14);
            card.MouseState = MaterialSkin.MouseState.HOVER;
            card.Padding = new System.Windows.Forms.Padding(14);
            card.Size = new Size(width, height);


            card.Controls.Add(lb_id);

            card.Controls.Add(lb_ratting);
            card.Controls.Add(label2);
            card.Controls.Add(Guna2ImageButton3);
            card.Controls.Add(lb_name);
            card.Controls.Add(lb_author);
            card.Controls.Add(Guna2PictureBox13);
            if ((Globals.role.Equals("admin") || Globals.role.Equals("staff")) && (lb_ratting.Text == "active"))
            {
                card.Controls.Add(btn_Borrow_Now);
                card.Controls.Add(btn_add);

            }
            card.Click += (sender, args) =>
            {
                Globals.setIDBook((sender as MaterialCard).Controls[0].Text);
                bookInfo a = new bookInfo();
                a.ShowDialog(this);
                GC.Collect();
                GC.Collect();
                GC.Collect();
                fillGrid();
            };
            return card;
        }

        private void btn_borrow_click(object sender, PaintEventArgs e)
        {
        }

        private void btn_edit_click(object sender, PaintEventArgs e)
        {
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            Addbook a = new Addbook();
            a.ShowDialog(this);
            Globals.setIDBook("");
            fillGrid();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }

        private void tb_book_TextChanged(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            fillGrid();
        }

       void fillGrid()
        {
            Panel1.Controls.Clear();
            int x = 14;
            int y = 14;
            int c = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * from popular_N_news_books(@search, @choose, @Book_Category)", db.getConnection);
                command.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = tb_book.Text.Trim();
                command.Parameters.Add("@choose", SqlDbType.Int, 100).Value = option;
                command.Parameters.Add("@Book_Category", SqlDbType.NVarChar, 100).Value = cat;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                int n = dt.Rows.Count;
                string s;
                
                for (int i = 0; i < n; i++)
                {
                    byte[] pic;
                    pic = dt.Rows[i]["picture"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "book.jpg")) : (byte[])dt.Rows[i]["picture"]  ;
                    MemoryStream picture = new MemoryStream(pic);
                    s = "";
                    s += (dt.Rows[i]["Book_Name"].ToString().Length > 20 ? (dt.Rows[i]["Book_Name"].ToString().Remove(20, dt.Rows[i]["Book_Name"].ToString().Length - 20) + "...") : dt.Rows[i]["Book_Name"].ToString()) + "\r\n" + dt.Rows[i]["Book_Category"].ToString();
                    if (c == 2)
                    {
                        c = 0;
                        y += height + 14;
                        Panel1.Controls.Add(create(dt.Rows[i]["Book_ID"].ToString(), s, dt.Rows[i]["Author_Name"].ToString(),
                            dt.Rows[i]["Current_Status"].ToString(), picture, x, y));
                    }
                    else if (c == 0)
                    {
                        Panel1.Controls.Add(create(dt.Rows[i]["Book_ID"].ToString(), s, dt.Rows[i]["Author_Name"].ToString(),
                            dt.Rows[i]["Current_Status"].ToString(), picture, x, y));
                    }
                    else
                    {
                        Panel1.Controls.Add(create(dt.Rows[i]["Book_ID"].ToString(), s, dt.Rows[i]["Author_Name"].ToString(),
                            dt.Rows[i]["Current_Status"].ToString(), picture, x + width + 14, y));
                    }
                    c++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            Panel1.Controls.Add(new Panel()
            {
                Height = 14,
                Location = new Point(x, y + 40 + height),
            });
        }

        private void Guna2Button11_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            option = 0;
            fillGrid();
        }

        private void Guna2Button12_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            option = 1;
            fillGrid();
        }

        private void cb_cat_SelectedValueChanged(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            cat = cb_cat.SelectedItem.ToString();
            fillGrid();
        }
    }
}