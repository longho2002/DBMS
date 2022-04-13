using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Template
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            Overview a = new Overview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Pan_Infor.Controls.Clear();
            toggleButton_Click(sender as Guna2Button);
            book a = new book() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
        }

        private void btn_Acccount_Click(object sender, EventArgs e)
        {
            toggleButton_Click((sender as Guna2Button));
            Account acc = new Account() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Pan_Infor.Controls.Clear();
            Pan_Infor.Controls.Add(acc);
            acc.Show();
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            toggleButton_Click((sender as Guna2Button));
            Pan_Infor.Controls.Clear();
            Overview a = new Overview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Pan_Infor.Controls.Add(a);
            a.Show();
        }

        private void toggleButton_Click(Guna2Button a)
        {
            Guna2Button tmp;
            foreach (object VARIABLE in Pan_Menu.Controls)
            {
                if (VARIABLE.GetType() == typeof(Guna2Button))
                {
                    tmp = VARIABLE as Guna2Button;
                    if (tmp.Text.Equals(a.Text))
                    {
                        tmp.BackColor = Color.FromArgb(94, 148, 255);
                        tmp.ForeColor = Color.White;
                    }
                    else
                    {
                        tmp.BackColor = Color.Transparent;
                        tmp.ForeColor = Color.Gray;
                    }
                }

            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            Pan_Infor.Controls.Clear();
            toggleButton_Click((sender as Guna2Button));
            guna2ShadowForm1.SetShadowForm(this);
            Statics a = new Statics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
        }
    }
}
