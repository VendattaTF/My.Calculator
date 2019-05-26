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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            SidePanel2.Height = button6.Height;
            SidePanel2.Top = button6.Top;
            SidePanel2.BackColor = Color.FromArgb(100, 96, 10, 10);
            graph1.BringToFront();
            SidePanel.BringToFront();
            credits1.Visible = false;
            credits1.SendToBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            calculator1.BringToFront();
            calculator1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            graph1.BringToFront();
            graph1.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            numarPrim1.BringToFront();
            numarPrim1.Visible = true;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button1.Height;
            SidePanel2.Top = button1.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            credits1.Visible = true;
            credits1.BringToFront();
        }

        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                panel1.Capture = false;

                
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                panel3.Capture = false;

                
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                label1.Capture = false;

                
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quiz1.BringToFront();
            quiz1.Visible = true;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button2.Height;
            SidePanel2.Top = button2.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            graph1.Visible = false;
            calculator1.Visible = false;
            credits1.Visible = false;
            numarPrim1.Visible = false;
            quiz1.Visible = false;
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button7.Height;
            SidePanel2.Top = button7.Top;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel2.Height = button8.Height;
            SidePanel2.Top = button8.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            graph1.Visible = false;
            calculator1.Visible = false;
            credits1.Visible = false;
            numarPrim1.Visible = false;
            quiz1.Visible = false;
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
        }
    }
}
