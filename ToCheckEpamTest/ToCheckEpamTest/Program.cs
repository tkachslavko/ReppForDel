using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Now I wil try to add anotetion to this project
namespace ToCheckEpamTest
{
    class Program
    {
        delegate int MyDelegate(int time);
        static void Main(string[] args)
        {
            MyDelegate myDelegate=FuncForDelegate;
            myDelegate.BeginInvoke( 5000, EndOfDelegateWork, null);
            for (int i = 0; i < 5000; i+=100)
            {
                Console.Write(".");
                Thread.Sleep(50);
            }
            Console.WriteLine("Current Thread finished!");
            Console.ReadLine();
        }
        public static int FuncForDelegate(int i)
        {
            for (int k = 0; k < i; k+=100)
            {
                Console.Write(k);
                Thread.Sleep(100);
            }   
            return i * i;
        }
        public static void EndOfDelegateWork(IAsyncResult iar)
        {
            Console.WriteLine("End of delegate work...");
        }
    }
}
