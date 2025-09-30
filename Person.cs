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
        public void CalculateYearsOfService()
        {
            DateTime today = DateTime.Today;

            TimeSpan timeOfService = today.Subtract(StartDate);
            double totalDays = timeOfService.TotalDays;
            double years = totalDays / 365.25;

            Console.WriteLine($"{Name} has been working here for a total of {totalDays} days.\nThat's a total of {years:F1} years. Wow!");
        }

        public void ChangeEmployeeId(string newId)
        {
            Console.WriteLine($"The Id of {Name} was changed from {EmployeeId} to {newId}");
            EmployeeId = newId;
        }

        public void UpdateContactInfo(string phone, string email, string address)
        {
            PhoneNumber = phone;
            Email = email;
            Address = address;
            Console.WriteLine($"You have now updated your phone number to {PhoneNumber}.\n Your Email to {Email}.\nYour address to {Address}.");
        }
    }
}
