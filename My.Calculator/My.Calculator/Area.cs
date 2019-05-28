using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace My.Calculator
{
    public partial class Area : UserControl
    {
        public Area()
        {
            InitializeComponent();
            chart1.Series.Add("pol");
            chart1.Series["pol"].ChartType = SeriesChartType.Line;
            chart1.Series["pol"].Color = Color.Red;
            chart1.Series["pol"].BorderWidth = 2;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            var chart = chart1.ChartAreas[0];
            chart.AxisY.Maximum = chart.AxisX.Maximum;
            chart.AxisY.Minimum = chart.AxisX.Minimum;
            chart1.Legends.Clear();
        }

        public double[] x = new double[16];
        public double[] y = new double[16];
        public int n = 0;
        private void get_points()
        {
            try
            {
                if (textBox1.Text != "" && textBox9.Text != "")
                {
                    x[0] = Convert.ToDouble(textBox1.Text);
                    y[0] = Convert.ToDouble(textBox9.Text);
                    n = 1;
                }

                if (textBox2.Text != "" && textBox10.Text != "")
                {
                    x[1] = Convert.ToDouble(textBox2.Text);
                    y[1] = Convert.ToDouble(textBox10.Text);
                    n = 2;
                }


                if (textBox3.Text != "" && textBox11.Text != "")
                {
                    x[2] = Convert.ToDouble(textBox3.Text);
                    y[2] = Convert.ToDouble(textBox11.Text);
                    n = 3;
                }

                if (textBox4.Text != "" && textBox12.Text != "")
                {
                    x[3] = Convert.ToDouble(textBox4.Text);
                    y[3] = Convert.ToDouble(textBox12.Text);
                    n = 4;
                }

                if (textBox5.Text != "" && textBox13.Text != "")
                {
                    x[4] = Convert.ToDouble(textBox5.Text);
                    y[4] = Convert.ToDouble(textBox13.Text);
                    n = 5;
                }

                if (textBox6.Text != "" && textBox14.Text != "")
                {
                    x[5] = Convert.ToDouble(textBox6.Text);
                    y[5] = Convert.ToDouble(textBox14.Text);
                    n = 6;
                }

                if (textBox7.Text != "" && textBox15.Text != "")
                {
                    x[6] = Convert.ToDouble(textBox7.Text);
                    y[6] = Convert.ToDouble(textBox15.Text);
                    n = 7;
                }

                if (textBox8.Text != "" && textBox16.Text != "")
                {
                    x[7] = Convert.ToDouble(textBox8.Text);
                    y[7] = Convert.ToDouble(textBox16.Text);
                    n = 8;
                }
            }
            catch { }


        }
        public static double polygonArea(double[] X, double[] Y, int n)
        {

            double area = 0.0;
            int j = n - 1;

            for (int i = 0; i < n; i++)
            {
                area += (X[j] + X[i]) * (Y[j] - Y[i]);

                j = i;
            }
            return Math.Abs(area / 2.0);
        }


        private void button1_Click(object sender, EventArgs e)
        {


            chart1.Legends.Clear();
            chart1.Series["pol"].Points.Clear();
            get_points();
            for (int i = 0; i < n; i++)
                chart1.Series["pol"].Points.AddXY(x[i], y[i]);
            chart1.Series["pol"].Points.AddXY(x[0], y[0]);
            labelResult.Text = polygonArea(x, y, n).ToString();
            double xmax = x.Max();
            double ymax = y.Max();
            if (xmax < ymax)
                chart1.ChartAreas[0].AxisY.ScaleView = chart1.ChartAreas[0].AxisX.ScaleView;
            else
                chart1.ChartAreas[0].AxisX.ScaleView = chart1.ChartAreas[0].AxisY.ScaleView;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Visible = false;
            SendToBack();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not try to use self-intersecting polygon.");
        }
    }
}
