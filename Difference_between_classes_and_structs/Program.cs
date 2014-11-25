using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_classes_and_structs
{
    /*
     * A struct is a value type where as a class is a reference type.
     * 
     * All the differences are applicable to value types and reference types 
     * are also applicable to classes and structs.
     * 
     * Structs are stored on stack, where as classes are stored on the heap.
     * 
     * Value types hold their value in memory where they are declared, but reference
     * types hold a reference to an object in memory.
     * 
     * Value types are destroyed immediately after the scope is lost,where as for reference
     * types only the reference variable is destroyed after the scope is lost.The object
     * is later destroyed by garbage collector.
     * 
     * When you copy a struct into another struct, a new copy of that struct gets created
     * and modifications on one struct will not affect the values contained by the other struct.
     * 
     * When you copy a class into another class.we only get a copy of the reference variable.
     * Both the reference variables point to the same object on the heap.Operations on one
     * variable will affect the values contained by the other reference variable.
     * 
     * Struct can't have destructors,but classes can have destructors.
     * 
     * Structs can't have explicit parameter less constructor but class can.
     * 
     * Struct can't inherit from another class but class can.
     * 
     * Both struts and classes can inherit from an interface.
     * 
     *  
     * Examples of structs in the .net framework -int(System.Int32),double(System.Double) etc.
     * 
     * class or struct can't inherit from another struct. Struct are sealed type.
     * how do you prevent a class from being inherited? or what is the 
     * significance of sealed
     * 
     * when a class marked as sealed then can't be use as base class
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            if(i==10)
            {
                int j = 20;
                Customer c1 = new Customer();
                c1.ID = 888;
                c1.Name = "Amy";
            }
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }


    public class Customer
    {
        //public porperties
        public int ID { get; set; }
        public string  Name { get; set; }

        //Constructor
        public  Customer()
        {

        }

        //destructor
        ~Customer()
        {

        }
    }




}
