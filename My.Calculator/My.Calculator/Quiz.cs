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
    public partial class Quiz : UserControl
    {
        public Quiz()
        {
            InitializeComponent();
        }

        int i = 60;


        private void button1_Click(object sender, EventArgs e)
        {
            button_Finish.BringToFront();
            labSucces.Text = "";
            labSucces.BackColor = Color.Transparent;
            i = 60;
            timer1.Enabled = true;
            Random rand = new Random();
            lab1.Text = rand.Next(101).ToString();
            lab2.Text = rand.Next(101).ToString();
            lab3.Text = rand.Next(101).ToString();
            lab4.Text = rand.Next(101).ToString();
            lab5.Text = rand.Next(21).ToString();
            lab6.Text = rand.Next(21).ToString();
            lab7.Text = rand.Next(21).ToString();
            lab8.Text = rand.Next(21).ToString();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";


        }
        public int check()
        {
            int ok = 1;
            try
            {
                if (int.Parse(textBox1.Text) != int.Parse(lab1.Text) + int.Parse(lab2.Text))
                    ok = 0;
                if (int.Parse(textBox2.Text) != int.Parse(lab3.Text) - int.Parse(lab4.Text))
                    ok = 0;
                if (int.Parse(textBox3.Text) != int.Parse(lab5.Text) * int.Parse(lab6.Text))
                    ok = 0;
                if (int.Parse(textBox4.Text) != int.Parse(lab7.Text) / int.Parse(lab8.Text))
                    ok = 0;
            }
            catch
            { ok = 2; }
            return ok;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(timelabel.Text) > 0)
                i--;
            timelabel.Text = i.ToString();
            if (int.Parse(timelabel.Text) == 0)
                if (check() == 1)
                { labSucces.Text = "Succes!"; labSucces.BackColor = Color.Green; }
                else if (check() == 2)
                { labSucces.Text = "Invalid data."; labSucces.BackColor = Color.Blue; }
                else
                { labSucces.Text = "Try Again!"; labSucces.BackColor = Color.Blue; }

        }

        private void Termina_Click(object sender, EventArgs e)
        {
            i = 2;

            if (check() == 1 && i>=1)
            { labSucces.Text = "Succes!"; labSucces.BackColor = Color.Green; }
            else if (check() == 2)
            { labSucces.Text = "Invalid data."; labSucces.BackColor = Color.Blue; }
            else
            { labSucces.Text = "Try Again!"; labSucces.BackColor = Color.Blue; }
            button1.BringToFront();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Finish.PerformClick();
        }
    }
}
