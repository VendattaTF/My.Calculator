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
    public partial class Credits : UserControl
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/VendattaTF/My.Calculator");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/VendattaTF/My.Calculator");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
