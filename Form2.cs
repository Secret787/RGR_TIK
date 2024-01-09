using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RGR_TIK.MyVector;
using static RGR_TIK.Matrix;
using static RGR_TIK.Sym;
using static RGR_TIK.Huf;
using static RGR_TIK.Form1;
using static RGR_TIK.ApplicationConfiguration;



namespace RGR_TIK
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            textBox3.ScrollBars = ScrollBars.Vertical;
        }

        private void get2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = h.textBox3;
            textBox4.Text = h.textBox4;
            textBox5.Text = cut(textBox4.Text);
        }
        private string cut(string s)
        {
            if (s[s.Length - 1] == '1')
                s=s.Remove(s.Length - 1);
            else
            {
                while (s[s.Length - 1] != '1')
                    s = s.Remove(s.Length - 1);
                s = s.Remove(s.Length - 1);

            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox5
            textBox1.Text = s.Decode_Click(sender, e, textBox5.Text);
        }
    }
}
