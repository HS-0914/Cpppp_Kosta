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

            /*
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 100까지의 합 = {0}", sum);
            */

            /*
            string str = Console.ReadLine();
            int dan = int.Parse(str);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }
            */

            /* foreach */
            int[,] ar = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 }; // 힙 메모리에 동적으로 할당
            int[] arr2 = { 1, 2, 3, 4, 5, 6 }; // 생략했지만 위에 new int[] 코드와 같다
        }
    }
}
