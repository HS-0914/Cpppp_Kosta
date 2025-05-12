using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 제네릭
{
    class WrapperInt
    {
        int value;
        public WrapperInt() { value = 0; }
        public WrapperInt(int aValue)
        {
            this.value = aValue;
        }
        public int Data
        {
            get { return value; }
            set { this.value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(value);
        }
    }

    class WrapperString
    {
        string strValue;
        public WrapperString() { strValue = null; }
        public WrapperString(string aValue)
        {
            this.strValue = aValue;
        }
        public string Data
        {
            get { return strValue; }
            set { this.strValue = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(strValue);
        }
    }
    class Wrapper<T>
    {
        T value;
        public Wrapper() { value = default(T); }
        public Wrapper(T value)
        {
            this.value = value;
        }
        public T Data
        {
            get { return value; }
            set { this.value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WrapperInt gi = new WrapperInt(1234);
            gi.OutValue();

            Wrapper<int> gi = new Wrapper<int>(1234);
            gi.OutValue();
            Wrapper<string> gs = new Wrapper<string>("4321");
            gs.OutValue();

            // 일반 컬렉션
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2.34);
            ar.Add("string");

            Console.WriteLine((int)ar[0]);
            Console.WriteLine((double)ar[1]);
            Console.WriteLine((string)ar[2]);
            */

            // 제너릭 컬렉션
            List<string> ar = new List<string>(); // string 타입만

        }
    }
}
