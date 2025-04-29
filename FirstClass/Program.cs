using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        protected int eyes, nose, mouth, ears;
        protected string kinds;
    }
    public class Poodle : Dog { 
        public Poodle()
        {
            base.eyes = 2;
            base.nose = 2;
            base.mouth = 2;
            base.ears = 2;
            base.kinds = "푸들";
        }
        public override void Bark()
        {
            Console.WriteLine("왈왈");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.Bark();
            
            Poodle p = new Poodle();
            p.Bark();

            Dog b = new Poodle();
            b.Bark();
        }
    }
}
