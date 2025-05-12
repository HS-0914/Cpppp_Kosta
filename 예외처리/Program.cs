using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외처리
{
    class Program
    {
        static int[] ar = { 1, 2, 3, 4, 5 };
        static int idx = 8;

        static public void Method1()
        {
            Method2();
        }
        static public void Method2()
        {
            Console.WriteLine(ar[idx]);
        }
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            catch(DivideByZeroException e)
            {

            }
            catch(Exception e)
            {

            }
        }
    }
}
