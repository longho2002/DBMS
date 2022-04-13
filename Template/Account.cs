using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Template
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            panel1.BackColor = Color.DimGray;
            for (int i = 0; i < 10; i++)
            {
                panel1.Controls.Add(renderAcc(20, 20 + 75 * i + 20 * i));
            }
        }

        public Guna2CustomGradientPanel renderAcc(int x, int y)
        {
            Guna2CustomGradientPanel pan_Acc = new Guna2CustomGradientPanel();
            // 
            // lb_rank
            // 
            Label lb_rank = new Label();
            lb_rank.AutoSize = true;
            lb_rank.BackColor = System.Drawing.Color.Transparent;
            lb_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_rank.ForeColor = System.Drawing.Color.Black;
            lb_rank.Location = new System.Drawing.Point(524, 28);
            lb_rank.Name = "lb_rank";
            lb_rank.Size = new System.Drawing.Size(126, 24);
            lb_rank.Text = "Gold member";
            // 
            // lb_Name
            // 
            Label lb_Name = new Label();
            lb_Name.AutoSize = true;
            lb_Name.BackColor = System.Drawing.Color.Transparent;
            lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Name.ForeColor = System.Drawing.Color.OrangeRed;
            lb_Name.Location = new System.Drawing.Point(90, 28);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(68, 24);
            lb_Name.TabIndex = 2;
            lb_Name.Text = "Cozark";
            //
            // rjCircularPictureBox2
            // 
            RJCircularPictureBox rjCircularPictureBox2 = new RJCircularPictureBox();
            rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox2.BorderSize = 2;
            rjCircularPictureBox2.GradientAngle = 50F;
            rjCircularPictureBox2.Image = global::Template.Properties.Resources._1081856_200;
            rjCircularPictureBox2.Location = new System.Drawing.Point(0, 0);
            rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            rjCircularPictureBox2.Size = new System.Drawing.Size(72, 72);
            rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox2.TabIndex = 1;
            rjCircularPictureBox2.TabStop = false;
            //
            // pan_Acc
            // 
            pan_Acc.Controls.Add(lb_rank);
            pan_Acc.Controls.Add(lb_Name);
            pan_Acc.Controls.Add(rjCircularPictureBox2);
            pan_Acc.FillColor = System.Drawing.Color.FromArgb(43, 88, 118);
            pan_Acc.FillColor2 = System.Drawing.Color.FromArgb(78, 67, 118);
            pan_Acc.Location = new System.Drawing.Point(x, y);
            pan_Acc.Name = "pan_Acc";
            pan_Acc.Size = new System.Drawing.Size(660, 75);
            pan_Acc.TabIndex = 0;

            return pan_Acc;
        }
    }
}