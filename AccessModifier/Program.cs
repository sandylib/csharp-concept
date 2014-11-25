using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Customer
    {
        //access private then only can access in this class
       // private int _id;

        protected int ID;

        //access public then this can access anyway
        //public int ID
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

    }

    public class CustomerB :Customer
    {
        public string PrintID()
        {
            CustomerB b = new CustomerB();
            b.ID = 101;

            return b.ID.ToString();


           //  base.ID = 101;
           // this.ID = 101;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerB c1 = new CustomerB();
            string idstr = c1.PrintID();

            Console.WriteLine("Id is {0}", idstr);

            Console.ReadLine();
        }
    }
}
