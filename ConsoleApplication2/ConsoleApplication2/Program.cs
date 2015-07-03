using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static int x;
        static int f;
        static void Main(string[] args)
        {
            //Console.WriteLine("Press E to exit");
            ThreadStart ts1 = new ThreadStart(new Program().Random);
            ThreadStart ts2 = new ThreadStart(new Program().EvenTest);
            ThreadStart ts3 = new ThreadStart(new Program().Disp);
            Thread[] th = new Thread[3];
            th[0] = new Thread(ts1);
            th[1] = new Thread(ts2);
            th[2] = new Thread(ts3);
            foreach (Thread myThread in th)
            {
                myThread.Start();
            }

            Console.ReadLine();
        }

        public void Random()
        {
            while (true)
            {

                lock (this)
                {

                    Random n = new Random();
                    x = n.Next();


                    Thread.Sleep(1000);
                }
            }

        }
        public void EvenTest()
        {
            while (true)
            {
                f = 0;
                lock (this)
                {



                    if (x % 2 == 0)
                    {
                        Console.Write("\n even");
                        f = 1;
                    }
                    Thread.Sleep(1000);
                }
            }


        }
        public void Disp()
        {
            while (true)
            {
                lock (this)
                {

                    if (f == 1)
                    {
                        Console.Write("\t\t {0}", x);



                    }

                    Thread.Sleep(1000);
                }
            }

        }
    }
}
