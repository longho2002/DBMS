using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Guna.UI2.WinForms;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace Template
{
    public partial class Statistic : Form
    {
        private int optionDMY = 1;
        private int optionBorrowReturn = 1;
        private int optionDMY_Account = 1;
        public Statistic()
        {
            InitializeComponent();
            List<int> a = new List<int> {5, 1, 4, 2, 3, 1, 5, 3, 5, 10, 11, 12};
            List<int> b = new List<int> {1, 2, 4, 2, 3, 1, 5, 3, 6, 2, 4, 12};
            InitChart_ReBo(a, b, optionDMY, optionBorrowReturn);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = 0;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel1);
            optionDMY = 1;
        }

        private void toggleButton(Guna2Button a,Guna2Panel par)
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

        public void InitChart_ReBo(List<int> valueBorrow, List<int> valueReturn, int optionDMY, int optionBorrowReturn)
        {
            ////////////////////-Đọc kĩ hướng dẫn trước khi sử dụng-//////////////////////////
            // optionDMY = 1 => year
            // optionDMY = 0 => week
            // optionDMY = 28 29 30 31 => month
            /////////////////////////////////////////////////
            // optionDMY = 1 => Borrow
            // optionDMY = 2 => Return
            // optionDMY = 3 => All
            if (optionDMY == 1)
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Year",
                    Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
                });
            else if (optionDMY == 0)
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
                for (int i = 1; i <= optionDMY; i++)
                {
                    num.Add(i.ToString());
                }

                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Month",
                    Labels = num
                });
            }

            // làm cho zui đừng để ý :))
            List<string> tmp =
                (new List<int>(valueBorrow.Concat(valueReturn))).ConvertAll<string>(delegate(int i)
                {
                    return i.ToString();
                });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Values",
            });

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            if (optionBorrowReturn == 1 || optionBorrowReturn == 3)
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
            if (optionBorrowReturn == 2 || optionBorrowReturn == 3)
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

        private void pieChart1_ChildChanged(object sender, ChildChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        
        //optionDMY_Account = 1(week) 2(month) 3(year)
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 1;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 2;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Guna2Button, guna2Panel3);
            optionDMY_Account = 3;
        }
    }
}