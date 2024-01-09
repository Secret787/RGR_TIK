namespace RGR_TIK
{
    partial class Form2
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            get2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 12);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 459);
            textBox3.TabIndex = 10;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 17);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(338, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 23);
            textBox5.TabIndex = 12;
            // 
            // get2
            // 
            get2.Location = new Point(338, 75);
            get2.Name = "get2";
            get2.Size = new Size(450, 23);
            get2.TabIndex = 13;
            get2.Text = "Получить";
            get2.UseVisualStyleBackColor = true;
            get2.Click += get2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 23);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(338, 133);
            button1.Name = "button1";
            button1.Size = new Size(450, 23);
            button1.TabIndex = 15;
            button1.Text = "Раскодировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(get2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button get2;
        private TextBox textBox1;
        private Button button1;
    }
}