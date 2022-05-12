namespace Template
{
    partial class Statistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rBtn_Borrow = new System.Windows.Forms.RadioButton();
            this.rBtn_Return = new System.Windows.Forms.RadioButton();
            this.rBtn_All = new System.Windows.Forms.RadioButton();
            this.btn_month = new Guna.UI2.WinForms.Guna2Button();
            this.btn_year = new Guna.UI2.WinForms.Guna2Button();
            this.btn_week = new Guna.UI2.WinForms.Guna2Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_book3 = new System.Windows.Forms.Label();
            this.lb_book1 = new System.Windows.Forms.Label();
            this.lb_name2 = new System.Windows.Forms.Label();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.pic3 = new Template.RJCircularPictureBox();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.pic2 = new Template.RJCircularPictureBox();
            this.pic1 = new Template.RJCircularPictureBox();
            this.lb_name3 = new System.Windows.Forms.Label();
            this.lb_name1 = new System.Windows.Forms.Label();
            this.lb_book_2 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.dateTimePicker1);
            this.guna2Panel1.Controls.Add(this.rBtn_Borrow);
            this.guna2Panel1.Controls.Add(this.rBtn_Return);
            this.guna2Panel1.Controls.Add(this.rBtn_All);
            this.guna2Panel1.Controls.Add(this.btn_month);
            this.guna2Panel1.Controls.Add(this.btn_year);
            this.guna2Panel1.Controls.Add(this.btn_week);
            this.guna2Panel1.Controls.Add(this.cartesianChart1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(930, 254);
            this.guna2Panel1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // rBtn_Borrow
            // 
            this.rBtn_Borrow.Location = new System.Drawing.Point(750, 13);
            this.rBtn_Borrow.Name = "rBtn_Borrow";
            this.rBtn_Borrow.Size = new System.Drawing.Size(80, 24);
            this.rBtn_Borrow.TabIndex = 6;
            this.rBtn_Borrow.Text = "Borrow";
            this.rBtn_Borrow.UseVisualStyleBackColor = true;
            this.rBtn_Borrow.CheckedChanged += new System.EventHandler(this.rBtn_Borrow_CheckedChanged);
            // 
            // rBtn_Return
            // 
            this.rBtn_Return.Location = new System.Drawing.Point(836, 13);
            this.rBtn_Return.Name = "rBtn_Return";
            this.rBtn_Return.Size = new System.Drawing.Size(87, 24);
            this.rBtn_Return.TabIndex = 5;
            this.rBtn_Return.Text = "Return";
            this.rBtn_Return.UseVisualStyleBackColor = true;
            this.rBtn_Return.CheckedChanged += new System.EventHandler(this.rBtn_Return_CheckedChanged);
            // 
            // rBtn_All
            // 
            this.rBtn_All.Checked = true;
            this.rBtn_All.Location = new System.Drawing.Point(689, 13);
            this.rBtn_All.Name = "rBtn_All";
            this.rBtn_All.Size = new System.Drawing.Size(55, 24);
            this.rBtn_All.TabIndex = 4;
            this.rBtn_All.TabStop = true;
            this.rBtn_All.Text = "All";
            this.rBtn_All.UseVisualStyleBackColor = true;
            this.rBtn_All.CheckedChanged += new System.EventHandler(this.rBtn_All_CheckedChanged);
            // 
            // btn_month
            // 
            this.btn_month.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_month.BorderThickness = 1;
            this.btn_month.CheckedState.Parent = this.btn_month;
            this.btn_month.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_month.CustomImages.Parent = this.btn_month;
            this.btn_month.FillColor = System.Drawing.Color.Transparent;
            this.btn_month.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_month.ForeColor = System.Drawing.Color.Black;
            this.btn_month.HoverState.Parent = this.btn_month;
            this.btn_month.Location = new System.Drawing.Point(112, 9);
            this.btn_month.Name = "btn_month";
            this.btn_month.ShadowDecoration.Parent = this.btn_month;
            this.btn_month.Size = new System.Drawing.Size(101, 28);
            this.btn_month.TabIndex = 3;
            this.btn_month.Text = "month";
            this.btn_month.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btn_year
            // 
            this.btn_year.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_year.BorderThickness = 1;
            this.btn_year.CheckedState.Parent = this.btn_year;
            this.btn_year.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_year.CustomImages.Parent = this.btn_year;
            this.btn_year.FillColor = System.Drawing.Color.Transparent;
            this.btn_year.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_year.ForeColor = System.Drawing.Color.Black;
            this.btn_year.HoverState.Parent = this.btn_year;
            this.btn_year.Location = new System.Drawing.Point(206, 9);
            this.btn_year.Name = "btn_year";
            this.btn_year.ShadowDecoration.Parent = this.btn_year;
            this.btn_year.Size = new System.Drawing.Size(101, 28);
            this.btn_year.TabIndex = 2;
            this.btn_year.Text = "year";
            this.btn_year.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_week
            // 
            this.btn_week.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_week.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_week.BorderThickness = 1;
            this.btn_week.CheckedState.Parent = this.btn_week;
            this.btn_week.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_week.CustomImages.Parent = this.btn_week;
            this.btn_week.FillColor = System.Drawing.Color.Empty;
            this.btn_week.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_week.ForeColor = System.Drawing.Color.White;
            this.btn_week.HoverState.Parent = this.btn_week;
            this.btn_week.Location = new System.Drawing.Point(11, 9);
            this.btn_week.Name = "btn_week";
            this.btn_week.ShadowDecoration.Parent = this.btn_week;
            this.btn_week.Size = new System.Drawing.Size(101, 28);
            this.btn_week.TabIndex = 1;
            this.btn_week.Text = "week";
            this.btn_week.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(14, 43);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(902, 205);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.pieChart1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 288);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(471, 269);
            this.guna2Panel2.TabIndex = 9;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(28, 24);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(417, 221);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lb_book3);
            this.guna2Panel3.Controls.Add(this.lb_book1);
            this.guna2Panel3.Controls.Add(this.lb_name2);
            this.guna2Panel3.Controls.Add(this.guna2Button7);
            this.guna2Panel3.Controls.Add(this.guna2Button8);
            this.guna2Panel3.Controls.Add(this.pic3);
            this.guna2Panel3.Controls.Add(this.guna2Button9);
            this.guna2Panel3.Controls.Add(this.pic2);
            this.guna2Panel3.Controls.Add(this.pic1);
            this.guna2Panel3.Controls.Add(this.lb_name3);
            this.guna2Panel3.Controls.Add(this.lb_name1);
            this.guna2Panel3.Controls.Add(this.lb_book_2);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.Location = new System.Drawing.Point(488, 288);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(471, 269);
            this.guna2Panel3.TabIndex = 10;
            // 
            // lb_book3
            // 
            this.lb_book3.AutoSize = true;
            this.lb_book3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book3.Location = new System.Drawing.Point(360, 246);
            this.lb_book3.Name = "lb_book3";
            this.lb_book3.Size = new System.Drawing.Size(0, 16);
            this.lb_book3.TabIndex = 22;
            // 
            // lb_book1
            // 
            this.lb_book1.AutoSize = true;
            this.lb_book1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book1.Location = new System.Drawing.Point(210, 204);
            this.lb_book1.Name = "lb_book1";
            this.lb_book1.Size = new System.Drawing.Size(0, 16);
            this.lb_book1.TabIndex = 21;
            // 
            // lb_name2
            // 
            this.lb_name2.AutoSize = true;
            this.lb_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name2.Location = new System.Drawing.Point(63, 198);
            this.lb_name2.Name = "lb_name2";
            this.lb_name2.Size = new System.Drawing.Size(0, 24);
            this.lb_name2.TabIndex = 20;
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.BorderThickness = 1;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(349, 46);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(88, 28);
            this.guna2Button7.TabIndex = 18;
            this.guna2Button7.Text = "This month";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.BorderThickness = 1;
            this.guna2Button8.CheckedState.Parent = this.guna2Button8;
            this.guna2Button8.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.CustomImages.Parent = this.guna2Button8;
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.Black;
            this.guna2Button8.HoverState.Parent = this.guna2Button8;
            this.guna2Button8.Location = new System.Drawing.Point(349, 78);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.Parent = this.guna2Button8;
            this.guna2Button8.Size = new System.Drawing.Size(88, 28);
            this.guna2Button8.TabIndex = 16;
            this.guna2Button8.Text = "This year";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // pic3
            // 
            this.pic3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic3.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic3.BorderSize = 2;
            this.pic3.GradientAngle = 50F;
            this.pic3.Location = new System.Drawing.Point(341, 135);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(80, 80);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 19;
            this.pic3.TabStop = false;
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button9.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.BorderThickness = 1;
            this.guna2Button9.CheckedState.Parent = this.guna2Button9;
            this.guna2Button9.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.CustomImages.Parent = this.guna2Button9;
            this.guna2Button9.FillColor = System.Drawing.Color.Empty;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.Parent = this.guna2Button9;
            this.guna2Button9.Location = new System.Drawing.Point(349, 12);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.Parent = this.guna2Button9;
            this.guna2Button9.Size = new System.Drawing.Size(88, 28);
            this.guna2Button9.TabIndex = 15;
            this.guna2Button9.Text = "This week";
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // pic2
            // 
            this.pic2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic2.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic2.BorderSize = 2;
            this.pic2.GradientAngle = 50F;
            this.pic2.Location = new System.Drawing.Point(35, 91);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(105, 105);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 17;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic1.BorderSize = 2;
            this.pic1.GradientAngle = 50F;
            this.pic1.Location = new System.Drawing.Point(165, 47);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(129, 129);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 14;
            this.pic1.TabStop = false;
            // 
            // lb_name3
            // 
            this.lb_name3.AutoSize = true;
            this.lb_name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name3.Location = new System.Drawing.Point(356, 221);
            this.lb_name3.Name = "lb_name3";
            this.lb_name3.Size = new System.Drawing.Size(0, 24);
            this.lb_name3.TabIndex = 13;
            // 
            // lb_name1
            // 
            this.lb_name1.AutoSize = true;
            this.lb_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name1.Location = new System.Drawing.Point(206, 179);
            this.lb_name1.Name = "lb_name1";
            this.lb_name1.Size = new System.Drawing.Size(0, 24);
            this.lb_name1.TabIndex = 12;
            // 
            // lb_book_2
            // 
            this.lb_book_2.AutoSize = true;
            this.lb_book_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book_2.Location = new System.Drawing.Point(67, 223);
            this.lb_book_2.Name = "lb_book_2";
            this.lb_book_2.Size = new System.Drawing.Size(0, 16);
            this.lb_book_2.TabIndex = 11;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(140, 7);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(203, 33);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Top 3 Account";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 569);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistic";
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        private LiveCharts.WinForms.PieChart pieChart1;

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Template.RJCircularPictureBox pic3;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Template.RJCircularPictureBox pic2;
        private Template.RJCircularPictureBox pic1;
        private System.Windows.Forms.Label lb_name3;
        private System.Windows.Forms.Label lb_name1;
        private System.Windows.Forms.Label lb_book_2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;

        private LiveCharts.WinForms.GeoMap geoMap1;

        private System.Windows.Forms.RadioButton rBtn_All;
        private System.Windows.Forms.RadioButton rBtn_Return;
        private System.Windows.Forms.RadioButton rBtn_Borrow;

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_month;
        private Guna.UI2.WinForms.Guna2Button btn_year;
        private Guna.UI2.WinForms.Guna2Button btn_week;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lb_book3;
        private System.Windows.Forms.Label lb_book1;
        private System.Windows.Forms.Label lb_name2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}