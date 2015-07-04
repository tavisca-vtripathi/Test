using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ThreadCreator tc = new ThreadCreator();


            System.Threading.ThreadPool.QueueUserWorkItem(
                new System.Threading.WaitCallback(tc.randomGen));

            System.Threading.ThreadPool.QueueUserWorkItem(
     new System.Threading.WaitCallback(tc.evenTest));

            System.Threading.ThreadPool.QueueUserWorkItem(
    new System.Threading.WaitCallback(tc.dispRes));
            System.Threading.ThreadPool.QueueUserWorkItem(
   new System.Threading.WaitCallback(tc.checkReq));

            Console.ReadKey();
            
           
           




        }

       
    }
}
