using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스2
{
    public interface ICamera
    {
        void Camera();
    }
    public interface ICallPhone
    {
        void CallPhone();
    }
    public interface INetwork
    {
        void Network();
    }

    abstract public class SmartPhone : ICamera, ICallPhone, INetwork
    {
        virtual public void Camera()
        {
            Console.WriteLine("카메라 기능 구현");
        }

        virtual public void CallPhone()
        {
            Console.WriteLine("전화 기능 구현");
        }

        virtual public void Network()
        {
            Console.WriteLine("통신 기능 구현");
        }
    }

    public class Samsung : SmartPhone
    {

    }

    public class Apple : SmartPhone
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// 클래스는 확장
// 인터페이스는 구현

/*
인터페이스 상속 또는 다중상속을 하는 경우 두 개의 책임을
지게 되는 것이니 하나의 책임을 지는 룰에 위배된다?

- 클래스 상속과 인터페이스 상속은 그 의미가 분명히 다르다.
- 클래스 상속은 부모와 자식간에 같은 책임을 가지지만 작동 형태가 다른 것.

- 인터페이스 상속은 기능을 추가하거나
클래스 간의 통신을 하기 위한 방법을 제공하는 것.
*/