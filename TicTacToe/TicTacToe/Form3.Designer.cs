﻿namespace TicTacToe
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            square9 = new Button();
            square8 = new Button();
            square7 = new Button();
            square6 = new Button();
            square5 = new Button();
            square4 = new Button();
            square3 = new Button();
            square2 = new Button();
            square1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button4 = new Button();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            button2.Location = new Point(542, 549);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 7;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(78, 49, 170);
            button1.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            button1.Location = new Point(12, 549);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 8;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            button3.Location = new Point(400, 549);
            button3.Name = "button3";
            button3.Size = new Size(120, 50);
            button3.TabIndex = 25;
            button3.Text = "RESET";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 15, 15);
            label6.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ScrollBar;
            label6.Location = new Point(448, 45);
            label6.Name = "label6";
            label6.Size = new Size(34, 36);
            label6.TabIndex = 31;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 15, 15);
            label5.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(324, 45);
            label5.Name = "label5";
            label5.Size = new Size(34, 36);
            label5.TabIndex = 30;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 15, 15);
            label4.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(202, 45);
            label4.Name = "label4";
            label4.Size = new Size(34, 36);
            label4.TabIndex = 29;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 15, 15);
            label3.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(392, 11);
            label3.Name = "label3";
            label3.Size = new Size(186, 36);
            label3.TabIndex = 28;
            label3.Text = "Player(O)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 15, 15);
            label2.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(312, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 36);
            label2.TabIndex = 27;
            label2.Text = "Tie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 15, 15);
            label1.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 11);
            label1.Name = "label1";
            label1.Size = new Size(186, 36);
            label1.TabIndex = 26;
            label1.Text = "Player(X)";
            // 
            // square9
            // 
            square9.BackColor = Color.Transparent;
            square9.FlatAppearance.BorderSize = 0;
            square9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square9.FlatStyle = FlatStyle.Flat;
            square9.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square9.ForeColor = Color.White;
            square9.Location = new Point(410, 335);
            square9.Name = "square9";
            square9.Size = new Size(115, 115);
            square9.TabIndex = 40;
            square9.UseVisualStyleBackColor = false;
            // 
            // square8
            // 
            square8.BackColor = Color.Transparent;
            square8.FlatAppearance.BorderSize = 0;
            square8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square8.FlatStyle = FlatStyle.Flat;
            square8.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square8.ForeColor = Color.White;
            square8.Location = new Point(290, 335);
            square8.Name = "square8";
            square8.Size = new Size(110, 115);
            square8.TabIndex = 39;
            square8.UseVisualStyleBackColor = false;
            // 
            // square7
            // 
            square7.BackColor = Color.Transparent;
            square7.FlatAppearance.BorderSize = 0;
            square7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square7.FlatStyle = FlatStyle.Flat;
            square7.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square7.ForeColor = Color.White;
            square7.Location = new Point(165, 335);
            square7.Name = "square7";
            square7.Size = new Size(115, 115);
            square7.TabIndex = 38;
            square7.UseVisualStyleBackColor = false;
            // 
            // square6
            // 
            square6.BackColor = Color.Transparent;
            square6.FlatAppearance.BorderSize = 0;
            square6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square6.FlatStyle = FlatStyle.Flat;
            square6.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square6.ForeColor = Color.White;
            square6.Location = new Point(410, 215);
            square6.Name = "square6";
            square6.Size = new Size(115, 110);
            square6.TabIndex = 37;
            square6.UseVisualStyleBackColor = false;
            // 
            // square5
            // 
            square5.BackColor = Color.Transparent;
            square5.FlatAppearance.BorderSize = 0;
            square5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square5.FlatStyle = FlatStyle.Flat;
            square5.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square5.ForeColor = Color.White;
            square5.Location = new Point(290, 215);
            square5.Name = "square5";
            square5.Size = new Size(110, 110);
            square5.TabIndex = 36;
            square5.UseVisualStyleBackColor = false;
            // 
            // square4
            // 
            square4.BackColor = Color.Transparent;
            square4.FlatAppearance.BorderSize = 0;
            square4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square4.FlatStyle = FlatStyle.Flat;
            square4.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square4.ForeColor = Color.White;
            square4.Location = new Point(165, 215);
            square4.Name = "square4";
            square4.Size = new Size(115, 110);
            square4.TabIndex = 35;
            square4.UseVisualStyleBackColor = false;
            // 
            // square3
            // 
            square3.BackColor = Color.Transparent;
            square3.FlatAppearance.BorderSize = 0;
            square3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square3.FlatStyle = FlatStyle.Flat;
            square3.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square3.ForeColor = Color.White;
            square3.Location = new Point(410, 90);
            square3.Name = "square3";
            square3.Size = new Size(115, 115);
            square3.TabIndex = 34;
            square3.UseVisualStyleBackColor = false;
            // 
            // square2
            // 
            square2.BackColor = Color.Transparent;
            square2.FlatAppearance.BorderSize = 0;
            square2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square2.FlatStyle = FlatStyle.Flat;
            square2.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square2.ForeColor = Color.White;
            square2.Location = new Point(290, 90);
            square2.Name = "square2";
            square2.Size = new Size(110, 115);
            square2.TabIndex = 33;
            square2.UseVisualStyleBackColor = false;
            // 
            // square1
            // 
            square1.BackColor = Color.Transparent;
            square1.FlatAppearance.BorderSize = 0;
            square1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            square1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            square1.FlatStyle = FlatStyle.Flat;
            square1.Font = new Font("Fixedsys Excelsior 3.01", 96F, FontStyle.Bold);
            square1.ForeColor = Color.White;
            square1.Location = new Point(165, 90);
            square1.Name = "square1";
            square1.Size = new Size(115, 115);
            square1.TabIndex = 32;
            square1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 15, 15);
            label9.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(249, 555);
            label9.Name = "label9";
            label9.Size = new Size(53, 36);
            label9.TabIndex = 44;
            label9.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 15, 15);
            label8.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(327, 555);
            label8.Name = "label8";
            label8.Size = new Size(53, 36);
            label8.TabIndex = 43;
            label8.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 15, 15);
            label7.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(147, 555);
            label7.Name = "label7";
            label7.Size = new Size(110, 36);
            label7.TabIndex = 42;
            label7.Text = "Time:";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            button4.Location = new Point(247, 480);
            button4.Name = "button4";
            button4.Size = new Size(192, 50);
            button4.TabIndex = 41;
            button4.Text = "CONTINUE";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(15, 15, 15);
            label10.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(296, 555);
            label10.Name = "label10";
            label10.Size = new Size(34, 36);
            label10.TabIndex = 45;
            label10.Text = ":";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(674, 611);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(square9);
            Controls.Add(square8);
            Controls.Add(square7);
            Controls.Add(square6);
            Controls.Add(square5);
            Controls.Add(square4);
            Controls.Add(square3);
            Controls.Add(square2);
            Controls.Add(square1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form3";
            Text = "2 Players Tic Tac Toe";
            Load += Form3_Load;
            Paint += Form3_Paint_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button square9;
        private Button square8;
        private Button square7;
        private Button square6;
        private Button square5;
        private Button square4;
        private Button square3;
        private Button square2;
        private Button square1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button4;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}