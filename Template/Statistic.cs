using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace Template
{

    public partial class Statistic : Form
    {
        private MY_DB db = new MY_DB();
        private int optionDMY = 1;
        private int optionBorrowReturn = 1;
        private int optionDMY_Account = 1;
        private int option = 1;
        public Statistic()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = 1;

            string command;
            string command1;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (option == 1 || option == 2)
            {
                command = "select * from dbo.Statistic_Borrow_By_Weeks(@date)";
                cmd = new SqlCommand(command, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            if (option == 1 || option == 3)
            {
                command1 = "select * from dbo.Statistic_Paid_By_Weeks(@date)";
                cmd = new SqlCommand(command1, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt1);
            }
            InitChart_ReBo(dt, dt1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = 2;

            string command;
            string command1;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (option == 1 || option == 2)
            {
                command = "select * from dbo.Statistic_Borrow_By_Months(@date)";
                cmd = new SqlCommand(command, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            if (option == 1 || option == 3)
            {
                command1 = "select * from dbo.Statistic_Paid_By_Months(@date)";
                cmd = new SqlCommand(command1, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt1);
            }
            InitChart_ReBo(dt, dt1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = 3;

            string command;
            string command1;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (option == 1 || option == 2)
            {
                command = "select * from dbo.Statistic_Borrow_By_Years(@date)";
                cmd = new SqlCommand(command, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            if (option == 1 || option == 3)
            {
                command1 = "select * from dbo.Statistic_Paid_By_Years(@date)";
                cmd = new SqlCommand(command1, db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt1);
            }
            InitChart_ReBo(dt, dt1);
        }

        private void toggleButton(Guna2Button a, Guna2Panel par)
        {
            Guna2Button tmp;
            foreach (object VARIABLE in par.Controls)
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
                        tmp.ForeColor = Color.Black;
                    }
                }
            }
        }

        public void InitChart_ReBo(DataTable a, DataTable b)
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Series.Clear();
            List<string> labelX = new List<string>();
            foreach (DataRow item in a.Rows)
            {
                labelX.Add(item[0].ToString());
            }
            List<double> valueBorrow = new List<double>();
            List<double> valueReturn = new List<double>();
            int n = option == 2 ? a.Rows.Count : b.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                //MessageBox.Show(a.Rows[i][1].ToString());
                if (option == 1 || option == 2)
                    valueBorrow.Add(Convert.ToDouble(a.Rows[i][1].ToString().Equals("") ? "0" : a.Rows[i][1].ToString()));
                if (option == 1 || option == 3)
                    valueReturn.Add(Convert.ToDouble(b.Rows[i][1].ToString().Equals("") ? "0" : b.Rows[i][1].ToString()));
            }

            string title;
            if (optionDMY == 1)
                title = "Week";
            else if (optionDMY == 2)
                title = "Month";
            else
            {
                title = "Year";
            }

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = title,
                Labels = labelX,
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Values",
                MinValue = 0,
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            if (option == 1 || option == 2)
                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = valueBorrow.AsChartValues(),
                    StrokeThickness = 4,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    LineSmoothness = 0,
                    PointGeometry = null,
                    Title = "Borrow"
                });
            if (option == 1 || option == 3)
                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = valueReturn.AsChartValues(),
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    LineSmoothness = 1,
                    PointGeometrySize = 15,
                    PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49)),
                    Title = "Return"
                });

        }

        //optionDMY_Account = 1(week) 2(month) 3(year)
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 1;
            LoadPanTop3(1, DateTime.Now);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 2;
            LoadPanTop3(2, DateTime.Now);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 3;
            LoadPanTop3(3, DateTime.Now);
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            LoadPanTop3(1, DateTime.Now);
            loadTopBook();
            pic1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "top1.jpg");
            pic2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "top2.jpg");
            pic3.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + "top3.jpg");

            string command1;
            string command2;
            command1 = "select * from dbo.Statistic_Borrow_By_Weeks(@date)";
            command2 = "select * from dbo.Statistic_Paid_By_Weeks(@date)";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(command1, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            DataTable dt1 = new DataTable();
            cmd = new SqlCommand(command2, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            InitChart_ReBo(dt, dt1);
        }

        private void LoadPanTop3(int option, DateTime date)
        {
            lb_book1.Text = "";
            lb_book3.Text = "";
            lb_book_2.Text = "";
            lb_name1.Text = "";
            lb_name2.Text = "";
            lb_name3.Text = "";
            SqlCommand cmd = new SqlCommand("Select * from dbo.getTop_Account(@date, @option)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
            cmd.Parameters.Add("@option", SqlDbType.Int).Value = option;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    lb_book1.Text = dt.Rows[0][2].ToString();
                    lb_book3.Text = dt.Rows[1][2].ToString();
                    lb_book_2.Text = dt.Rows[2][2].ToString();
                    lb_name1.Text = dt.Rows[0][0].ToString();
                    lb_name2.Text = dt.Rows[1][0].ToString();
                    lb_name3.Text = dt.Rows[2][0].ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void rBtn_All_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
            string command1;
            string command2;
            if (optionDMY == 1)
            {
                command1 = "select * from dbo.Statistic_Borrow_By_Weeks(@date)";
                command2 = "select * from dbo.Statistic_Paid_By_Weeks(@date)";
            }
            else if (optionDMY == 2)
            {
                command1 = "select * from dbo.Statistic_Borrow_By_Months(@date)";
                command2 = "select * from dbo.Statistic_Paid_By_Months(@date)";
            }
            else
            {
                command1 = "select * from dbo.Statistic_Borrow_By_Years(@date)";
                command2 = "select * from dbo.Statistic_Paid_By_Years(@date)";
            }
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(command1, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            DataTable dt1 = new DataTable();
            cmd = new SqlCommand(command2, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            InitChart_ReBo(dt, dt1);
        }

        private void rBtn_Borrow_CheckedChanged(object sender, EventArgs e)
        {
            option = 2;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string command = "";
            if (optionDMY == 1)
            {
                command = "select * from dbo.Statistic_Borrow_By_Weeks(@date)";
            }
            else if (optionDMY == 2)
            {
                command = "select * from dbo.Statistic_Borrow_By_Months(@date)";
            }
            else
            {
                command = "select * from dbo.Statistic_Borrow_By_Years(@date)";
            }
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            DataTable dt1 = new DataTable();
            InitChart_ReBo(dt, dt1);
        }

        private void rBtn_Return_CheckedChanged(object sender, EventArgs e)
        {
            option = 3;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string command = "";
            if (optionDMY == 1)
            {
                command = "select * from dbo.Statistic_Paid_By_Weeks(@date)";
            }
            else if (optionDMY == 2)
            {
                command = "select * from dbo.Statistic_Paid_By_Months(@date)";
            }
            else
            {
                command = "select * from dbo.Statistic_Paid_By_Years(@date)";
            }
            cmd = new SqlCommand(command, db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            DataTable dt1 = new DataTable();
            InitChart_ReBo(dt1, dt);
        }

        private void loadTopBook()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.getTop_Book(@date, @option)", db.getConnection);
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("@option", SqlDbType.Int).Value = 3;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                pieChart1.Series.Add(new PieSeries()
                {
                    Title = item[1].ToString(),
                    Values = new ChartValues<double> { Convert.ToDouble(item[2].ToString()) },
                    DataLabels = true,
                });
                pieChart1.LegendLocation = LegendLocation.Bottom;

            }
        }
    }
}