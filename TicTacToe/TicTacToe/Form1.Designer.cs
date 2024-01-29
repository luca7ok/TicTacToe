namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(78, 49, 170);
            button1.Font = new Font("Fixedsys Excelsior 3.01", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(248, 459);
            button1.Name = "button1";
            button1.Size = new Size(186, 64);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Fixedsys Excelsior 3.01", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(128, 314);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(142, 32);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "1 Player";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Fixedsys Excelsior 3.01", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(397, 314);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(156, 32);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "2 Players";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(397, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fixedsys Excelsior 3.01", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(188, 48);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 5;
            label1.Text = "Tic Tac Toe";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Fixedsys Excelsior 3.01", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(542, 549);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 6;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(674, 611);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button2;
    }
}
