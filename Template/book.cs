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
                    Panel1.Controls.Add(create(x , y));
                }
                else if (c == 0)
                {
                    Panel1.Controls.Add(create(x , y));
                }
                else
                {
                    Panel1.Controls.Add(create(x + width + 14, y));
                }
                c++;
            }
        }

        private MaterialCard create(int x = 0, int y = 0)
        {
            MaterialCard card = new MaterialCard();
            card.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));

            // btn_btn_Borrow_Now
            // 
            Guna2Button btn_Borrow_Now = new Guna2Button();
            btn_Borrow_Now.Animated = true;
            btn_Borrow_Now.BackColor = System.Drawing.Color.Transparent;
            btn_Borrow_Now.BorderRadius = 10;
            btn_Borrow_Now.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_Borrow_Now.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            btn_Borrow_Now.ForeColor = System.Drawing.Color.White;
            btn_Borrow_Now.HoverState.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (110)))),
                ((int) (((byte) (109)))), ((int) (((byte) (228)))));
            btn_Borrow_Now.Location = new System.Drawing.Point(247, 139);
            btn_Borrow_Now.Name = "btn_btn_Borrow_Now";
            btn_Borrow_Now.Size = new System.Drawing.Size(78, 32);
            btn_Borrow_Now.TabIndex = 52;
            btn_Borrow_Now.Text = "Buy Now";
            // 
            // Guna2ImageButton3
            // 
            Guna2ImageButton Guna2ImageButton3 = new Guna2ImageButton();
            Guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            Guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            //this.Guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("Guna2ImageButton3.Image")));
            Guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            Guna2ImageButton3.ImageRotate = 0F;
            Guna2ImageButton3.ImageSize = new System.Drawing.Size(25, 25);
            Guna2ImageButton3.Location = new System.Drawing.Point(286, 9);
            Guna2ImageButton3.Name = "Guna2ImageButton3";
            Guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            Guna2ImageButton3.Size = new System.Drawing.Size(39, 36);
            // 
            // btn_add
            // 
            Guna2Button btn_add = new Guna2Button();
            btn_add.Animated = true;
            btn_add.BackColor = System.Drawing.Color.Transparent;
            btn_add.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_add.BorderRadius = 10;
            btn_add.BorderThickness = 1;
            btn_add.FillColor = System.Drawing.Color.White;
            btn_add.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            btn_add.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))),
                ((int) (((byte) (101)))));
            btn_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (110)))),
                ((int) (((byte) (109)))), ((int) (((byte) (228)))));
            btn_add.HoverState.ForeColor = System.Drawing.Color.Black;
            btn_add.Location = new System.Drawing.Point(145, 139);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(87, 32);
            btn_add.Text = "Add To Cart";
            // 
            // lb_ratting
            // //
            Label lb_ratting = new Label();
            lb_ratting.AutoSize = true;
            lb_ratting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            lb_ratting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_ratting.Location = new System.Drawing.Point(193, 102);
            lb_ratting.Name = "lb_ratting";
            lb_ratting.Size = new System.Drawing.Size(37, 19);
            lb_ratting.Text = "4.00";
            lb_ratting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            lb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_name.Location = new System.Drawing.Point(141, 49);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(155, 38);
            lb_name.Text = "Belajar Dengan Jenius\r\nSOS - NODE.JS";
            lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_author
            // 
            Label lb_author = new Label();
            lb_author.AutoSize = true;
            lb_author.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            lb_author.ForeColor = System.Drawing.SystemColors.ControlDark;
            lb_author.Location = new System.Drawing.Point(141, 16);
            lb_author.Name = "lb_author";
            lb_author.Size = new System.Drawing.Size(112, 15);
            lb_author.Text = "Gun Gun Febrianza";

            // label2
            //
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            label2.Location = new System.Drawing.Point(142, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.Text = "Ratting:";

            // Guna2PictureBox13
            //
            Guna2PictureBox Guna2PictureBox13 = new Guna2PictureBox();
            Guna2PictureBox13.BackColor = System.Drawing.Color.Transparent;
            Guna2PictureBox13.BorderRadius = 30;
            Guna2PictureBox13.ImageRotate = 0F;
            Guna2PictureBox13.Location = new System.Drawing.Point(10, 9);
            Guna2PictureBox13.Name = "Guna2PictureBox13";
            Guna2PictureBox13.Size = new System.Drawing.Size(121, 162);
            Guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Guna2PictureBox13.TabStop = false;
            Guna2PictureBox13.Image = new Bitmap(@"C:\Users\Thai Long\Downloads\icon-password-3.jpg");

            card.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            card.Controls.Add(label2);
            card.Controls.Add(btn_Borrow_Now);
            card.Controls.Add(Guna2ImageButton3);
            card.Controls.Add(btn_add);
            card.Controls.Add(lb_ratting);
            card.Controls.Add(lb_name);
            card.Controls.Add(lb_author);
            card.Controls.Add(Guna2PictureBox13);
            card.Depth = 0;
            card.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            card.Location = new System.Drawing.Point(x, y);
            card.Margin = new System.Windows.Forms.Padding(14);
            card.MouseState = MaterialSkin.MouseState.HOVER;
            card.Name = "card";
            card.Padding = new System.Windows.Forms.Padding(14);
            card.Size = new System.Drawing.Size(width, height);
            card.ResumeLayout(false);
            card.PerformLayout();
            card.SuspendLayout();
            return card;
        }
    }
}