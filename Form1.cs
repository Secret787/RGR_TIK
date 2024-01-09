using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static RGR_TIK.MyVector;
using static RGR_TIK.Matrix;
using static RGR_TIK.Sym;
using static RGR_TIK.Huf;

namespace RGR_TIK
{
    public partial class Form1 : Form
    {
        public static Sym s = new Sym();
        public static Huf h = new Huf();

        public Form1()
        {
            
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                dgv1.Columns.Add("dgv2" + i, i.ToString());
                dgv1.Columns[i].Width = 40;
            }
        
            dgv1.RowHeadersVisible = false;
        }
        Form2 form2 = new Form2();
        public void Zacod_Click2(object sender, EventArgs e)
        {
            textBox1.Text = s.Zacod_Click(sender, e, tb.Text, Grid);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            h.button1_Click(sender, e, dgv1, textBox1.Text);
            textBox2.Text = h.textBox2;
        }
       
        private void perevod_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}