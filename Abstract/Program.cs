using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /*
     * The abstract keyword is used to create abstract classes.
     * 
     * An abstract class is incomplete and hence can't be insatantiated.
     * 
     * An abstract class can only be used as base class.
     * 
     * An abstract class can't be sealed.
     * 
     * An abstract class may contain abstract members(methods,properties,indexers,and events),but not
     * mandatory
     *  
     * A non-abstract class derived from an abstract class must provide implementations 
     * for all inherited abstract members.
     * 
     * If a class inherits an abstract class, there are 2 options available for that class
     * Option1:Provide implementation for all the abstract members inherited from the base abstract class.
     * 
     * Option2:If the class does not wish to provide implementation for all the abstract members.
     * inherited from the abstract class,then the class has to be marked as abstract.
     * 
     * */
     class Program : Customer
    {
         public override void Print()
         {
             Console.WriteLine("Print method");
         }
        static void Main(string[] args)
        {
            Customer c = new Program();
            c.Print();

            Console.ReadLine();
        }
    }


    abstract class Customer
    {
     public abstract void Print();

    }
}
