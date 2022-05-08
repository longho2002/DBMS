using System.ComponentModel;

namespace Template
{
    partial class BookName
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (100)))), ((int) (((byte) (88)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (69)))), ((int) (((byte) (94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (229)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (69)))), ((int) (((byte) (94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (229)))), ((int) (((byte) (255)))));
            this.DataGridView1.Location = new System.Drawing.Point(12, 58);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(400, 509);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (229)))), ((int) (((byte) (255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (100)))), ((int) (((byte) (88)))), ((int) (((byte) (255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (69)))), ((int) (((byte) (94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (231)))), ((int) (((byte) (229)))), ((int) (((byte) (255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (71)))), ((int) (((byte) (69)))), ((int) (((byte) (94)))));
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellDoubleClick);
            // 
            // btn_Search
            // 
            this.btn_Search.Animated = true;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))), ((int) (((byte) (101)))));
            this.btn_Search.BorderRadius = 10;
            this.btn_Search.BorderThickness = 1;
            this.btn_Search.CheckedState.Parent = this.btn_Search;
            this.btn_Search.CustomImages.Parent = this.btn_Search;
            this.btn_Search.FillColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (245)))), ((int) (((byte) (79)))), ((int) (((byte) (101)))));
            this.btn_Search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (110)))), ((int) (((byte) (109)))), ((int) (((byte) (228)))));
            this.btn_Search.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.HoverState.Parent = this.btn_Search;
            this.btn_Search.Location = new System.Drawing.Point(314, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Parent = this.btn_Search;
            this.btn_Search.Size = new System.Drawing.Size(87, 41);
            this.btn_Search.TabIndex = 117;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Animated = true;
            this.tb_Search.BorderRadius = 20;
            this.tb_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Search.DefaultText = "";
            this.tb_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (208)))), ((int) (((byte) (208)))), ((int) (((byte) (208)))));
            this.tb_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (226)))), ((int) (((byte) (226)))), ((int) (((byte) (226)))));
            this.tb_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (138)))), ((int) (((byte) (138)))), ((int) (((byte) (138)))));
            this.tb_Search.DisabledState.Parent = this.tb_Search;
            this.tb_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (138)))), ((int) (((byte) (138)))), ((int) (((byte) (138)))));
            this.tb_Search.FillColor = System.Drawing.Color.FromArgb(((int) (((byte) (246)))), ((int) (((byte) (245)))), ((int) (((byte) (251)))));
            this.tb_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (94)))), ((int) (((byte) (148)))), ((int) (((byte) (255)))));
            this.tb_Search.FocusedState.Parent = this.tb_Search;
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (94)))), ((int) (((byte) (148)))), ((int) (((byte) (255)))));
            this.tb_Search.HoverState.Parent = this.tb_Search;
            this.tb_Search.Location = new System.Drawing.Point(13, 12);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.PlaceholderText = "Search Books";
            this.tb_Search.SelectedText = "";
            this.tb_Search.ShadowDecoration.Parent = this.tb_Search;
            this.tb_Search.Size = new System.Drawing.Size(295, 40);
            this.tb_Search.TabIndex = 118;
            // 
            // BookName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.ClientSize = new System.Drawing.Size(423, 579);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.DataGridView1);
            this.Name = "BookName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookName";
            ((System.ComponentModel.ISupportInitialize) (this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        internal Guna.UI2.WinForms.Guna2Button btn_Search;
        internal Guna.UI2.WinForms.Guna2TextBox tb_Search;

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;

        #endregion
    }
}