using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenMethodOverrideMethod
{
    /* Difference between method overriding and method hiding
     * 
     * In method overriding a base class reference variable pointing to 
     * a child class object, will invoke the overriden method in che child class
     * 
     * 
     * In method hiding a base class reference variable pointing
     * to a child class object, will invoke the hidden method in the
     * base class
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print();

            Console.ReadLine();
        }

        
    }


    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    /*
    * using the override key word for override method
    * 
    * output:I am a Override Class Print Method
     * 
     * 
     * */


    public class DerivedClass:BaseClass
   {
       public override void Print()
       {
           Console.WriteLine("I am a Override Class Print Method");
       }
   }


   /*
    * using the new key word will change the class to hidding method
    * 
    * output:I am a Base Class Print Method
    * 
       public class DerivedClass : BaseClass
       {
           public new void Print()
           {
               Console.WriteLine("I am a Override Class Print Method");
           }
       }
    * */
}
