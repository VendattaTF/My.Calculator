namespace My.Calculator
{
    partial class Quiz
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.labSucces = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button_Finish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labSucces
            // 
            this.labSucces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSucces.ForeColor = System.Drawing.Color.White;
            this.labSucces.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labSucces.Location = new System.Drawing.Point(227, 302);
            this.labSucces.Name = "labSucces";
            this.labSucces.Size = new System.Drawing.Size(265, 45);
            this.labSucces.TabIndex = 53;
            this.labSucces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(392, 233);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 52;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(392, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(392, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(392, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(369, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "=";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(369, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(369, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(369, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "=";
            // 
            // lab8
            // 
            this.lab8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab8.Location = new System.Drawing.Point(327, 235);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(36, 18);
            this.lab8.TabIndex = 44;
            this.lab8.Text = "1";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(284, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "%";
            // 
            // lab7
            // 
            this.lab7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab7.Location = new System.Drawing.Point(242, 235);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(47, 18);
            this.lab7.TabIndex = 42;
            this.lab7.Text = "1";
            // 
            // lab6
            // 
            this.lab6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab6.Location = new System.Drawing.Point(327, 201);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(36, 18);
            this.lab6.TabIndex = 41;
            this.lab6.Text = "1";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(284, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "*";
            // 
            // lab5
            // 
            this.lab5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab5.Location = new System.Drawing.Point(243, 201);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(46, 18);
            this.lab5.TabIndex = 39;
            this.lab5.Text = "1";
            // 
            // lab4
            // 
            this.lab4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab4.Location = new System.Drawing.Point(327, 173);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(36, 18);
            this.lab4.TabIndex = 38;
            this.lab4.Text = "1";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(284, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "-";
            // 
            // lab3
            // 
            this.lab3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab3.Location = new System.Drawing.Point(242, 173);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(47, 18);
            this.lab3.TabIndex = 36;
            this.lab3.Text = "1";
            // 
            // lab2
            // 
            this.lab2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab2.Location = new System.Drawing.Point(327, 140);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(36, 18);
            this.lab2.TabIndex = 35;
            this.lab2.Text = "1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(284, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "+";
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1.Location = new System.Drawing.Point(243, 140);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(46, 18);
            this.lab1.TabIndex = 33;
            this.lab1.Text = "1";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(387, 91);
            this.seconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(93, 26);
            this.seconds.TabIndex = 32;
            this.seconds.Text = "seconds";
            // 
            // timelabel
            // 
            this.timelabel.BackColor = System.Drawing.Color.Transparent;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.timelabel.Location = new System.Drawing.Point(346, 91);
            this.timelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(37, 26);
            this.timelabel.TabIndex = 31;
            this.timelabel.Text = "60";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLabel.Location = new System.Drawing.Point(241, 91);
            this.TimeLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(101, 26);
            this.TimeLeftLabel.TabIndex = 30;
            this.TimeLeftLabel.Text = "Time left:";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(3, 440);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 33);
            this.button13.TabIndex = 56;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button_Finish
            // 
            this.button_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_Finish.FlatAppearance.BorderSize = 0;
            this.button_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Finish.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Finish.ForeColor = System.Drawing.Color.White;
            this.button_Finish.Location = new System.Drawing.Point(231, 267);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(261, 32);
            this.button_Finish.TabIndex = 58;
            this.button_Finish.Text = "Finish";
            this.button_Finish.UseVisualStyleBackColor = false;
            this.button_Finish.Click += new System.EventHandler(this.Termina_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(231, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 154);
            this.label6.TabIndex = 59;
            this.label6.Text = "Quiz";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.labSucces);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.TimeLeftLabel);
            this.Name = "Quiz";
            this.Size = new System.Drawing.Size(686, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labSucces;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}
