using System.Text.RegularExpressions;

using static RGR_TIK.MyVector;
using static RGR_TIK.Matrix;

namespace RGR_TIK
{
    public class Huf
    {
        public string textBox1 = "";
        public string textBox2 = "";
        public string textBox3 = "";
        public string textBox4 = "";
        public string textBox5 = "";
        string Gl = "";
        string Hl = "";


        public void button1_Click(object sender, EventArgs e, DataGridView dgv1, String textBox1)
        {
            Gl = "";
            Hl = "";

            var h1 = new MyVector(1, 1, 1, 0, 1, 0, 0);
            var h2 = new MyVector(1, 1, 0, 1, 0, 1, 0);
            var h3 = new MyVector(0, 1, 1, 1, 0, 0, 1);
            Matrix H = new Matrix(h1, h2, h3);

            var g1 = new MyVector(1, 0, 0, 0, 1, 1, 0);
            var g2 = new MyVector(0, 1, 0, 0, 1, 1, 1);
            var g3 = new MyVector(0, 0, 1, 0, 1, 0, 1);
            var g4 = new MyVector(0, 0, 0, 1, 0, 1, 1);
            Matrix G = new Matrix(g1, g2, g3, g4);

            Gl += "Матрица G \n";
            Gl += G.PrintMatrix();
            Hl += "Матрица H \n";
            Hl += H.PrintMatrix();

            if (textBox1 != string.Empty)
            {
                if ((4 - textBox1.Length % 4) != 0)
                {
                    int i = 0;
                    string s = "1";
                    while (i < (4 - textBox1.Length % 4 - 1))
                    {
                        s += "0";
                        i++;
                    }
                    textBox1 += s;
                }

                textBox2 = textBox1;
                MyVector[] byte4 = new MyVector[textBox1.Length / 4];
                dgvprint1(textBox1, byte4);
                dgvprint2(textBox1, byte4, G, dgv1);


                Tb3(textBox1, byte4, G, H);

            }
            else
            {
                MessageBox.Show("Данные не введены!");
            }
        }
        string ConvertToHexString(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++) { result += ($"{to2(Convert.ToString((long)s[i], 2))}"); }
            return result;
        }
        static string to2(string s)
        {
            while (s.Length < 16)
                s = s.Insert(0, "0");
            s = s.Insert(4, " ");
            s = s.Insert(9, " ");
            s = s.Insert(14, " ");
            return s;
        }
        void dgvprint1(string s, MyVector[] byte4)
        {
         
            int t = 0;
            for (int i = 0; i < s.Length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j  == 0)
                    {

                        byte4[i] = new MyVector
                            (Convert.ToInt32(s.Substring(j + 0 + i * 4, 1)),
                             Convert.ToInt32(s.Substring(j + 1 + i * 4, 1)),
                             Convert.ToInt32(s.Substring(j + 2 + i * 4, 1)),
                             Convert.ToInt32(s.Substring(j + 3 + i * 4, 1)));
                    }
                }
            }
        }
        void dgvprint2(string s, MyVector[] byte4, Matrix G, DataGridView dgv2)
        {
            Matrix C = new Matrix(byte4) * G;
            dgv2.Rows.Clear();
            int t = 0;
            for (int i = 0; i < s.Length / 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    t = (j / 7) + (i);
                    if (j % 7 == 0) { dgv2.Rows.Add(); }
                    dgv2.Rows[t].Cells[j % 7].Value = C[t][j % 7];
                }
                dgv2.Rows[(i) + 0].Cells[7].Value = Sum(C[(i) + 0]);
            
            }
        }

        void Tb3(string s, MyVector[] byte4, Matrix G, Matrix H)
        {
            Matrix C2 = new Matrix(byte4) * G;
            MyVector[] Res = new MyVector[C2.Size];
            Matrix byte8 = new Matrix(s.Length / 4);
            for (int i = 0; i < C2.Size; i++)
            {
                byte8[i] = new MyVector(
                    C2[i][0],
                    C2[i][1],
                    C2[i][2],
                    C2[i][3],
                    C2[i][4],
                    C2[i][5],
                    C2[i][6],
                    Sum(C2[i])
                    );
            }

            Random r = new Random();
            textBox3 = "";
            textBox4 = "";
            textBox5 = "";

            int t = 0;

            for (int i = 0; i < s.Length / 4; i++)
            {
                byte8[i] = Transfer(byte8[i]);

                Matrix Temp = new Matrix(byte8[i]);
                MyVector sindrom = (Temp * T(H))[0];
                int Bit = (int)Sum(new MyVector(byte8[i][0], byte8[i][1], byte8[i][2], byte8[i][3], byte8[i][4], byte8[i][5], byte8[i][6]));

                if (Bit == byte8[i][7] && sindrom.ToString() == "000")
                {
                    textBox3 += "Нету ошибок";
                }
                if (Bit != byte8[i][7] && sindrom.ToString() == "000")
                {
                    textBox3 += "Ошибка в бите четности";
                    byte8[i][7] = zero_one(byte8[i][7]);
                }
                if (Bit == byte8[i][7] && sindrom.ToString() != "000")
                {
                    t = find(H, sindrom);
                    textBox3 += $"Более одной ошибки";

                    byte8[i][t] = zero_one(byte8[i][t]);
                }
                if (Bit != byte8[i][7] && sindrom.ToString() != "000")
                {
                    t = find(H, sindrom);
                    textBox3 += $"Ошибка в бите номер {t}";
                    byte8[i][t] = zero_one(byte8[i][t]);
                }
                Res[i] = new MyVector(byte8[i][0], byte8[i][1], byte8[i][2], byte8[i][3]);
                textBox3 += Environment.NewLine;
                textBox3 += sindrom.PrintVector();
                textBox3 += Environment.NewLine;
                textBox3 += byte8[i].PrintVector();
                textBox3 += Environment.NewLine;

            }
            textBox4 += new Matrix(Res).ToString();
            textBox5 += ConvertToHexStringRev(textBox4);
        }
        string ConvertToHexStringRev(string s)
        {
            string result = "";
            long t = new long();
            string t2 = "";
            int k = 0;
            for (int i = 0; i < s.Length; i += 4)
            {
                k++;
                t = Convert.ToInt64((s.Substring(i, 4)), 2);
                t2 += Convert.ToString(t, 16);
                if (k % 4 == 0)
                {
                    result += Convert.ToChar(Regex.Unescape("\\u" + t2));
                    t2 = "";
                }
            }
            return result;
        }


        int find(Matrix H, MyVector B)
        {
            int math = 0;
            MyVector B2 = new MyVector();
            MyVector H2 = new MyVector();

            for (int i = 0; i < T(H).Size; i++)
            {
                B2 = B;
                H2 = T(H)[i];
                if (H2.ToString() == B2.ToString() && math == 0)
                    math = i;
            }
            return math;
        }
        MyVector Transfer(MyVector A)
        {
            Random r = new Random();
            int t = r.Next(1, 10);
            switch (t)
            {
                case 1:
                    int temp1 = r.Next(0, 7);
                    A[temp1] = zero_one(A[temp1]);
                    break;
                case 2:
                    int temp2 = r.Next(0, 7);
                    A[temp2] = zero_one(A[temp2]);
                    temp2 = r.Next(0, 7);
                    A[temp2] = zero_one(A[temp2]);
                    break;
                default:
                    break;
            }
            return A;
        }
        int zero_one(double num)
        {
            if (num == 0) return 1;
            else return 0;
        }
    }
}
