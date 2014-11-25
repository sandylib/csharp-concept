using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * A delegate is a type safe function pointer.That is,it holds a reference(Pointer)to
     * a function.
     * 
     * The signature of the delegate must match the signature of the function,
     * the delegate points to,otherwise you get a compiler error.This is the 
     * reason delegates are called as type safe function points.
     * 
     * A delegate is similar to a class. You can create an instance of it,
     * and when you do so,you pass in the function name as a parameter to
     * the delegate constructor,and it is to this function the delegate will point to.
     * 
     * Remember delegate syntax:Delegates syntax look very much similar to 
     * a method with a delegate key keyword.
     *      
     * */
    public delegate void HelloFunctionDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hello from delegate");

            Console.ReadLine();
        }
        
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

}
