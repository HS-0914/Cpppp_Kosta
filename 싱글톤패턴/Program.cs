using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 싱글톤패턴
{
    public class Singleton
    {
        private static Singleton instance;
        public static Singleton getInstance() // static 붙음 ->class method
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("싱글톤패턴");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.getInstance().ShowMessage();
            // 내부적으로 생성된 instance를 계속 사용 ( 재사용? )
        }
    }
}
