namespace My.Calculator
{
    partial class Form_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SidePanel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculator1 = new My.Calculator.Calculator();
            this.quiz1 = new My.Calculator.Quiz();
            this.numarPrim1 = new My.Calculator.NumarPrim();
            this.graph1 = new My.Calculator.Graph();
            this.credits1 = new My.Calculator.Credits();
            this.area1 = new My.Calculator.Area();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.SidePanel2);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 541);
            this.panel1.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 76);
            this.button8.TabIndex = 25;
            this.button8.Text = "             Area";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 76);
            this.button7.TabIndex = 24;
            this.button7.Text = "             Menu";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 76);
            this.button2.TabIndex = 23;
            this.button2.Text = "             Quiz";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 76);
            this.button1.TabIndex = 22;
            this.button1.Text = "             Prime";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 453);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 76);
            this.button6.TabIndex = 21;
            this.button6.Text = "             Graph";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 76);
            this.button5.TabIndex = 20;
            this.button5.Text = "             Calculator";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(125, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 42);
            this.button4.TabIndex = 19;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(65, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 42);
            this.button3.TabIndex = 18;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Transparent;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 42);
            this.button13.TabIndex = 17;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // SidePanel2
            // 
            this.SidePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SidePanel2.Location = new System.Drawing.Point(0, 82);
            this.SidePanel2.Name = "SidePanel2";
            this.SidePanel2.Size = new System.Drawing.Size(10, 70);
            this.SidePanel2.TabIndex = 16;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SidePanel.Location = new System.Drawing.Point(0, 450);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 70);
            this.SidePanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(190, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 23);
            this.panel3.TabIndex = 20;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(190, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 50);
            this.panel2.TabIndex = 27;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.Color.Silver;
            this.calculator1.Location = new System.Drawing.Point(190, 20);
            this.calculator1.Name = "calculator1";
            this.calculator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calculator1.Size = new System.Drawing.Size(686, 476);
            this.calculator1.TabIndex = 22;
            // 
            // quiz1
            // 
            this.quiz1.BackColor = System.Drawing.Color.Silver;
            this.quiz1.Location = new System.Drawing.Point(190, 20);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(686, 476);
            this.quiz1.TabIndex = 26;
            // 
            // numarPrim1
            // 
            this.numarPrim1.BackColor = System.Drawing.Color.Silver;
            this.numarPrim1.Location = new System.Drawing.Point(190, 20);
            this.numarPrim1.Name = "numarPrim1";
            this.numarPrim1.Size = new System.Drawing.Size(686, 476);
            this.numarPrim1.TabIndex = 25;
            // 
            // graph1
            // 
            this.graph1.BackColor = System.Drawing.Color.Black;
            this.graph1.Location = new System.Drawing.Point(190, 20);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(686, 476);
            this.graph1.TabIndex = 24;
            // 
            // credits1
            // 
            this.credits1.BackColor = System.Drawing.Color.Silver;
            this.credits1.Location = new System.Drawing.Point(190, 20);
            this.credits1.Name = "credits1";
            this.credits1.Size = new System.Drawing.Size(686, 484);
            this.credits1.TabIndex = 23;
            // 
            // area1
            // 
            this.area1.BackColor = System.Drawing.Color.Black;
            this.area1.Location = new System.Drawing.Point(190, 20);
            this.area1.Name = "area1";
            this.area1.Size = new System.Drawing.Size(686, 476);
            this.area1.TabIndex = 28;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.area1);
            this.Controls.Add(this.calculator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quiz1);
            this.Controls.Add(this.numarPrim1);
            this.Controls.Add(this.graph1);
            this.Controls.Add(this.credits1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel SidePanel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Calculator calculator1;
        private Credits credits1;
        private Graph graph1;
        private NumarPrim numarPrim1;
        private Quiz quiz1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private Area area1;
    }
}

