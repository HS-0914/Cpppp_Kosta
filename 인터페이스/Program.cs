using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스
{
    public interface IUnit
    {
        void Attack();
        void Move();
    }

    public class Zergling : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("저글링 : 공격");
        }
        
        public void Move()
        {
            Console.WriteLine("저글링 : 이동");
        }
    }

    public class Zealot : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("질럿 : 공격");
        }

        public void Move()
        {
            Console.WriteLine("질럿 : 이동");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zergling zergling = new Zergling();
            zergling.Attack();
            zergling.Move();

            Zealot zealot = new Zealot();
            zealot.Attack();
            zealot.Move();
        }
    }
}

