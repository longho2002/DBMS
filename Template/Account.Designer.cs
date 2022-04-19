using System.ComponentModel;

namespace Template
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_Acc = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lb_rank = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.rjCircularPictureBox1 = new Template.RJCircularPictureBox();
            this.rjCircularPictureBox2 = new Template.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            this.pan_Acc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pan_Acc);
            this.panel1.Location = new System.Drawing.Point(16, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 651);
            this.panel1.TabIndex = 0;
            // 
            // pan_Acc
            // 
            this.pan_Acc.Controls.Add(this.lb_rank);
            this.pan_Acc.Controls.Add(this.lb_Name);
            this.pan_Acc.Controls.Add(this.rjCircularPictureBox2);
            this.pan_Acc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.pan_Acc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.pan_Acc.Location = new System.Drawing.Point(23, 20);
            this.pan_Acc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan_Acc.Name = "pan_Acc";
            this.pan_Acc.Size = new System.Drawing.Size(905, 92);
            this.pan_Acc.TabIndex = 0;
            this.pan_Acc.Visible = false;
            this.pan_Acc.Click += new System.EventHandler(this.pan_Acc_Click);
            this.pan_Acc.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Acc_Paint);
            // 
            // lb_rank
            // 
            this.lb_rank.AutoSize = true;
            this.lb_rank.BackColor = System.Drawing.Color.Transparent;
            this.lb_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rank.ForeColor = System.Drawing.Color.Black;
            this.lb_rank.Location = new System.Drawing.Point(699, 34);
            this.lb_rank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rank.Name = "lb_rank";
            this.lb_rank.Size = new System.Drawing.Size(161, 29);
            this.lb_rank.TabIndex = 3;
            this.lb_rank.Text = "Gold member";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_Name.Location = new System.Drawing.Point(120, 34);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(88, 29);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Cozark";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rjCircularPictureBox1);
            this.panel2.Location = new System.Drawing.Point(980, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 651);
            this.panel2.TabIndex = 1;
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Animated = true;
            this.Guna2TextBox1.BorderRadius = 20;
            this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox1.DefaultText = "";
            this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.Location = new System.Drawing.Point(16, 15);
            this.Guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderText = "Search Books";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.Size = new System.Drawing.Size(393, 38);
            this.Guna2TextBox1.TabIndex = 117;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(47, 20);
            this.rjCircularPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(191, 191);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 2;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Image = global::Template.Properties.Resources._1081856_200;
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.rjCircularPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(96, 96);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox2.TabIndex = 1;
            this.rjCircularPictureBox2.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 748);
            this.Controls.Add(this.Guna2TextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            this.pan_Acc.ResumeLayout(false);
            this.pan_Acc.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel pan_Acc;
        private System.Windows.Forms.Label lb_Name;
        private RJCircularPictureBox rjCircularPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private RJCircularPictureBox rjCircularPictureBox1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        private System.Windows.Forms.Label lb_rank;
    }
}