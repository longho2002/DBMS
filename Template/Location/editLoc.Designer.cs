namespace Template.Location
{
    partial class EditLoc
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
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_loc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(123, 143);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(126, 41);
            this.btn_can.TabIndex = 193;
            this.btn_can.Text = "Xóa";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(277, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 41);
            this.btn_add.TabIndex = 192;
            this.btn_add.Text = "Cập nhật";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // tb_loc
            // 
            this.tb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loc.Location = new System.Drawing.Point(189, 82);
            this.tb_loc.Name = "tb_loc";
            this.tb_loc.Size = new System.Drawing.Size(257, 29);
            this.tb_loc.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 195;
            this.label2.Text = "Tên vị trí:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 31);
            this.label10.TabIndex = 194;
            this.label10.Text = "Vị trí";
            // 
            // editLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 227);
            this.Controls.Add(this.tb_loc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_add);
            this.Name = "EditLoc";
            this.Text = "editLoc";
            this.Load += new System.EventHandler(this.editLoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}