using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    internal class Housekeeper : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine($"The housekeeper {Name} is cleaning the lobby.");
        }
    }
}
