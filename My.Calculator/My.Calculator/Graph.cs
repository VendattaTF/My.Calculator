using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using System.Windows.Forms.DataVisualization.Charting;

namespace My.Calculator
{
    public partial class Graph : UserControl
    {

        public Graph()
        {
            InitializeComponent();
            button1.PerformClick();
            this.chart1.MouseWheel += chart1_MouseWheel;
        }

        float xmax = 12;
        float xmin = -12;
        float ymax = 24;
        float ymin = -24;
        float xint = 1;
        float yint = 4;
        float xplus = 5;
        float yplus = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Maximum = xmax;
            chart.AxisX.Minimum = xmin;
            chart.AxisY.Maximum = ymax;
            chart.AxisY.Minimum = ymin;
            chart.AxisX.Interval = xint;
            chart.AxisY.Interval = yint;

            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.Series.Clear();
            chart1.Series.Add("First");
            chart1.Series["First"].ChartType = SeriesChartType.Line;
            chart1.Series["First"].Color = Color.Blue;

            
            


            chart1.Series.Add("AxisX");
            chart1.Series["AxisX"].ChartType = SeriesChartType.Line;
            chart1.Series["AxisX"].Color = Color.Black;
            chart1.Series["AxisX"].Points.AddXY(0, ymax);
            chart1.Series["AxisX"].Points.AddXY(0, ymin);

            chart1.Series.Add("AxisY");
            chart1.Series["AxisY"].ChartType = SeriesChartType.Line;
            chart1.Series["AxisY"].Color = Color.Black;
            chart1.Series["AxisY"].Points.AddXY(xmin, 0);
            chart1.Series["AxisY"].Points.AddXY(xmax, 0);
            chart1.Legends.Clear();
            ChartArea CA = chart1.ChartAreas[0];  // quick reference
            CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = ("#0.00");
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = ("#0.00");

            try
            {
                Argument x = new Argument("x");
                Expression g = new Expression(textBox1.Text, x);
                x.setArgumentValue(xmin);
                double y;
                
                

                for (double i = xmin; i <= xmax; i += 0.01F)
                {

                    x.setArgumentValue(i);
                    y = g.calculate();
                    if (Math.Abs(y) > 99999 || Math.Abs(y) < -99999)
                    { }
                    else
                    { 
                        chart1.Series["First"].Points.AddXY(i, y);
                    }

                }
                
                
            }
            catch
            {
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmax = xmax / 2;
            xmin = xmin / 2;
            ymax = ymax / 2;
            ymin = ymin / 2;
            xint = xint / 2;
            yint = yint / 2;
            xplus = xplus / 2;
            yplus = yplus / 2;
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xmax = xmax * 2;
            xmin = xmin * 2;
            ymax = ymax * 2;
            ymin = ymin * 2;
            xint = xint * 2;
            yint = yint * 2;
            xplus = xplus * 2;
            yplus = yplus * 2;
            button1.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xmin = xmin - xplus;
            xmax = xmax - xplus;
            button1.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xmin = xmin + xplus;
            xmax = xmax + xplus;
            button1.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            xmax = xmax / 2;
            xmin = xmin / 2;
            xint = xint / 2;
            xplus = xplus / 2;
            button1.PerformClick();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            xmax = xmax * 2;
            xmin = xmin * 2;
            xint = xint * 2;
            xplus = xplus * 2;
            button1.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ymax = ymax / 2;
            ymin = ymin / 2;
            yint = yint / 2;
            yplus = yplus / 2;
            button1.PerformClick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ymax = ymax * 2;
            ymin = ymin * 2;
            yint = yint * 2;
            yplus = yplus * 2;
            button1.PerformClick();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Argument x = new Argument("x");
                Expression g = new Expression(textBox1.Text, x);
                string str = textBox2.Text;
                x.setArgumentValue(Convert.ToDouble(str));
                labelResult.Text = g.calculate().ToString();
            }
            catch { }


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button12.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Help1 help = new Help1();
            help.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ymin += yplus;
            ymax += yplus;
            button1.PerformClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ymin -= yplus;
            ymax -= yplus;
            button1.PerformClick();
        }

        private void chart1_MouseHover(object sender, EventArgs e)
        {
            chart1.Focus();
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        GraphAdd graphAdd;

        public void graph_null()
        {
            graphAdd = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (graphAdd == null)
            {
                graphAdd = new GraphAdd(this);
                graphAdd.Show();
            }
        }

        public void Add_Exp()
        {

            button1.PerformClick();
            chart1.Series.Add("Second");
            chart1.Series["Second"].ChartType = SeriesChartType.Line;
            chart1.Series["Second"].Color = Color.Green;
            string str = graphAdd.get_Expression();
            try
            {
                Argument x = new Argument("x");
                Expression g = new Expression(str, x);
                x.setArgumentValue(xmin);
                double y;



                for (double i = xmin; i <= xmax; i += 0.01F)
                {

                    x.setArgumentValue(i);
                    y = g.calculate();
                    if (Math.Abs(y) > 99999 || Math.Abs(y) < -99999)
                    { }
                    else
                    {
                        chart1.Series["Second"].Points.AddXY(i, y);
                    }

                }


            }
            catch
            {

            }

        }
    }
}
