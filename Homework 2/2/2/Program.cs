using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace ConsoleApplication1
{
    public class MyThread
    {
        public int ThreadNumbers(int fib)
        {
            if (fib <= 1) return fib;
            else
            {
                return ThreadNumbers(fib - 1) + ThreadNumbers(fib - 2);
            }

        }
    }

    class Program
    {
        static void Main()
        {
            MyThread mt = new MyThread();

            Console.WriteLine(mt.ThreadNumbers(10));
        }
    }
}