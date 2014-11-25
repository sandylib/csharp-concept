using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_In_using 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 22, Name = "Mike", Salary = 3000, Experience = 3 });
            empList.Add(new Employee() { ID = 22, Name = "Amy", Salary = 5000, Experience = 6 });
            empList.Add(new Employee() { ID = 22, Name = "John", Salary = 6000, Experience = 4 });
            empList.Add(new Employee() { ID = 22, Name = "Rob", Salary = 4000, Experience = 5 });

           

            Employee.PromoteEmployee(empList,emp=>emp.Experience >= 5);

            Console.ReadLine();
        }

        
    }

    delegate bool IsPromotable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligibleToPromote)
        {
            foreach(Employee emp in employeeList)
            {
                if (IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " promoted");

                }
            }
        }
    }
}
