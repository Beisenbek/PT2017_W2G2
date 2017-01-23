using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Complex
    {
        public double A { get; set; }
        public double B { get; set; }
        public static Complex operator +(Complex l, Complex r)
        {
            Complex res = new Complex();
            res.A = l.A + r.A;
            res.B = l.B + r.B;
            return res;
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", A, B);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex { A = 1, B = 1 };
            Complex b = new Complex { A = 2, B = 4 };
            Console.WriteLine(c + b);
        }
    }
}
