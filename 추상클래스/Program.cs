using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone = new Samsung();
            phone.Camera();
            phone.CallPhone();
            phone.Network();

            phone = new Apple();
            phone.Camera();
            phone.CallPhone();
            phone.Network();

        }
    }
    class Base
    {
        public virtual void Message() { Console.WriteLine("Base"); }
    }
    class Derived : Base
    {
        public sealed override void Message() { Console.WriteLine("Derived"); }
    }
    class Third : Derived
    {
        public new void Message() { Console.WriteLine("Third"); }
    }
}
