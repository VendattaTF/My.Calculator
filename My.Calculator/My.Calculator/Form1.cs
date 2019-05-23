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
                // Release the mouse capture started by the mouse down.
                panel1.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
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
                // Release the mouse capture started by the mouse down.
                panel3.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
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
                // Release the mouse capture started by the mouse down.
                label1.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
    }
}
