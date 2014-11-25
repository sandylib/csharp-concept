using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    /*
    * Function overloading and Method overloading terms are used interchangeabley.
     * 
     * Method overloading allows a class to have multiple methods with the same name,
     * but, with a different signature. So, in C# functions can be overloaded based on 
     * the number,type(int,float etc) and kind(Value,Ref or Out) of parameters.
     * 
     * The signature of a method consists of the name of the method and the tye, kind(value,
     * reference,or output) and the number of its formal parameters. The signature of a 
     * method does not include the return type and the params modifier.So, it is not 
     * possible to overload a function, just based on the return type or params modifier.
     * 
     * 
     *  
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(3, 5, 6);

            Console.ReadLine();
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        
        public static void Add(float FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }


        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN );
            Sum = FN + SN;
        }
       
       
    }

    
}
