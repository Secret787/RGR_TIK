namespace RGR_TIK
{
    public class Sym
    {
        static bool b = false;

        public struct Symbol
        {
            
            public Symbol(string name, double probability)
            {
                _name = name;
                _probability = probability;
            }

            public void SetLogValue(int logValue)
            {
                _logValue = logValue;
            }

            public void SetCode(string code)
            {
                _code = code;
            }

            public string _name { get; set; }
            public double _probability { get; set; }
            public string _code { get; set; }
            public int _logValue { get; set; }
        }

        public List<Symbol> Message;

        public Dictionary<char, double> letterProbability;

        public void Fill(object sender, EventArgs e, String tb, DataGridView Grid)
        {
            b = true;
            string inputText = tb;



            // Создать словарь для хранения вероятности каждой буквы
            letterProbability = new();
            Message = new();

            // Подсчитать вероятность каждой буквы
            Symbol_probabilities(inputText);

            // Очистите DataGridView
           

            GenerateCode(Message);
            Grid.Rows.Clear();

            // Заполните DataGridView с P(xi) в виде десятичных дробей с двумя знаками после запятой
            for (int i = 0; i < Message.Count; i++)
            {
                Grid.Rows.Add(Message[i]._name, Math.Round(Message[i]._probability, 2), Message[i]._code);
                Symbol s = Message[i];
                if (Message[i]._name == "Пробел") { s._name = " "; Message[i] = s; }

                // Используем Math.Round для округления значения до 2 знаков после запятой
            }
        }

        public void Symbol_probabilities(string inputText)
        {
            int totalCharacters = inputText.Length;

            foreach (char character in inputText)
            {
                if (letterProbability.ContainsKey(character)) { letterProbability[character] += 1.0 / totalCharacters; }
                else { letterProbability[character] = 1.0 / totalCharacters; }
            }

            letterProbability = letterProbability.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            for (int i = letterProbability.Count - 1; i >= 0; i--)
            {
                Message.Add(new Symbol(letterProbability.First(x => x.Value == letterProbability.Values.Max()).Key.ToString(), letterProbability.First(x => x.Value == letterProbability.Values.Max()).Value));
                letterProbability.Remove(letterProbability.First(x => x.Value == letterProbability.Values.Max()).Key);
            }


        }
        public void GenerateCode(List<Symbol> M)
        {
            //List<Symbol> Temp = new List<Symbol>();
            //Copy(Temp, M);
            //double m1, m2; ;
            //string k1, k2;
            //Symbol s = new Symbol("", new double());

            //while (Temp.Count > 1)
            //{
            //    m1 = min(Temp)._probability;
            //    k1 = min(Temp)._name;
            //    Temp.Remove(min(Temp));
            //    m2 = min(Temp)._probability;
            //    k2 = min(Temp)._name;
            //    Add_code(M, k1, "1");
            //    Add_code(M, k2, "0");
            //    Temp.Remove(min(Temp));
            //    Temp.Add(new Symbol(k1 + k2, m1 + m2));
            //}

            double previousQi = 0;
            double previousVar = 0;

            Symbol s = new Symbol("", new double());

            for (int i = 0; i < M.Count; i++)
            {
                s = M[i];
                double probability = M[i]._probability;
                double qi = previousQi + previousVar;
                qi = Math.Round(qi, 2);
                double logValue = -Math.Log(probability, 2);
                int log = (int)Math.Ceiling(logValue);
                s._logValue = log;
                s._code = ConvertTo2(qi.ToString(), Convert.ToInt32(log));

                previousQi = qi;
                previousVar = probability;

                M[i] = s;
            }

            //Reverse(Message);

        }

        public string ConvertTo2(string num, int round = 5)
        {
            string result = "";
            string right = "0";
            string[] temp1 = num.Split(new char[] { ',' });

            if (temp1.Length > 1)
            {
                right = temp1[1];
            }

            if (Int32.TryParse(right, out int INTright))
            {
                for (int i = 0; i < round; i++)
                {
                    INTright = INTright * 2;
                    if (INTright.ToString().Length > right.Length)
                    {
                        string buf = INTright.ToString();
                        buf = buf.Remove(0, 1);
                        INTright = Convert.ToInt32(buf);

                        result += '1';
                    }
                    else
                    {
                        result += '0';
                    }
                }
            }

            return result;
        }

        public Symbol min(List<Symbol> Temp)
        {
            Symbol s = new Symbol("1", double.MaxValue);
            foreach (var _symbol in Temp) { if (_symbol._probability < s._probability) { s = _symbol; } }
            return s;
        }
        public int Find_Name(List<Symbol> Temp, string name)
        {
            int s = 0;
            int index = 0;
            foreach (var _symbol in Temp) { if (_symbol._name == name) { s = index; } index++; }
            return s;
        }
        public int Find_Code(List<Symbol> Temp, string code)
        {
            int s = 0;
            int index = 0;
            foreach (var _symbol in Temp) { if (_symbol._code == code) { s = index; } index++; }
            return s;
        }
        public void Copy(List<Symbol> T, List<Symbol> M)
        {
            Symbol s = new Symbol("", new double());

            for (int i = 0; i < M.Count; i++)
            {
                s._name = M[i]._name;
                s._probability = M[i]._probability;
                s._code = M[i]._code;
                T.Add(s);
            }
        }
        public void Add_code(List<Symbol> M, string s1, string code)
        {
            Symbol s = new Symbol("", new double());
            string[] str = new string[s1.Length];
            int k = s1.Length;
            for (int i = 0; i < k; i++)
            {
                str[i] = s1.Substring(0, 1);
                s1 = s1.Remove(0, 1);
                s = M[Find_Name(M, str[i])];
                s._code += code;
                M[Find_Name(M, str[i])] = s;
            }

        }
        public void Reverse(List<Symbol> M)
        {
            Symbol s = new Symbol("", new double());
           
            for (int i = 0; i < M.Count; i++)
            {
                s = M[i];
                if (M[i]._name == " ") { s._name = "Пробел"; }

                if (M.Count == 1)
                {
                    s._code = "1";
                }
                else
                {
                    char[] arr = s._code.ToCharArray();
                    Array.Reverse(arr);
                    s._code = new string(arr);
                }
                    
                M[i] = s;
            }
        }

        public int MaxCodeLen(List<Symbol> Temp)
        {
            Symbol s = new Symbol("1", double.MaxValue);
            s._code = "";
            foreach (var _symbol in Temp) { if (_symbol._code.Length > s._code.Length) { s._code = _symbol._code; } }
            return s._code.Length;
        }
        string tbd = "";
        string Dec = "";
        public string Decode_Click(object sender, EventArgs e, String tbd)
        {
          
            Dec = "";
            string[] str = new string[tbd.Length];
            string s1 = tbd;
            string s2 = tbd;
            int j = MaxCodeLen(Message);

            for (int i = 0; i < tbd.Length && s1.Length > 0; i++)
            {
                if (s1.Length >= j)
                {
                    if (j > 0)
                    {
                        str[i] = s1.Substring(0, j);
                        if (Message[Find_Code(Message, str[i])]._code.ToString() == str[i].ToString() && s1.Length >= j)
                        {
                            Dec += Message[Find_Code(Message, str[i])]._name.ToString();
                            s1 = s1.Remove(0, j);
                            j = MaxCodeLen(Message);
                        }
                        else
                        {
                            j--;
                            i--;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные переданы с ошибкой");
                        break;
                    }
                }
                else
                {
                    j--;
                    i--;

                }

            }
            textBox2 = Dec;
            return textBox2;
        }
        String textBox2 = "";
        String textBox1 = "";

        String Zac = "";

        public String Zacod_Click(object sender, EventArgs e, String tb, DataGridView dgv)
        {
            
            Fill(sender, e, tb, dgv);
            Zac = "";
            string[] str = new string[tb.Length];
            string s1 = tb;
            for (int i = 0; i < tb.Length; i++)
            {
                str[i] = s1.Substring(0, 1);
                Zac += Message[Find_Name(Message, str[i])]._code.ToString();
                s1 = s1.Remove(0, 1);
            }
            textBox1 = Zac;

            return textBox1;
        }
    }
}
