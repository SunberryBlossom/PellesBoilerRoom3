using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    internal class Manager : Person
    {
        public int TeamSize { get; set; }
        public decimal BonusPercentage { get; set; }
        public enum ManagementLevel {Junior, Middle,Senior }
        public ManagementLevel CurrentManagementLevel { get; set; }
        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} is holding a really, REALLY boring meeting.");
        }

        public void PlanBudget() 
        {
            Console.WriteLine("Money money money");
        }

        public override void DoWork() 
        {
            Console.WriteLine($"{Name} is telling people what to do in the {Department} department");
        }

        public void AssignTeam(int size) 
        {
            TeamSize = size;
            
        }

        public void CalculateBonus() 
        {
            decimal bonus = Salary * BonusPercentage;
            Console.WriteLine($"The manager {Name}\'s current bonus is {bonus}");
        }

    }
}

