using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 스레드생성하기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주스레드 시작....");
            ThreadStart ts = new ThreadStart(ThreadFunction);
            Thread thd = new Thread(ts);

            Console.WriteLine("워커스레드 시작 : " + thd.ThreadState);
            thd.Start();
            Console.WriteLine("워커스레드 시작 : " + thd.ThreadState);
            Console.WriteLine("주스레드 종료");
            Thread.Sleep(100);
            thd.Join();
            //thd.Abort();
        }
        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while (count < 1000)
                {
                    count++;
                    Console.WriteLine("스레드 동작중... : " + count);
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine($"Abort 예외 : {e}");
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
