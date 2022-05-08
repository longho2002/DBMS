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
    public partial class UpdateRemoveBook : Form
    {
        public UpdateRemoveBook()
        {
            InitializeComponent();
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            AddAuthor a = new AddAuthor();
            a.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditAuthor a = new EditAuthor();
            a.Show(this);
        }

        private void btn_publisher_Click(object sender, EventArgs e)
        {
            AddPublish a = new AddPublish(); a.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPublish a = new EditPublish(); a.Show(this);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            AddLoc a = new AddLoc(); a.Show(this);
        }
    }
}
