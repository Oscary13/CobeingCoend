using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CobeingCoend
{
    internal class Program
    {
        public static long j = 10;
        static void Main(string[] args)
        {
            Thread h1 = new Thread(hilo1);
            Thread h2 = new Thread(hilo2);

            h2.Start();
            h1.Start();

            Console.WriteLine(j);
            Console.ReadLine();
        }
        public static void hilo1()
        {
            Console.WriteLine(j);
        }

        public static void hilo2()
        {
            j = 100000000;
        }
    }
}
