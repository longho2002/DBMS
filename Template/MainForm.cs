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
            Globals.SetUser("U-002", "customer", "Cozark");
            //this.ClientSize = new System.Drawing.Size(1223, 800);
            //Globals.SetUser("AD-004", "admin", "Cozark");
            if (Globals.role == "admin")
            {
                picture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "admin.jpg");
            }
            else if (Globals.role == "staff")
                picture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "staff.jpg");
            else
            {
                picture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "user.jpg");

            }
            lb_name.Text = "Welcome Back (" + Globals.nameUser + ")";
            lb_role.Text = Globals.role.ToUpper();
            if (Globals.role.Equals("customer"))
            {
                OverviewUser aa = new OverviewUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Pan_Infor.Controls.Add(aa);
                aa.Show();
                btn_Borrow.Visible = false;
                btn_statistic.Visible = false;
                btn_book.Location = new Point(21, 286);
                return;
            }
            Overview a = new Overview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            Pan_Infor.Controls.Clear();
            toggleButton_Click(sender as Guna2Button);
            book a = new book() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }

        private void btn_Acccount_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            toggleButton_Click((sender as Guna2Button));
            Pan_Infor.Controls.Clear();
            if (Globals.role.Equals("customer"))
            {
                UserInfo a = new UserInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Pan_Infor.Controls.Add(a);
                a.Show();
                return;
            }
            Account acc = new Account() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Pan_Infor.Controls.Add(acc);
            acc.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            toggleButton_Click((sender as Guna2Button));
            Pan_Infor.Controls.Clear();
            if (Globals.role.Equals("customer"))
            {
                OverviewUser aa = new OverviewUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Pan_Infor.Controls.Add(aa);
                aa.Show();
                return;
            }
            Overview a = new Overview() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Pan_Infor.Controls.Add(a);
            a.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
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
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            Pan_Infor.Controls.Clear();
            toggleButton_Click((sender as Guna2Button));
            guna2ShadowForm1.SetShadowForm(this);
            Statistic a = new Statistic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            Pan_Infor.Controls.Clear();
            toggleButton_Click((sender as Guna2Button));
            if (Globals.role.Equals("customer"))
            {
                DashBoard_Cus aa = new DashBoard_Cus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Pan_Infor.Controls.Add(aa);
                aa.Show();
                return;
            }
            DashBoard a = new DashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Pan_Infor.Controls.Add(a);
            a.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            toggleButton_Click((sender as Guna2Button));
            Pan_Infor.Controls.Clear();
            Borrow a = new Borrow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Pan_Infor.Controls.Add(a);
            a.Show();
            GC.Collect();
            GC.Collect();
            GC.Collect();
        }


        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            InfoGroup a = new InfoGroup();
            a.ShowDialog(this);
        }
    }
}
