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
            h.button1_Click(sender, e, dgv1, textBox1.Text);
            textBox2.Text = h.textBox2;

            Hmax.Text = Math.Log2(s.Message.Count).ToString();
            Hx.Text = HxFunc(s.Message).ToString();
            Lmid.Text = LmidFunc(s.Message).ToString();
            pk.Text = (1 - HxFunc(s.Message) / LmidFunc(s.Message)).ToString();
            R.Text = (LmidFunc(s.Message) - HxFunc(s.Message)).ToString();
            VecCraft.Text = VecCraftFunc(s.Message).ToString();

            RoundTextBox(Hmax);
            RoundTextBox(Hx);
            RoundTextBox(Lmid);
            RoundTextBox(pk);
            RoundTextBox(R);
            RoundTextBox(VecCraft);
        }

        bool perevodNotOpend = true;
        private void perevod_Click(object sender, EventArgs e)
        {
            if (perevodNotOpend) 
            { 
                form2.Show();
                perevodNotOpend = false;
            }
            
        }

        void RoundTextBox(Label t)
        {
            t.Text = (Math.Round(Convert.ToDouble(t.Text), 4)).ToString();
        }

        double HxFunc(List<Symbol> M)
        {
            double res = 0;
            for (int i = 0; i < M.Count; i++) { res += M[i]._probability * Math.Log2(M[i]._probability); }
            return res * -1;
        }
        double LmidFunc(List<Symbol> M)
        {
            double res = 0;
            for (int i = 0; i < M.Count; i++) { res += M[i]._code.Length * M[i]._probability; }
            return res;
        }
        double VecCraftFunc(List<Symbol> M)
        {
            double res = 0;
            for (int i = 0; i < M.Count; i++) { res += Math.Pow(2, -(M[i]._code.Length)); }
            return res;
        }
    }
}