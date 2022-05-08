using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;

namespace Template
{
    public partial class book : Form
    {
        private int width = 335;
        private int height = 180;

        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            int x = 14;
            int y = 14;
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                if (c == 2)
                {
                    c = 0;
                    y += height + 14;
                    Panel1.Controls.Add(create("12", "Belajar Dengan Jenius\r\nSOS - NODE.JS", "4.00",
                        "Gun Gun Febrianza", x, y));
                }
                else if (c == 0)
                {
                    Panel1.Controls.Add(create("12", "Belajar Dengan Jenius\r\nSOS - NODE.JS", "4.00",
                        "Gun Gun Febrianza", x, y));
                }
                else
                {
                    Panel1.Controls.Add(create("12", "Belajar Dengan Jenius\r\nSOS - NODE.JS", "4.00",
                        "Gun Gun Febrianza", x + width + 14, y));
                }

                c++;
            }

            Panel1.Controls.Add(new Panel()
            {
                Height = 14,
                Location = new Point(x, y + 40 + height),
            });
            if (Globals.role.Equals("customer"))
                btn_addbook.Visible = false;
        }

        private MaterialCard create(string idBook, string title, string ratting, string auth, int x = 0, int y = 0)
        {
            MaterialCard card = new MaterialCard();
            card.BackColor = Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));

            // btn_btn_Borrow_Now
            // 
            Guna2Button btn_Borrow_Now = new Guna2Button();
            btn_Borrow_Now.Animated = true;
            btn_Borrow_Now.BackColor = Color.Transparent;
            btn_Borrow_Now.BorderRadius = 10;
            btn_Borrow_Now.FillColor = Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_Borrow_Now.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_Borrow_Now.ForeColor = Color.White;
            btn_Borrow_Now.HoverState.FillColor = Color.FromArgb(((int) (((byte) (110)))),
                ((int) (((byte) (109)))), ((int) (((byte) (228)))));
            btn_Borrow_Now.Location = new Point(247, 139);
            btn_Borrow_Now.Size = new Size(78, 32);
            btn_Borrow_Now.Text = "Edit book";
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
            btn_add.BorderColor = Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_add.BorderRadius = 10;
            btn_add.BorderThickness = 1;
            btn_add.FillColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_add.ForeColor = Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_add.HoverState.FillColor = Color.FromArgb(((int) (((byte) (110)))),
                ((int) (((byte) (109)))), ((int) (((byte) (228)))));
            btn_add.HoverState.ForeColor = Color.Black;
            btn_add.Location = new Point(145, 139);
            btn_add.Size = new Size(87, 32);
            btn_add.Text = "Borrow Now";
            btn_add.Click += (sender, e) =>
            {
                Globals.setIDBook((sender as MaterialCard).Controls[0].Text);
                BorrowInfo a = new BorrowInfo();
                a.ShowDialog(this);
            };
            // 
            // lb_ratting
            // /
            Label lb_ratting = new Label();
            lb_ratting.AutoSize = true;
            lb_ratting.Font = new Font("Segoe UI", 10F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte) (0)));
            lb_ratting.ForeColor = SystemColors.ActiveCaptionText;
            lb_ratting.Location = new Point(210, 102);
            lb_ratting.Size = new Size(37, 19);
            lb_ratting.Text = ratting;
            lb_ratting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte) (0)));
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
                GraphicsUnit.Point, ((byte) (0)));
            lb_author.ForeColor = SystemColors.ControlDark;
            lb_author.Location = new Point(141, 16);
            lb_author.Size = new Size(112, 15);
            lb_author.Text = auth;

            // label2
            //
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold,
                GraphicsUnit.Point, ((byte) (0)));
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(142, 104);
            label2.Size = new Size(51, 15);
            label2.Text = "Ratting:";

            // Guna2PictureBox13
            //
            Guna2PictureBox Guna2PictureBox13 = new Guna2PictureBox();
            Guna2PictureBox13.BackColor = Color.Transparent;
            Guna2PictureBox13.BorderRadius = 30;
            Guna2PictureBox13.Location = new Point(10, 9);
            Guna2PictureBox13.Size = new Size(121, 162);
            Guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Guna2PictureBox13.TabStop = false;
            Guna2PictureBox13.Image = new Bitmap(@"C:\Users\Thai Long\Downloads\icon-password-3.jpg");

            card.BackColor = Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));

            Label lb_id = new Label()
            {
                Text = idBook,
                Visible = false,
            };

            card.Controls.Add(lb_id);
            card.Controls.Add(label2);
            if (Globals.role.Equals("admin") || Globals.role.Equals("staff"))
            {
                card.Controls.Add(btn_Borrow_Now);
                card.Controls.Add(btn_add);
            }


            card.Controls.Add(Guna2ImageButton3);
            card.Controls.Add(lb_ratting);
            card.Controls.Add(lb_name);
            card.Controls.Add(lb_author);
            card.Controls.Add(Guna2PictureBox13);
            card.Depth = 0;
            card.ForeColor = Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            card.Location = new Point(x, y);
            card.Margin = new System.Windows.Forms.Padding(14);
            card.MouseState = MaterialSkin.MouseState.HOVER;
            card.Padding = new System.Windows.Forms.Padding(14);
            card.Size = new Size(width, height);
            card.ResumeLayout(false);
            card.PerformLayout();
            card.SuspendLayout();
            card.Click += (sender, args) =>
            {
                UpdateRemoveBook a = new UpdateRemoveBook();
                a.Show(this);
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
            Addbook a = new Addbook();
            a.Show(this);
        }
    }
}