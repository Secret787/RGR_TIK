using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGR_TIK
{
    internal class MyVector
    {
        private double[] _values;
        public int Size => _values.Length;

        public double this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public MyVector(int size) { _values = new double[size]; }

        public MyVector(params double[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            _values = values;
        }
        public static MyVector GenVector(int a)
        {
            double[] GenV = new double[a];
            for (int i = 0; i < a; i++)
                GenV[i] = 0;
            return new MyVector(GenV);
        }
        public static MyVector RevVector(MyVector a)
        {
            MyVector temp = GenVector(a.Size);
            for (int i = a.Size - 1; i >= 0; i--)
            {
                temp[i] = a[a.Size - 1 - i];
            }
            return temp;
        }
        public static int Sum(MyVector a)
        {
            int result = 0;
            for (int i = 0; i < a.Size; i++)
                result += (int)a[i];
            return result % 2;
        }
        public override string ToString() { return $"{string.Join(" ", _values)}".Replace(" ", ""); }
        public string PrintVector() { return $"{string.Join("    ", _values)}"; }
    }
}
