using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_interfaces_implementation
{
    class Program:I1,I2
    {
        //no access modify here and specify I1 in front of the method
        void I1.Interfacemethod()
        {
            Console.WriteLine("I1 interface Method");
        }

        //this method is inplemented as default 
     public   void Interfacemethod()
        {
            Console.WriteLine("I2 interface Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           ((I1) p).Interfacemethod();
           p.Interfacemethod();

           Console.ReadLine();
        }
    }

    interface I1
    {
        void Interfacemethod();
    }

    interface I2
    {
        void Interfacemethod();
    }
}
