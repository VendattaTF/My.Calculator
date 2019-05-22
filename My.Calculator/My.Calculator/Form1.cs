using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            SidePanel2.Height = button6.Height;
            SidePanel2.Top = button6.Top;
            SidePanel2.BackColor = Color.FromArgb(100, 96, 10, 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            calculator1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            graph1.BringToFront();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button5.Height;
            SidePanel2.Top = button5.Top;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button6.Height;
            SidePanel2.Top = button6.Top;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
