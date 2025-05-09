using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트
{
    class Program
    {
        delegate void CalcDel(int x, int y);
        static void Plus(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiple(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main(string[] args)
        {
            /*
            //CalcDel del1 = new CalcDel(Plus); 위 아래 둘다 가능
            CalcDel del1 = Plus;
            int result1 = del1(10, 20);
            Console.WriteLine(result1);

            del1 = new CalcDel(Minus);
            result1 = del1(10, 20);
            Console.WriteLine(result1);
            */

            CalcDel del1 = Plus;
            CalcDel del2 = Minus;
            CalcDel del3 = Multiple;
            CalcDel del4 = Divide;

            del1 += del2;
            del1 += del3;
            del1 += del4;

            del1(20, 10);

            del1 -= del2;
            del1(20, 10);

            del1 -= del2;
            del1(20, 10);

        }
    }
}
