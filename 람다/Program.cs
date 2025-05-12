using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IronPython.Hosting;

namespace 람다
{
    class Human
    {
        public Human(){ }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        delegate int CalcDel(int x, int y);

        static void Main(string[] args)
        {
            /*
            // 타입 추론
            var a = 10;
            var x = 10;
            var y = 5;
            var str = "문자열";

            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);

            // 동적 타입
            dynamic value;
            value = 5;
            value = "str";
            Console.WriteLine(value);

            var python = Python.CreateEngine();
            var scope = python.CreateScope();
            string script = @"
def calc(n):
    sum = 0
    for num in range(n+1):
        sum += num
    return sum
";
            python.Execute(script, scope);
            dynamic calcsum = scope.GetVariable("calc");
            int sum = calcsum(10);
            Console.WriteLine(sum);

            // 익명 타입
            Human human = new Human("이순신", 32);
            Console.WriteLine(human.Name + " : " + human.Age);
            */

            CalcDel del1;
            del1 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(del1(10, 20));

        }
    }
}
