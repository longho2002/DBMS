using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace Template
{
    public partial class Overview : Form
    {
        private MY_DB db = new MY_DB();
        private int page = 1;
        private int max_page = 100;

        public Overview()
        {
            InitializeComponent();

        }
        private void Overview_Load(object sender, EventArgs e)
        {
            DataGridView1.RowTemplate.Height = 40;
            DataGridView1.ColumnHeadersHeight = 30;
            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SqlCommand cmd = new SqlCommand("select * from Borrowed_Information", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            max_page = Convert.ToInt32(Math.Ceiling(dt.Rows.Count / 5.0));
            lb_Page.Text = ("Trang " + page.ToString() + "/" + max_page.ToString());
            showPage();
            //List<int> a = new List<int> { 5, 1, 4, 2, 3, 1, 5, 3, 5, 10, 11, 12 };
            //List<int> b = new List<int> { 1, 2, 4, 2, 3, 1, 5, 3, 6, 2, 4, 12 };
            //// option = 1 year  =2 week  month
            //InitChart(a, b, 1);



            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Tolal()", db.getConnection);
            da.SelectCommand = cmd;
            da.Fill(dt1);
            lb_totalU.Text = dt1.Rows[0][0].ToString();
            lb_totalBook.Text = dt1.Rows[0][1].ToString();
            lb_issued.Text = dt1.Rows[0][2].ToString();
            lb_return.Text = dt1.Rows[0][3].ToString();

            int y = 56;
            DataTable dt2 = new DataTable();
            cmd = new SqlCommand("select * from dbo.top_5_Account()", db.getConnection);
            da.SelectCommand = cmd;
            da.Fill(dt2);
            for (int i = 0; i < 5; i++)
            {
                guna2Panel3.Controls.Add(createTop(dt2.Rows[i][0].ToString(), Convert.ToInt32(dt2.Rows[i][1].ToString()), 13, y + 66 * i + 10));
            }
            cmd.Parameters.Clear();
            DataTable dt3 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Statistic_Borrow_By_Weeks(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt3);
            cmd.Parameters.Clear();

            DataTable dt4 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Statistic_Paid_By_Weeks(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt4);

            InitChart(dt3, dt4, 2);
        }

        public void InitChart(DataTable a, DataTable b, int option)
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
            int n = a.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                //MessageBox.Show(a.Rows[i][1].ToString());
                valueBorrow.Add(Convert.ToDouble(a.Rows[i][1].ToString().Equals("") ? "0": a.Rows[i][1].ToString()));
                valueReturn.Add(Convert.ToDouble(b.Rows[i][1].ToString().Equals("") ? "0" : b.Rows[i][1].ToString()));
            }
            string title = "";
            if (option == 1)
                title = "Year";
            else if (option == 2)
                title = "Week";
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
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = valueReturn.AsChartValues(),
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49)),
                Title = "Return"
            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // THIS WEEK
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from dbo.Statistic_Borrow_By_Weeks(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt);

            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Statistic_Paid_By_Weeks(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt1);

            InitChart(dt, dt1, 2);
            toggleButton(sender as Guna2Button);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //THIS MONTH
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from dbo.Statistic_Borrow_By_Months(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt);

            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Statistic_Paid_By_Months(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt1);
            InitChart(dt, dt1, 30);
            toggleButton(sender as Guna2Button);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // THIS YEAR
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from dbo.Statistic_Borrow_By_Years(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt);

            DataTable dt4 = new DataTable();
            cmd = new SqlCommand("select * from dbo.Statistic_Paid_By_Years(@date)", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            da.SelectCommand = cmd;
            da.Fill(dt4);
            InitChart(dt, dt4, 1);
            toggleButton(sender as Guna2Button);
        }

        private void toggleButton(Guna2Button a)
        {
            Guna2Button tmp;
            foreach (object VARIABLE in guna2Panel1.Controls)
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

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                lb_Page.Text = ("Trang " + page.ToString() + "/" + max_page.ToString());
                showPage();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (page < max_page)
            {
                page++;
                lb_Page.Text = ("Trang " + page.ToString() + "/" + max_page.ToString());
                showPage();
            }
        }

        private Guna2ShadowPanel createTop(string name, int total, int x, int y)
        {
            // 
            // guna2HtmlLabel9
            // 
            Label lb_name = new Label();
            lb_name.BackColor = System.Drawing.Color.Transparent;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lb_name.Location = new System.Drawing.Point(23, 14);
            lb_name.Margin = new System.Windows.Forms.Padding(2);
            lb_name.Size = new System.Drawing.Size(100, 20);
            lb_name.Text = "ID: " + name;
            // 
            // guna2HtmlLabel13
            // 
            Label lb_num = new Label();
            lb_num.BackColor = System.Drawing.Color.Transparent;
            lb_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lb_num.Location = new System.Drawing.Point(234, 14);
            lb_num.Margin = new System.Windows.Forms.Padding(2);
            lb_num.Size = new System.Drawing.Size(33, 26);
            lb_num.Text = total.ToString();
            // 
            // guna2HtmlLabel12
            // 
            Label lb_total = new Label();
            lb_total.BackColor = System.Drawing.Color.Transparent;
            lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lb_total.Location = new System.Drawing.Point(170, 14);
            lb_total.Margin = new System.Windows.Forms.Padding(2);
            lb_total.Size = new System.Drawing.Size(80, 26);
            lb_total.Text = "Total: ";
            // 
            // pan_acc
            // 
            Guna2ShadowPanel pan_tmp = new Guna2ShadowPanel();

            pan_tmp.BackColor = System.Drawing.Color.Transparent;
            pan_tmp.Controls.Add(lb_name);
            pan_tmp.Controls.Add(lb_num);
            pan_tmp.Controls.Add(lb_total);
            pan_tmp.FillColor = System.Drawing.Color.White;
            pan_tmp.Location = new System.Drawing.Point(x, y);
            pan_tmp.ShadowColor = System.Drawing.Color.Gray;
            pan_tmp.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            pan_tmp.Size = new System.Drawing.Size(281, 66);
            pan_tmp.TabIndex = 2;
            return pan_tmp;
        }

        void showPage()
        {
            DataGridView1.Rows.Clear();
            DataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.paginate(@page, @num)", db.getConnection);
            // cmd.CommandType=CommandType.StoredProcedure;  
            cmd.Parameters.AddWithValue("@page", page - 1);
            cmd.Parameters.AddWithValue("@num", 5);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridView1.Rows.Add(dt.Rows.Count);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                DataGridView1.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Rows[i].Cells[0].Value = item[0].ToString();
                DataGridView1.Rows[i].Cells[1].Value = item[2].ToString();
                DataGridView1.Rows[i].Cells[2].Value = item[1].ToString();
                DataGridView1.Rows[i].Cells[3].Value = item[3].ToString().Split(' ')[0];
                if (item[4].ToString().Equals("Compensated "))
                {
                    DataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                }
                else
                {
                    DataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.LawnGreen;
                }
                DataGridView1.Rows[i].Cells[4].Value = item[4].ToString();
                i++;
            }
        }

    }
}