using System;
using System.Windows.Forms;

namespace Template
{
    public partial class OverviewUser : Form
    {
        public OverviewUser()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePass a = new UpdatePass();
            a.ShowDialog(this);
        }

        private void OverviewUser_Load(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Value = 26;
        }
    }
}
