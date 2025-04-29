using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    public class Zerg
    {
        public void Overload(int zerggling)
        {
            Console.WriteLine("저글링 {0} 마리", zerggling);
        }
        public void Overload(char zerggling)
        {
            Console.WriteLine("저글링 {0} 마리", zerggling);
        }
        public void Overload(int zerggling, int hydra)
        {
            Console.WriteLine("저글링 {0} 마리", zerggling);
        }
        public void Overload(int zerggling, int hydra, int lurler)
        {
            Console.WriteLine("저글링 {0} 마리", zerggling);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zerg zerg = new Zerg();
            zerg.Overload(100, 20);
            zerg.Overload('A');
        }
    }
}
