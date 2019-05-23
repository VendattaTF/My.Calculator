using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.Calculator
{
    public partial class NumarPrim : UserControl
    {
        public NumarPrim()
        {
            InitializeComponent();
        }
        public int prim(int n)
        {
            if (n < 2) return 0;
            if (n == 2) return 1;
            if (n % 2 == 0) return 0;
            for (int i = 3; i * i <= n; i += 3)
                if (n % i == 0) return 0;
            return 1;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox1.Text;
                if (prim(Convert.ToInt32(str)) == 1)
                {
                    label1.Text = "Este numare prim.";
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.Text = "Nu este numare prim.";
                    label1.BackColor = Color.Blue;
                }

            }
            catch
            {
                MessageBox.Show("Invalid data.");
                textBox1.Text = "";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                StartButton.PerformClick();
        }
    }
}
