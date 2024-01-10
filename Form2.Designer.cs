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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 142);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 202);
            textBox3.TabIndex = 10;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 23);
            textBox5.TabIndex = 12;
            // 
            // get2
            // 
            get2.Location = new Point(12, 10);
            get2.Name = "get2";
            get2.Size = new Size(450, 23);
            get2.TabIndex = 13;
            get2.Text = "Получить Сообщение";
            get2.UseVisualStyleBackColor = true;
            get2.Click += get2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 23);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(12, 394);
            button1.Name = "button1";
            button1.Size = new Size(450, 23);
            button1.TabIndex = 15;
            button1.Text = "Расшифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 34;
            label3.Text = "Сообщение, закодированное методом Хэмминга";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 80);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 35;
            label1.Text = "Сообщение, закодированное методом Шеннона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 36);
            label2.Name = "label2";
            label2.Size = new Size(334, 15);
            label2.TabIndex = 36;
            label2.Text = "Сообщение, закодированное методом Шеннона, кратное 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 347);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 37;
            label4.Text = "Расшифрованное сообщение";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 429);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
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
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}