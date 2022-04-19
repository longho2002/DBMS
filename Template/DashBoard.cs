using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Template
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            createQuaHan();
        }

        private void btn_Borrow_Now_Click(object sender, EventArgs e)
        {

        }


       

        private void createQuaHan()
        {
            //pan_quahan.Location = new System.Drawing.Point(10, 175);
            //pan_quahan.Name = "pan_quahan";
            //pan_quahan.Size = new System.Drawing.Size(781, 100);
            for (int i = 0; i < 10; i++)
            {
                panMain.Controls.Add(QuaHan(45, 30 + 100 * i + 20 * i));
            }
            panMain.Controls.Add(new Panel()
            {
                Width = 0,
                Height = 20,
                Location = new Point(45, 30 + 100 * 10 + 20 * 10),
            });
        }
        private Panel QuaHan(int x, int y)
        {
            Panel pan_quahan = new Panel();
            // 
            // label8
            // 
            Label lb_quahan = new Label();
            lb_quahan.AutoSize = true;
            lb_quahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_quahan.Location = new System.Drawing.Point(526, 53);
            lb_quahan.Size = new System.Drawing.Size(70, 20);
            lb_quahan.TabIndex = 60;
            lb_quahan.Text = "Quá hạn";
            // 
            // label7
            // 
            Label lb_ngaymuon = new Label();
            lb_ngaymuon.AutoSize = true;
            lb_ngaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_ngaymuon.Location = new System.Drawing.Point(526, 24);
            lb_ngaymuon.Size = new System.Drawing.Size(89, 20);
            lb_ngaymuon.TabIndex = 59;
            lb_ngaymuon.Text = "Ngày mượn";
            // 
            // label6
            // 
            Label lb_datequahan = new Label();
            lb_datequahan.AutoSize = true;
            lb_datequahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_datequahan.ForeColor = System.Drawing.Color.Red;
            lb_datequahan.Location = new System.Drawing.Point(631, 53);
            lb_datequahan.Size = new System.Drawing.Size(65, 20);
            lb_datequahan.TabIndex = 58;
            lb_datequahan.Text = "14 ngày";
            // 
            // label2
            // 
            Label lb_book = new Label();
            lb_book.AutoSize = true;
            lb_book.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_book.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_book.Location = new System.Drawing.Point(110, 52);
            lb_book.Size = new System.Drawing.Size(121, 19);
            lb_book.TabIndex = 57;
            lb_book.Text = "Book: Đoán xem";
            lb_book.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 

            Label date_muon = new Label();
            date_muon.AutoSize = true;
            date_muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_muon.Location = new System.Drawing.Point(631, 24);
            date_muon.Size = new System.Drawing.Size(80, 20);
            date_muon.TabIndex = 55;
            date_muon.Text = "20/2/2002";
            // 
            // label5
            // 
            Label lb_name = new Label();
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_name.Location = new System.Drawing.Point(110, 24);
            lb_name.Size = new System.Drawing.Size(190, 19);
            lb_name.TabIndex = 43;
            lb_name.Text = "Name: Vy không yêu Trung";
            lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            Guna2PictureBox pic = new Guna2PictureBox();
            pic.BackColor = System.Drawing.Color.Transparent;
            pic.BorderRadius = 30;
            pic.ImageRotate = 0F;
            pic.Location = new System.Drawing.Point(6, 6);
            pic.Name = "guna2PictureBox2";
            pic.Size = new System.Drawing.Size(85, 89);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 44;
            pic.TabStop = false;
            //
            // pan_quahan
            // 
            pan_quahan.Controls.Add(lb_quahan);
            pan_quahan.Controls.Add(lb_ngaymuon);
            pan_quahan.Controls.Add(lb_datequahan);
            pan_quahan.Controls.Add(lb_book);
            pan_quahan.Controls.Add(date_muon);
            pan_quahan.Controls.Add(lb_name);
            pan_quahan.Controls.Add(pic);
            pan_quahan.Location = new System.Drawing.Point(x, y);
            pan_quahan.Name = "pan_quahan";
            pan_quahan.Size = new System.Drawing.Size(794, 100);
            pan_quahan.TabIndex = 130;
            pan_quahan.Margin = new Padding(0, 0, 0, 100);
            return pan_quahan;
        }
    }
}
