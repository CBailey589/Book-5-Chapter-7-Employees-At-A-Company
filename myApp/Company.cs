using System;
using System.Collections.Generic;

namespace myApp
{
    public class Company
    {
        private DateTime _founded { get; set; }
        private string _name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Company(string name)
        {
            _name = name;
            _founded = DateTime.Now;
        }

        public void Hire(Employee person)
        {
            person.setCompany(_name);
            Employees.Add(person);
        }
        public void Print()
        {
            Console.WriteLine($@"
            Name: {_name}
            Established: {_founded}
            ---------------------------
            ");

            foreach (Employee Employee in Employees)
            {
                Employee.Print();
            }
        }
    }
}