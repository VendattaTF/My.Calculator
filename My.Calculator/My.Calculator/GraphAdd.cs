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
    public partial class GraphAdd : Form
    {
        Graph graph;
        public GraphAdd(Graph graph1)
        {
            InitializeComponent();
            this.graph = graph1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph.Add_Exp();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            graph.graph_null();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
        public string get_Expression()
        {
            return textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }
    }
}
