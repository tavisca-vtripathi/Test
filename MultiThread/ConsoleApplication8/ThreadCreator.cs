using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
namespace MultiThreading
{
    class ThreadCreator
    {
        int UB = 3;                                           // Upper bound for the need of another consumer if needed
        int LB = 2;                                           // Lower bound for the need of another consumer if needed
    
        ConcurrentQueue<int> cq = new ConcurrentQueue<int>();  //Queue for holding randomly generated values
        ConcurrentQueue<int> cq1 = new ConcurrentQueue<int>();  // Queue for holding even values


        public void randomGen(Object state)
        {
            int temp;                                         //Generating Random Values
            Random r = new Random();
                while (true)                                     //infinite loop
                {
                    
                    temp=r.Next();
                    cq.Enqueue(temp);
                    Thread.Sleep(100);                                 //Sleep added to show the working of added Consumer

                }
            
            
        }
        public void evenTest(Object state)
        { 
            int check;                                                   //Testing even numbers
            
                while (true)
                {
                    if (cq.TryDequeue(out check))
                    {
                        if (check % 2 == 0)
                        {
                            cq1.Enqueue(check);
                        }

                    }
                    Thread.Sleep(100);                                    //Sleep added to show the working of added Consumer
                }
        }
            
            
        
        public void dispRes(Object state)
        {                                                                           //Displaying generated even values
            int x;
           
                while (true)
                {
                    
                    
                        if (cq1.TryDequeue(out x)) 
                        {
                            Console.WriteLine("Even No. \t {0}", x);
                        }

                        Thread.Sleep(500);                                                //Sleep added to show the working of added Consumer
                           
                    }
                }
        public void checkReq(Object state)
        {
            while (true)
            {
                if (cq1.Count > UB)                                                   //Continously checking the need of another consumer
                {
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<.....CONSUMER ADDED....>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    System.Threading.ThreadPool.QueueUserWorkItem(
                        new System.Threading.WaitCallback(dispRes2));
                    Thread.Sleep(600);                                                         //Sleep added to show the working of added Consumer             

                }
            }

        }
        public void dispRes2(Object state)
        {
                                                                                           // Thread evoked to aid consuming process
            int y;
            int flag;

            while (true)
            {


                if (cq1.TryDequeue(out y))
                {
                    Console.WriteLine("Even No. \t {0}", y);
                }
                flag = cq1.Count;
                if (flag < LB)
                {
                    Console.WriteLine("<<<<<<<<<<<<<<<<.....CONSUMER DEMOLISHED.....>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    break;
                }

                Thread.Sleep(500);                                                            //Sleep added to show the working of added Consumer                 
            }


        }


            }
            
        }

    

