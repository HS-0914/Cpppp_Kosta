using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상클래스
{
    public abstract class SmartPhone
    {
        public abstract void Camera();

        public abstract void CallPhone();

        public abstract void Network();
    }

    public class Samsung : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("삼성 카메라 기능 구현");
        }

        public override void CallPhone()
        {
            Console.WriteLine("삼성 전화 기능 구현");
        }

        public override void Network()
        {
            Console.WriteLine("삼성 통신 기능 구현");
        }
    }

    public class Apple : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("애플 카메라 기능 구현");
        }

        public override void CallPhone()
        {
            Console.WriteLine("애플 전화 기능 구현");
        }

        public override void Network()
        {
            Console.WriteLine("애플 통신 기능 구현");
        }
    }

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
