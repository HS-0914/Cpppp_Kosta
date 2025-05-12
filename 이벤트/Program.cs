using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트
{
    class Program
    {
        public delegate void ButtonEvent();
        public static event ButtonEvent evtClick;
        public static void onClick()
        {

        }

        // 어떤 이벤트(a버튼 클릭, 마우스 오버 등?)
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭 처리기 수행 성공");
        }
        static void Main(string[] args)
        {
            evtClick += new ButtonEvent(MyHandler);
        }
    }
}
