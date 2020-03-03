﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Employee: IProto<Employee>
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }

        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        public Employee Clone()
        {
            Employee result = new Employee (
                this.Id,
                this.Name,
                this.Age,
                this.Salary
           );
           return result;    
        }
        public void Print()
        {
            Console.WriteLine($"id={Id},Name={Name},Age={Age},Salary={Salary}");
        }
        public override string ToString()
            {
                return $"{Id} {Name} {Age}";
            }
    }
}
