namespace app2
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
            number2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            number1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // number2
            // 
            number2.BackColor = SystemColors.ButtonHighlight;
            number2.Font = new Font("Sitka Small", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point);
            number2.Location = new Point(256, 197);
            number2.Name = "number2";
            number2.Size = new Size(245, 36);
            number2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(72, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Add +";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(189, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "sub -";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(297, 276);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Mul *";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(415, 276);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "div /";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // number1
            // 
            number1.BackColor = SystemColors.ButtonHighlight;
            number1.Font = new Font("Sitka Small", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point);
            number1.Location = new Point(256, 133);
            number1.Name = "number1";
            number1.Size = new Size(245, 36);
            number1.TabIndex = 7;
            number1.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(256, 36);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 8;
            label1.Text = "simple calculetor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 146);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 9;
            label2.Text = "Enter First Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 208);
            label3.Name = "label3";
            label3.Size = new Size(195, 23);
            label3.TabIndex = 10;
            label3.Text = "Enter Second Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(number1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(number2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox number2;
        private TextBox number1;
    }
}