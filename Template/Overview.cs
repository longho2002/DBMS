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
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace Template
{
    public partial class Overview : Form
    {
        private int page = 1;
        private int max_page = 100;

        public Overview()
        {
            InitializeComponent();
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //pan_tmp.Location = new System.Drawing.Point(13, 56);
            //pan_tmp.Size = new System.Drawing.Size(253, 46);
            //also adding values updates and animates the chart automatically
            List<int> a = new List<int> {5, 1, 4, 2, 3, 1, 5, 3, 5, 10, 11, 12};
            List<int> b = new List<int> {1, 2, 4, 2, 3, 1, 5, 3, 6, 2, 4, 12};
            // option = 1 year  =2 week  month
            InitChart(a, b, 1);

            int y = 56;
            int height = 46;

            for (int i = 0; i < 5; i++)
            {
                guna2Panel3.Controls.Add(createTop("Cozark", 12, 13, y + 66 * i + 10));
            }
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.ColumnHeadersHeight = 30;
        }


        public void InitChart(List<int> valueBorrow, List<int> valueReturn, int option)
        {
            if (option == 1)
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Year",
                    Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
                });
            else if (option == 0)
            {
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Week",
                    Labels = new[] {"Mon", "Tue", "Wed", "Thus", "Fri", "Sat", "Sun"}
                });
            }
            else
            {
                List<string> num = new List<string>();
                for (int i = 1; i <= option; i++)
                {
                    num.Add(i.ToString());
                }
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Month",
                    Labels = num
                });
            }

            List<string> tmp =
                (new List<int>(valueBorrow.Concat(valueReturn).Distinct())).ConvertAll<string>(delegate(int i)
                {
                    return i.ToString();
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
            toggleButton(sender as Guna2Button);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (page < max_page)
            {
                page++;
                lb_Page.Text = ("Trang " + page.ToString() + "/" + max_page.ToString());
            }
        }

        private Guna2ShadowPanel createTop(string name, int total, int x, int y)
        {
            // 
            // guna2HtmlLabel9
            // 
            Guna2HtmlLabel lb_name = new Guna2HtmlLabel();
            lb_name.BackColor = System.Drawing.Color.Transparent;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lb_name.Location = new System.Drawing.Point(23, 14);
            lb_name.Margin = new System.Windows.Forms.Padding(2);
            lb_name.Size = new System.Drawing.Size(61, 26);
            lb_name.Text = name;
            // 
            // guna2HtmlLabel13
            // 
            Guna2HtmlLabel lb_num = new Guna2HtmlLabel();
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
            Guna2HtmlLabel lb_total = new Guna2HtmlLabel();
            lb_total.BackColor = System.Drawing.Color.Transparent;
            lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lb_total.Location = new System.Drawing.Point(181, 14);
            lb_total.Margin = new System.Windows.Forms.Padding(2);
            lb_total.Size = new System.Drawing.Size(49, 26);
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

        private void Overview_Load(object sender, EventArgs e)
        {
        }
    }
}