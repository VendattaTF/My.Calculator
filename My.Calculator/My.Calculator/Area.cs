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
            chart1.Series.Add("Gf");
            chart1.Series["Gf"].ChartType = SeriesChartType.Line;
            chart1.Series["Gf"].Color = Color.Red;
            chart1.Series["Gf"].BorderWidth = 2;
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
                    x[n] = Convert.ToDouble(textBox1.Text);
                    y[n] = Convert.ToDouble(textBox9.Text);
                    n++;
                }

                if (textBox2.Text != "" && textBox10.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox2.Text);
                    y[n] = Convert.ToDouble(textBox10.Text);
                    n++;
                }


                if (textBox3.Text != "" && textBox11.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox3.Text);
                    y[n] = Convert.ToDouble(textBox11.Text);
                    n++;
                }

                if (textBox4.Text != "" && textBox12.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox4.Text);
                    y[n] = Convert.ToDouble(textBox12.Text);
                    n++;
                }

                if (textBox5.Text != "" && textBox13.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox5.Text);
                    y[n] = Convert.ToDouble(textBox13.Text);
                    n++;
                }

                if (textBox6.Text != "" && textBox14.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox6.Text);
                    y[n] = Convert.ToDouble(textBox14.Text);
                    n++;
                }

                if (textBox7.Text != "" && textBox15.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox7.Text);
                    y[n] = Convert.ToDouble(textBox15.Text);
                    n++;
                }

                if (textBox8.Text != "" && textBox16.Text != "")
                {
                    x[n] = Convert.ToDouble(textBox8.Text);
                    y[n] = Convert.ToDouble(textBox16.Text);
                    n++;
                }
            }
            catch { }


        }
        private double polygonArea(double[] X, double[] Y, int n)
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
            chart1.Series["Gf"].Points.Clear();
            get_points();
            for (int i = 0; i < n; i++)
                chart1.Series["Gf"].Points.AddXY(x[i], y[i]);
            chart1.Series["Gf"].Points.AddXY(x[0], y[0]);
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
