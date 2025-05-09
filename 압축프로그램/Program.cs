using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 압축프로그램
{
    delegate bool CompProg(int nFile);
    class Archive
    {
        public static bool Compress(int nFile, CompProg prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                //Console.WriteLine($"{i + 2}번째 압축중");
                if (prog(i) == false)
                //if (!prog(i))
                {
                    return prog(i);
                }
                System.Threading.Thread.Sleep(500);
            }
            return true;
        }
    }
    class Program
    {
        public static bool Progress(int nFile)
        {
            Console.WriteLine($"{nFile + 1}번째 압축중입니다.");
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki;
                // true -> 입력 받은 키 출력, false -> 안함
                cki = Console.ReadKey(false);
                if(cki.Key == ConsoleKey.Q)
                {
                    // 압축 중단
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (Archive.Compress(10, Progress) == true)
            {
                Console.WriteLine("모든 파일을 압축했습니다.");
            }
            else
            {
                Console.WriteLine("취소됨");
            }
        }
    }
}
