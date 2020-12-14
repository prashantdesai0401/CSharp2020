using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    class MyThread
    {
        /*private int sum1, sum2;

        public int Sum1 { get => sum1; }
        public int Sum2 { get => sum2; }*/
        private int sum=100;
        //Mutex mut = new Mutex();
        Semaphore sem1 = new Semaphore(1, 1);
        public int Sum { get => sum; }

        public void Summation1()
        {
            //mut.WaitOne();
            sem1.WaitOne();
            sum -= 20;//CS
            sem1.Release();
            //mut.ReleaseMutex();
            /*
            //int startValue = (int)data;
            for(int i= startValue; i<=500; i++)
            {
                mut.WaitOne();
                sum += i;
                mut.ReleaseMutex();
            }*/
        }

        public void Summation2()
        {
            //mut.WaitOne();
            sem1.WaitOne();
            //CS
            {
                int temp = sum;
                Thread.Sleep(1000);
                temp += 40;
                sum = temp;
            }
            sem1.Release();
            //mut.ReleaseMutex();
            //sum += 40;
            //Thread.Sleep(1000);
            /*
            for (int i = 501; i <= 1000; i++)
            {
                mut.WaitOne();
                sum += i;
                mut.ReleaseMutex();
            }*/
        }
        //this method will be executed when you start the thread1
        /*public  void Thread1Method(object state)
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            int t1 = 100;
            for(int i=1; i<=t1;i+=2)
            {
                Console.WriteLine("inside thread1:" + i);
            }
        }

        //this method will be executed when you start the thread2
        public void Thread2Method(object state)
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            int t2 = 100;
            for (int i = 2; i <=t2; i += 2)
            {
                Console.WriteLine("inside thread2:" + i);
            }
        }*/

    }
    class Program
    {
        static void Main(string[] args)
        {

            MyThread demoThread = new MyThread();

            Thread thread1 = new Thread(demoThread.Summation1);
            Thread thread2 = new Thread(new ThreadStart(demoThread.Summation2));
            thread2.Priority = ThreadPriority.Highest;
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            //int sum = demoThread.Sum1 + demoThread.Sum2;
            Console.WriteLine("Result:" + demoThread.Sum);

            //Thread creation
            /*Thread thread1 = new Thread(new ThreadStart(demoThread.Thread1Method));
            thread1.Name = "Thread1";
            Thread thread2 = new Thread(new ThreadStart(demoThread.Thread2Method));
            thread2.Name = "Thread2";
            
            //start the threads
            thread1.Start();
            thread2.Start();
            //Console.WriteLine("Name of Thread1" + thread1.Name);
            //Console.WriteLine("Name of Thread2" + thread2.Name);
            //after starting both the threads the main thread will continue
            thread1.Join();
            thread2.Join();*/
            //ThreadPool.QueueUserWorkItem(demoThread.Thread1Method);
            //ThreadPool.QueueUserWorkItem(demoThread.Thread2Method);
            Console.WriteLine("Main thread is exiting");
            Console.ReadLine();
        }
    }
}
