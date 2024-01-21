namespace RGR_TIK
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
            tb = new TextBox();
            Zacod = new Button();
            textBox1 = new TextBox();
            Grid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dgv1 = new DataGridView();
            textBox2 = new TextBox();
            perevod = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(13, 11);
            tb.Margin = new Padding(2);
            tb.Name = "tb";
            tb.Size = new Size(358, 23);
            tb.TabIndex = 14;
            // 
            // Zacod
            // 
            Zacod.Location = new Point(13, 38);
            Zacod.Margin = new Padding(2);
            Zacod.Name = "Zacod";
            Zacod.Size = new Size(358, 25);
            Zacod.TabIndex = 23;
            Zacod.Text = "Кодирование Хаффман + Хэмминг";
            Zacod.UseVisualStyleBackColor = true;
            Zacod.Click += Zacod_Click2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 82);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 23);
            textBox1.TabIndex = 24;
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5 });
            Grid.Location = new Point(383, 11);
            Grid.Margin = new Padding(2);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 72;
            Grid.RowTemplate.Height = 37;
            Grid.Size = new Size(553, 392);
            Grid.TabIndex = 26;
            // 
            // Column1
            // 
            Column1.HeaderText = "Буква xi";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Column3
            // 
            Column3.HeaderText = "Вероятность Pi";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "Код wi";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column4
            // 
            Column4.HeaderText = "Длина кода li";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.HeaderText = "li*Pi";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            Column5.Width = 175;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(11, 167);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(358, 207);
            dgv1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 124);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 23);
            textBox2.TabIndex = 29;
            // 
            // perevod
            // 
            perevod.Location = new Point(10, 380);
            perevod.Name = "perevod";
            perevod.Size = new Size(357, 23);
            perevod.TabIndex = 30;
            perevod.Text = "Отправка сообщения";
            perevod.UseVisualStyleBackColor = true;
            perevod.Click += perevod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 65);
            label1.Name = "label1";
            label1.Size = new Size(283, 15);
            label1.TabIndex = 31;
            label1.Text = "Сообщение, закодированное методом Хаффмана";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(342, 15);
            label2.TabIndex = 32;
            label2.Text = "Сообщение, закодированное методом Хаффмана, кратное 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 149);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 33;
            label3.Text = "Сообщение, закодированное методом Хэмминга";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 417);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(perevod);
            Controls.Add(textBox2);
            Controls.Add(dgv1);
            Controls.Add(Grid);
            Controls.Add(textBox1);
            Controls.Add(Zacod);
            Controls.Add(tb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private Button Zacod;
        private TextBox textBox1;
        private DataGridView Grid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dgv1;
        private TextBox textBox2;
        private Button perevod;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}