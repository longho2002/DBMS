using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btn_UploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                rjCircularPictureBox1.Image = Image.FromFile(opf.FileName);
                rjCircularPictureBox1.Text = opf.FileName.Split('\\').Last();
                rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Globals.idUser;
        }
    }
}
