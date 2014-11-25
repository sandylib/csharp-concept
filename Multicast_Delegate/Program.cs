using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    class Program
    {
        /*
         * A Multicast delegate is a delegate that has reference to more than one function.
         * When you invoke a multicast delegate,all the functions the delegate is pointing to,
         * are invoked.
         * 
         * There are 2 approaches to create a multicast delegate.Depending on the approach
         * you use + or += to register a method with the delegate
         * 
         * - or -= to un-register a method with the delegate
         * 
         * A multicast delegate,invokes the methods in the invocation list,in the same
         * order in which they are added.
         * 
         * If the delegate has a return type other than void and if the delegate is a 
         * multicast delegate,only the value of the last invoked method will be returned.
         * Along the same lines,if the delegate has an out parameter,the value of the 
         * output parameter,will be the value assigned by the last method.
         * 
         * Where do you use multicast delegates?
         * 
         * Multicast delegate makes implementation of observed design pattem very simple.
         * Observer pattem is also called as publish/suscribe pattem.
         * 
         * */
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            
            int result = -1;
            del(out result);
           Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
        }

        public static void SampleMethodOne(out int Number)
        {
            //Console.WriteLine("Sample one invoked");
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
           // Console.WriteLine("Sample Two invoked");

            Number = 2;
        }
        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("Sample Three invoked");
        //}
        
    }

    public delegate void SampleDelegate(out int integer);
}
