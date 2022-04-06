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
        public Overview()
        {
            InitializeComponent();

            //also adding values updates and animates the chart automatically
            List<int> a = new List<int>{5,1,4,2,3,1,5,3,5,10,11,12 } ;
            List<int> b = new List<int> { 1, 2, 4, 2, 3, 1, 5, 3, 6, 2, 4, 12 };
            InitChart(a,b);
        }

        public void InitChart(List<int> valueBorrow, List<int> valueReturn)
        {
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            List<string> tmp = (new List<int>( valueBorrow.Concat(valueReturn).Distinct())).ConvertAll<string>(delegate (int i) { return i.ToString(); });
            
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
                PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49)),
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
    }
}
