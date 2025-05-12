using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 컬렉션
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList ar = new ArrayList(10);
            //ar.Add(1);
            //ar.Add(1);
            //ar.Add(2.34);
            //ar.Add("string");
            //ar.Add(new DateTime(2025, 5, 12));
            //ar.Insert(1, 1234);

            ar.Add("이승만");
            ar.Add("박정희");
            ar.Add("최규하");
            ar.Add("전두환");
            ar.Add("노태우");
            ar.Add("김영삼");
            ar.Add("김대중");
            ar.Add("노무현");
            ar.Add("이명박");
            ar.Add("박근혜");
            ar.Add("문재인");
            ar.Add("윤석열");

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            foreach (object item in ar)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine();
            ar.Sort();
            foreach (object item in ar)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine();
            ar.Reverse();
            foreach (object item in ar)
            {
                Console.Write(item.ToString() + ", ");
            }

            // 해시 테이블
            // 해시의 구조 키 : 값
            Hashtable ht = new Hashtable();

            ht.Add("boy", "소년");
            ht.Add("girl", "소녀");
            ht["school"] = "학교";

            Console.WriteLine(ht["boy"]);

            // 스택과 큐
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());

            // 유틸리티 클래스
            DateTime A = new DateTime(2025, 5, 12);
            DateTime B = new DateTime(2025, 6, 3);
            TimeSpan C = B - A;

            Console.WriteLine(C.ToString());

            A = new DateTime(2025, 5, 12);
            C = new TimeSpan(67, 0, 0, 0);

            B = A + C;
            Console.WriteLine(B.ToString());
            */

            // Random
            Random rnd = new Random();
            //Console.WriteLine(rnd.Next(100));
            for (int i = 0; i < 100; i++)
            {
                Console.CursorLeft = rnd.Next(80);   
                Console.CursorTop = rnd.Next(24);
                Console.Write("*");
            }
        }
    }
}
// 어떤 언어에서든 컬렉션 객체는 추가 정렬 등등 편리한 기능이 제공된다.