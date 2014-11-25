using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Customer
    {
        //private fields
        private int _id;
        private string _name;

        //public properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //public properties
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        //constructor
        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        //Method
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(201, "Sandy");
            customer1.PrintDetails();

            Customer customer2 = new Customer();
            customer2.ID = 505;
            customer2.Name = "Amy";

            customer2.PrintDetails();

            Customer customer3 = new Customer
            {
                ID = 666,
                Name = "Mike"

            };
            customer3.PrintDetails();

            Console.ReadLine();
        }
    }
}
