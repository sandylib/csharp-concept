using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_abstract_classes_and_interfaces
{
    class Program
    {
        /*
         * Abstract classes can have implementation for some of its members(Methods),but
         * the interface can't have implementation for any of its members.
         * 
         * Interfaces can't have fields where as an abstract class can have fields.
         * 
         * An interface can inherit from another interface only and can't inherit
         * from an abstract class, where as an abstract class can inherit from 
         * abstarct class or another interface.
         * 
         * A class can inherit from multiple interface at the same time,where 
         * as a class can't inherit from multiple classes at the same time.
         * 
         * Abstract class members can have access modifiers where as interface can't have 
         * access modifiers.
         * 
         * */
        static void Main(string[] args)
        {
        }
    }


    public abstract class Customer
    {
        int ID;//can have field
        //members private by default
        public void Print()
        {
            Console.WriteLine("Print");
        }

    }


    public interface  ICustomer
    {
        //int ID;//will have error can't have field
        //can't have inplementation here 
        //only define here
        //can't have access in here
        //public by default

         void Print();
        

    }
}
