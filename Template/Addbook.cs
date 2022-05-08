using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Template.Author;
using Template.Location;
using Template.Publish_Company;

namespace Template
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            AddAuthor a = new AddAuthor(); a.Show(this);
        }

        private void btn_publisher_Click(object sender, EventArgs e)
        {
            AddPublish a = new AddPublish(); a.Show(this);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            AddLoc a = new AddLoc(); a.Show(this);
        }

        private void Addbook_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Text = opf.FileName.Split('\\').Last();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Borrow_Now_Click(object sender, EventArgs e)
        {
            BookName a = new BookName();
            a.ShowDialog();
            ///// đổ chức năng vào đây
        }
    }
}
