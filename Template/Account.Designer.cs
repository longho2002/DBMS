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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_KH = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_NV = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(29, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 607);
            this.panel1.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Animated = true;
            this.tb_search.BorderRadius = 20;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.Parent = this.tb_search;
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.FocusedState.Parent = this.tb_search;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.HoverState.Parent = this.tb_search;
            this.tb_search.Location = new System.Drawing.Point(29, 12);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search Users";
            this.tb_search.SelectedText = "";
            this.tb_search.ShadowDecoration.Parent = this.tb_search;
            this.tb_search.Size = new System.Drawing.Size(295, 49);
            this.tb_search.TabIndex = 117;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(824, 16);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(167, 38);
            this.gunaAdvenceButton1.TabIndex = 118;
            this.gunaAdvenceButton1.Text = "Thêm khách hàng";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btn_KH
            // 
            this.btn_KH.AnimationHoverSpeed = 0.07F;
            this.btn_KH.AnimationSpeed = 0.03F;
            this.btn_KH.BackColor = System.Drawing.Color.Transparent;
            this.btn_KH.BaseColor = System.Drawing.Color.Violet;
            this.btn_KH.BorderColor = System.Drawing.Color.Black;
            this.btn_KH.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_KH.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_KH.CheckedForeColor = System.Drawing.Color.White;
            this.btn_KH.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_KH.CheckedImage")));
            this.btn_KH.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_KH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_KH.FocusedColor = System.Drawing.Color.Empty;
            this.btn_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_KH.ForeColor = System.Drawing.Color.White;
            this.btn_KH.Image = ((System.Drawing.Image)(resources.GetObject("btn_KH.Image")));
            this.btn_KH.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_KH.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_KH.Location = new System.Drawing.Point(353, 23);
            this.btn_KH.Name = "btn_KH";
            this.btn_KH.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray;
            this.btn_KH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_KH.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_KH.OnHoverImage = null;
            this.btn_KH.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_KH.OnPressedColor = System.Drawing.Color.Black;
            this.btn_KH.Radius = 10;
            this.btn_KH.Size = new System.Drawing.Size(124, 38);
            this.btn_KH.TabIndex = 119;
            this.btn_KH.Text = "Khách hàng";
            this.btn_KH.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // btn_NV
            // 
            this.btn_NV.AnimationHoverSpeed = 0.07F;
            this.btn_NV.AnimationSpeed = 0.03F;
            this.btn_NV.BackColor = System.Drawing.Color.Transparent;
            this.btn_NV.BaseColor = System.Drawing.Color.Violet;
            this.btn_NV.BorderColor = System.Drawing.Color.Black;
            this.btn_NV.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_NV.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_NV.CheckedForeColor = System.Drawing.Color.White;
            this.btn_NV.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_NV.CheckedImage")));
            this.btn_NV.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_NV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_NV.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_NV.ForeColor = System.Drawing.Color.White;
            this.btn_NV.Image = ((System.Drawing.Image)(resources.GetObject("btn_NV.Image")));
            this.btn_NV.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NV.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_NV.Location = new System.Drawing.Point(493, 23);
            this.btn_NV.Name = "btn_NV";
            this.btn_NV.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray;
            this.btn_NV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NV.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NV.OnHoverImage = null;
            this.btn_NV.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_NV.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NV.Radius = 10;
            this.btn_NV.Size = new System.Drawing.Size(125, 38);
            this.btn_NV.TabIndex = 120;
            this.btn_NV.Text = "Nhân viên";
            this.btn_NV.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 696);
            this.Controls.Add(this.btn_NV);
            this.Controls.Add(this.btn_KH);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_KH;
        private Guna.UI.WinForms.GunaAdvenceButton btn_NV;
    }
}