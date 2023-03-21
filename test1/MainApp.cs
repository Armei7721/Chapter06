using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class MainApp
    {/*
        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
        */
        /*
        public static void Main()
        {
           double mean = 0;

            Mean(1, 2, 3, 4, 5,ref mean);
            
            Console.WriteLine("평균 : {0}", mean);
        }
        public static void Mean(double a, double b, double c, double d, double e,ref double mean)
        {
            mean = (a + b + c + d + e) / 5;

        }*/
        
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0}+{1}={2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0}+{1}={2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        public static double Plus(double a, double b, out double c)
        {
            c = a + b;
           return c;
        }
        
      
    }
}
