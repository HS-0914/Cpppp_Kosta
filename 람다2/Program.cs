using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 람다2
{
    class Program
    {
        delegate int CalDel(int x, int y);
        //static int Plus(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            //int sum = Plus(10, 20);

            // 람다식 : (인수) => 표현식

            CalDel d = delegate (int x, int y) { return x + y; };
            int sum = d(10, 20);
            Console.WriteLine(sum);
        }
    }
}
