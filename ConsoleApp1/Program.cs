using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            int sum = 0;

            while(sum < 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("합이 100을 넘는 최초의 수 = {0}", i);
            */
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 100까지의 합 = {0}", sum);
        }
    }
}
