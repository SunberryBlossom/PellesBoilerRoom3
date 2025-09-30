using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public virtual decimal Salary { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public void PrintInfo() 
        {
            Console.WriteLine($"Name: {Name}. Age: {Age}.");
        }

        public void Introduce() 
        {
            Console.WriteLine($"Hi my name is {Name} and I'm {Age} years old.");
        }

        public virtual void DoWork() 
        {
            Console.WriteLine($"{Name} is working");
        }

        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
        }
        public (int Years, int Months, int Days) CalculateYearsOfService()
        {
            DateTime today = DateTime.Today;
            //beräkning inte färdig 
            int years = today.Year - StartDate.Year;
            int months = today.Month - StartDate.Month;
            int days = today.Day - StartDate.Day;

            return (years, months, days);
        }
    }
}
