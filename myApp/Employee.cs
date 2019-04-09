using System;

namespace myApp
{
    public class Employee
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _position { get; set; }
        private DateTime _dateStarted { get; set; }
        private string _company { get; set; }

        public void setCompany(string companyName)
        {
            _company = companyName;
        }


        public Employee(string fName, string lName, string position)
        {
            _firstName = fName;
            _lastName = lName;
            _position = position;
            _dateStarted = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"{_firstName} {_lastName} works for {_company} as a {_position}. Hired on {_dateStarted}");
        }

    }
}
