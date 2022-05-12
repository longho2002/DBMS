using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Template
{
    public partial class Account : Form
    {
        private MY_DB db = new MY_DB();
        public Account()
        {
            InitializeComponent();
            panel1.BackColor = Color.DimGray;

            // pan_Acc.Location = new Point(21, 18);
            // pan_Acc.Size = new Size(170, 170);
            SqlCommand cmd = new SqlCommand("Select", db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            int x = 20, y = 20;
            for (int i = 1; i <= 20; i++)
            {
                panel1.Controls.Add(renderAcc(x + (i % 5) * (16 + 170), y, "1231", "Long", "Master"));
                if (i % 5 == 0)
                {
                    x = 20;
                    y += 20 + 170;
                }
            }
        }

        public Guna2GradientPanel renderAcc(int x, int y, string idUser, string name, string rank)
        {
            // 
            // lb_rank
            // 
            Label lb_rank = new Label();
            lb_rank.AutoSize = true;
            lb_rank.BackColor = Color.Transparent;
            lb_rank.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            lb_rank.ForeColor = Color.Black;
            lb_rank.Location = new Point(10, 100);
            lb_rank.Size = new Size(170, 23);
            lb_rank.Text = rank;
            lb_rank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lb_rank.AutoSize = false;
            lb_rank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Name
            // 
            Label lb_Name = new Label();
            lb_Name.AutoSize = true;
            lb_Name.BackColor = Color.Transparent;
            lb_Name.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb_Name.ForeColor = Color.DodgerBlue;
            lb_Name.Location = new Point(55, 105);
            lb_Name.Size = new Size(68, 24);
            lb_Name.Text = name;

            // 
            // rjCircularPictureBox2
            // 
            RJCircularPictureBox pictureBox = new RJCircularPictureBox();
            pictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictureBox.BorderColor = Color.RoyalBlue;
            pictureBox.BorderColor2 = Color.HotPink;
            pictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureBox.BorderSize = 2;
            pictureBox.GradientAngle = 50F;
            pictureBox.Location = new Point(40, 17);
            pictureBox.Name = "rjCircularPictureBox2";
            pictureBox.Size = new Size(84, 84);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabStop = false;

            // 
            // pan_Acc
            // 
            Label id = new Label()
            {
                Text = idUser,
                Visible = false,
            };
            Guna2GradientPanel pan_Acc = new Guna2GradientPanel();
            pan_Acc.BorderRadius = 20;
            pan_Acc.Controls.Add(id);
            pan_Acc.Controls.Add(lb_rank);
            pan_Acc.Controls.Add(lb_Name);
            pan_Acc.Controls.Add(pictureBox);
            pan_Acc.FillColor = Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            pan_Acc.FillColor2 = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            pan_Acc.Location = new Point(x, y);
            pan_Acc.Size = new Size(170, 170);
            pan_Acc.Click += Click_show;
            //pan_Acc.MouseHover += (sender, args) =>
            //{
            //    (sender as Guna2GradientPanel).Size = new System.Drawing.Size(180, 180); // Desired hovered size
            //};
            //pan_Acc.MouseLeave += (sender, args) =>
            //{
            //    (sender as Guna2GradientPanel).Size = new Size(170, 170); // Back to original size
            //};
            return pan_Acc ;
        }

        private void Click_show(object sender, System.EventArgs e)
        {
            UserInfo a = new UserInfo();
            a.FormBorderStyle = FormBorderStyle.Fixed3D;
            Globals.setIDUsertmp((sender as Guna2GradientPanel).Controls[0].Text);
            a.ShowDialog();
        }

        private void pan_Acc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pan_Acc_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            a.ShowDialog(this);
        }
    }
}