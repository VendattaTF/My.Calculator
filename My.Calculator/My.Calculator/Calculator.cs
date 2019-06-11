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
    public partial class Calculator : UserControl
    {
        
        public Calculator()
        {
            InitializeComponent();
            CreateButton();

        }
        string result;

        private void button10_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0.00")
            {
                textBox_Result.Text = "";
                textBox_Result.ForeColor = Color.Black;
            }
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void buttonNr_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0.00")
            {
                textBox_Result.Text = "";
                textBox_Result.ForeColor = Color.Black;
            }
            if (textBox_Result.Text == result)
                textBox_Result.Text = "";
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string str = textBox_Result.Text;
            MathParser g = new MathParser();
            textBox_Result.Text = g.Calculate(str).ToString();
            result = textBox_Result.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "";
        }

        private void textBox_Result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button15.PerformClick();
                textBox_Result.SelectionStart = textBox_Result.Text.Length;
                textBox_Result.SelectionLength = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string str = textBox_Result.Text;
            str = "sqrt(" + str + ")";
            textBox_Result.Text = str;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string str = textBox_Result.Text;
            str = "(" + str + ")^2";
            textBox_Result.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox_Result.Text;
                str = str.Substring(0, str.Length - 1);
                textBox_Result.Text = str;
            }
            catch { }

        }


        private void CreateButton()
        {
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = BackColor;
            buttonBack.UseVisualStyleBackColor = true;


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBox_Result.Focus();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Help1 help = new Help1();
            help.Show();
        }


        private void textBox_Result_Enter(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "NaN")
                textBox_Result.Text = "";
            if(textBox_Result.Text=="0.00")
            {
                textBox_Result.Text = "";
                textBox_Result.ForeColor = Color.Black;
            }
        }

        private void textBox_Result_Leave(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "")
            {
                textBox_Result.Text = "0.00";
                textBox_Result.ForeColor = Color.Silver;
            }
        }
    }
}
