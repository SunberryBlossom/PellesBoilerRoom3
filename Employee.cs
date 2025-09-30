using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    

    internal class Employee : Person
    {
        public string WorkTitle { get; set; }
        public enum ShiftPreference { Morning, Afternoon, Night }
        public ShiftPreference CurrentShiftPreference { get; set; }
        public int VacationDays { get; set; }
        public decimal PerformanceRating { get; set; }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} is working away for that pay. What a king.");
        }
        
        public void RequestVacation(int days)
        {
            Console.WriteLine($"{Name} is requesting payed leave for {days} days.");
            VacationDays = -days;
        }

        public void ChangeShift(ShiftPreference newShift)
        {
            if(CurrentShiftPreference != newShift)
            {
                Console.WriteLine($"{Name} has mentioned that they wish to start working {newShift} shifts instead of {CurrentShiftPreference}");
                CurrentShiftPreference = newShift;
            }
        }

    }
}
