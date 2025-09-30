using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    internal class Housekeeper : Employee
    {
        enum CleaningSpeed { Fast, Average, Thorough }
        CleaningSpeed CurrentCleaningSpeed { get; set; }
        public List<string> SpecialityAreas { get; set; } = new List<string>();
        public Dictionary<string, int> SuppliesInventory { get; set; } = new Dictionary<string, int>();
        public override void DoWork()
        {
            Console.WriteLine($"The housekeeper {Name} is cleaning the lobby.");
        }

        public void AddSpecialityArea(string area)
        {
            SpecialityAreas.Add(area);
        }

        public void UpdateSuppliesInventory(string item, int quantity)
        {
            SuppliesInventory.Add(item, quantity);
        }
    }
}
