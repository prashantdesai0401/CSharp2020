using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Demo
{

    class MyException : Exception
    {
        public MyException(string message)
        {
            
        }
    }

    
    interface ITest
    {
        void Test();
    }

    class MyClass : ITest 
    {
        public void Test()
        {
            throw new MyException("My exception");
        }

        public void Test1()
        {
            try
            {
                Test();
            }
            catch(MyException e)
            {
               
                throw e;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 2;
            
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
                //code to open a stream/network resource/file
                //code read/write
                //

            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                Console.WriteLine("inside finally");
            }*/

            MyClass m1 = new MyClass();
            try
            {
                m1.Test1();
            }
            catch(NotImplementedException e)
            {
                throw e;
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            
            try
            {
                Console.WriteLine("testing");
            }
            finally
            {

            }
            
            
           
            Console.ReadLine();

        }
    }
}
