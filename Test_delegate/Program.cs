using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_delegate
{
    class Program
    {
        public delegate int M(int a, int b);
        static void Main(string[] args)
        {
            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());

            //M m = Pow;
            //m(A, B);
            M m = (a, b) => a + b;
            Console.WriteLine(m(5,4));


            Console.ReadLine();
        }
        private static void Pow(int a, int b)
        {
            Console.WriteLine(Convert.ToString(Math.Pow(a, b)));
        }
    }





}
