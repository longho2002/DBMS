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
                guna2Panel3.Controls.Add(createTop("Cozark", 12, 13, y + 46 * i + 10));
            }
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

        private Guna2CustomGradientPanel createTop(string name, int total, int x, int y)
        {
            // 
            // guna2HtmlLabel13
            // 
            Guna2HtmlLabel lb_Number = new Guna2HtmlLabel();
            lb_Number.BackColor = System.Drawing.Color.Transparent;
            lb_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            lb_Number.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            lb_Number.Location = new System.Drawing.Point(201, 9);
            lb_Number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            lb_Number.Name = "guna2HtmlLabel13";
            lb_Number.Size = new System.Drawing.Size(33, 26);
            lb_Number.TabIndex = 5;
            lb_Number.Text = total.ToString();
            // 
            // guna2HtmlLabel12
            // 
            Guna2HtmlLabel total_book = new Guna2HtmlLabel();
            total_book.BackColor = System.Drawing.Color.Transparent;
            total_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            total_book.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            total_book.Location = new System.Drawing.Point(148, 9);
            total_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            total_book.Name = "guna2HtmlLabel12";
            total_book.Size = new System.Drawing.Size(49, 26);
            total_book.TabIndex = 4;
            total_book.Text = "Total: ";
            // 
            // guna2HtmlLabel11
            // 
            Guna2HtmlLabel lb_NameTop = new Guna2HtmlLabel();
            lb_NameTop.BackColor = System.Drawing.Color.Transparent;
            lb_NameTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            lb_NameTop.Location = new System.Drawing.Point(56, 11);
            lb_NameTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            lb_NameTop.Name = "guna2HtmlLabel11";
            lb_NameTop.Size = new System.Drawing.Size(59, 24);
            lb_NameTop.TabIndex = 3;
            lb_NameTop.Text = name;
            // 
            // guna2CirclePictureBox1
            // 
            Guna2CirclePictureBox pic = new Guna2CirclePictureBox();
            pic.Image = global::Template.Properties.Resources._1081856_200;
            pic.ImageRotate = 0F;
            pic.Location = new System.Drawing.Point(0, 0);
            pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pic.Name = "guna2CirclePictureBox1";
            pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pic.Size = new System.Drawing.Size(41, 46);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 2;
            pic.TabStop = false;

            Guna2CustomGradientPanel pan_tmp = new Guna2CustomGradientPanel();
            pan_tmp.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (128)))));
            pan_tmp.BorderThickness = 2;
            pan_tmp.Controls.Add(lb_Number);
            pan_tmp.Controls.Add(total_book);
            pan_tmp.Controls.Add(lb_NameTop);
            pan_tmp.Controls.Add(pic);
            pan_tmp.FillColor = System.Drawing.Color.Empty;
            pan_tmp.FillColor2 = System.Drawing.Color.Empty;
            pan_tmp.FillColor3 = System.Drawing.Color.Empty;
            pan_tmp.FillColor4 = System.Drawing.Color.Empty;
            pan_tmp.Location = new System.Drawing.Point(x, y);
            pan_tmp.Margin = new System.Windows.Forms.Padding(14);
            pan_tmp.Name = "pan_Top";
            pan_tmp.Size = new System.Drawing.Size(253, 46);
            pan_tmp.TabIndex = 0;
            return pan_tmp;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}