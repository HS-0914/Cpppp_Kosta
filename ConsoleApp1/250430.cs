using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _250430
    {
        class Shape
        {
            public virtual void GetArea()
            {
                Console.WriteLine("Shape의 GetArea");
            }
        }

        class Circle : Shape
        {
            private int r;
            internal Circle(int r)
            {
                this.r = r;
            }
            public override void GetArea()
            {
                Console.WriteLine($"넓이 : {r * r * 3.14}");
            }
        }

        static void Main(string[] args)
        {
            /*
            // 1
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
            */

            /*
            // 2
            Console.Write("정수 입력 : ");
            int r = int.Parse(Console.ReadLine());
            Circle cc = new Circle(r);
            cc.GetArea();
            */

            // 3
            Random r = new Random();
            HashSet<int> lotto = new HashSet<int>();
            while(lotto.Count<6)
            {
                lotto.Add(r.Next(1, 46));
            }
            Console.WriteLine(string.Join(", ", lotto));
        }
    }
}