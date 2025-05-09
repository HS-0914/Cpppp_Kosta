using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콜백메소드
{
    class Program
    {
        delegate void CalcDel(int x, int y);

        static void Event(int x, int y, CalcDel dele)
        {
            dele(x, y);
        }

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
            CalcDel plus = Plus;
            CalcDel minus = Minus;
            CalcDel multiple = Multiple;
            CalcDel divide = Divide;


            plus(20, 10);
        }
    }
}
