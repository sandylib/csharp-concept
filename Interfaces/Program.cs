using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*
     * We create interfaces using the interface keyword.Just like class interfaces also contains properties,
     * methods,delegates or events,but only declarations and no implementations.
     * 
     * It is a compile time error to provide implementations for any interface member.
     * 
     * Interface members are public by default,and they don't allow explicit access modifies.
     * 
     * Interfaces cann't contain fields.
     * 
     * If a class or a struct inherits from an interface, it must provide implementation for all interface
     * members.Otherwise we get a compiler error.
     * 
     * A class or a struct can inherit from more then one interface at the same time,but where as,
     * a class can't inherit from more then once class at the same time.
     * 
     * Interfaces can inherit from other interfaces.A class that inherits this interface must 
     * provide implementation for all interface members in the entire interface inheritance chain.
     * 
     * We can't create an instance of an interface,but an interface reference variable can 
     * point to a derived class object.
     * 
     * Interface Naming Convention:Interface names are prefixed with capitalI.
     * 
     * */
    class Program :Customer
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print1();
            c1.Print2();

           // ICustomer1 c2 = new ICustomer1(); // not arrow

            ICustomer1 c3 = new Customer(); //this is fine//ICustomer1 is parent of Customer
            c3.Print1();//here only print1 avaiable

            Console.ReadLine();
        }
    }

    //only define not implemention
    //public by default
    //can't have fields
    interface ICustomer1  //naming convention by following "I",it just for easy know that is interface
    {
        void Print1();
        
    }

    interface ICustomer2 :ICustomer1
    {
        void Print2();
    }

    //if class inherit from interface, this class must provide inplemention for interface member 
     class Customer : ICustomer2
    {

        public void Print2()
        {
            Console.WriteLine("Print2");
        }

        public void Print1()
        {
            Console.WriteLine("Print1");
        }
    }
}
