using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>{
                new Employee (1,"Gal", 30, 3000 ),
                 new Employee (3, "Dana", 30, 5000),
                  new Employee (2, "Avi", 30, 8000)
            };
            List<Employee> employeeCloneList = GetCloneList(employeeList);
            PrintEmployeeList(employeeCloneList);
            List<Employee> employeeSortedList =GetSortedList(employeeCloneList);
            Console.WriteLine();
            PrintEmployeeList(employeeSortedList);
            Console.ReadLine();
        }
        static List<Employee> GetCloneList(List<Employee> employeeList)
        {
            List<Employee> employeeCloneList = new List<Employee>();
            foreach (Employee ee in employeeList)
            {
                employeeCloneList.Add( ee.Clone());
            }
            return employeeCloneList;
        }

        static void PrintEmployeeList(List<Employee> employeeList)
        {
            foreach (Employee ee in employeeList)
            {
              ee.Print();
            }


        }
        static List<Employee> GetSortedList(List<Employee> employeeList)
        {
            int listCount = employeeList.Count;
            switch (listCount)
            {
                case int ii when listCount < 100:
                    return employeeList.OrderBy(d => d.Id).ToList<Employee>(); 
                case int ii when listCount <= 200 :
                    return employeeList.OrderBy(d => d.Name).ToList<Employee>();
                case int ii when listCount >=300 :
                    return employeeList.OrderBy(d => d.Salary).ToList<Employee>();
                default:
                    return employeeList;
                   
            }

        }
    }
}
