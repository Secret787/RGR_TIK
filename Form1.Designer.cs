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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Hmax = new Label();
            Hx = new Label();
            Lmid = new Label();
            pk = new Label();
            R = new Label();
            VecCraft = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(583, 11);
            tb.Margin = new Padding(2);
            tb.Name = "tb";
            tb.Size = new Size(343, 23);
            tb.TabIndex = 14;
            // 
            // Zacod
            // 
            Zacod.Location = new Point(583, 38);
            Zacod.Margin = new Padding(2);
            Zacod.Name = "Zacod";
            Zacod.Size = new Size(343, 25);
            Zacod.TabIndex = 23;
            Zacod.Text = "Кодирование Шеннон + Хэмминг";
            Zacod.UseVisualStyleBackColor = true;
            Zacod.Click += Zacod_Click2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 82);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 23);
            textBox1.TabIndex = 24;
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5 });
            Grid.Location = new Point(11, 11);
            Grid.Margin = new Padding(2);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 72;
            Grid.RowTemplate.Height = 37;
            Grid.Size = new Size(553, 485);
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
            dgv1.Location = new Point(583, 167);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(341, 207);
            dgv1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(583, 124);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 23);
            textBox2.TabIndex = 29;
            // 
            // perevod
            // 
            perevod.Location = new Point(583, 380);
            perevod.Name = "perevod";
            perevod.Size = new Size(339, 23);
            perevod.TabIndex = 30;
            perevod.Text = "Отправка сообщения";
            perevod.UseVisualStyleBackColor = true;
            perevod.Click += perevod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(583, 65);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 31;
            label1.Text = "Сообщение, закодированное методом Шеннона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 107);
            label2.Name = "label2";
            label2.Size = new Size(334, 15);
            label2.TabIndex = 32;
            label2.Text = "Сообщение, закодированное методом Шеннона, кратное 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 149);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 33;
            label3.Text = "Сообщение, закодированное методом Хэмминга";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(624, 406);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 34;
            label4.Text = "H(max) = ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(641, 421);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 35;
            label5.Text = "H(x) = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(645, 436);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 36;
            label6.Text = "Lср = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 451);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 37;
            label7.Text = "pk = ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(657, 466);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 38;
            label8.Text = "R = ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(583, 481);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 39;
            label9.Text = "Вектор Крафта = ";
            // 
            // Hmax
            // 
            Hmax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hmax.AutoSize = true;
            Hmax.Location = new Point(691, 406);
            Hmax.Name = "Hmax";
            Hmax.Size = new Size(52, 15);
            Hmax.TabIndex = 40;
            Hmax.Text = "_________";
            // 
            // Hx
            // 
            Hx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Hx.AutoSize = true;
            Hx.Location = new Point(691, 421);
            Hx.Name = "Hx";
            Hx.Size = new Size(52, 15);
            Hx.TabIndex = 41;
            Hx.Text = "_________";
            // 
            // Lmid
            // 
            Lmid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lmid.AutoSize = true;
            Lmid.Location = new Point(691, 436);
            Lmid.Name = "Lmid";
            Lmid.Size = new Size(52, 15);
            Lmid.TabIndex = 42;
            Lmid.Text = "_________";
            // 
            // pk
            // 
            pk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pk.AutoSize = true;
            pk.Location = new Point(691, 451);
            pk.Name = "pk";
            pk.Size = new Size(52, 15);
            pk.TabIndex = 43;
            pk.Text = "_________";
            // 
            // R
            // 
            R.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            R.AutoSize = true;
            R.Location = new Point(691, 466);
            R.Name = "R";
            R.Size = new Size(52, 15);
            R.TabIndex = 44;
            R.Text = "_________";
            // 
            // VecCraft
            // 
            VecCraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VecCraft.AutoSize = true;
            VecCraft.Location = new Point(691, 481);
            VecCraft.Name = "VecCraft";
            VecCraft.Size = new Size(52, 15);
            VecCraft.TabIndex = 45;
            VecCraft.Text = "_________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 511);
            Controls.Add(VecCraft);
            Controls.Add(R);
            Controls.Add(pk);
            Controls.Add(Lmid);
            Controls.Add(Hx);
            Controls.Add(Hmax);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label Hmax;
        private Label Hx;
        private Label Lmid;
        private Label pk;
        private Label R;
        private Label VecCraft;
    }
}