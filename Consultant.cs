using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_OOP_Hotel_part_two
{
    internal class Consultant : Person
    {
        private decimal _salary = 0;

        public override decimal Salary 
        {
            get { return _salary; }
        }

        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }
        public TimeSpan ContractDuration { get; set; } // lägg till en egenskap för kontraktets längd
        public string ProjectName { get; set; }
        public decimal BillableHours { get; set; }


        public void GiveAdvice()
        {
            Console.WriteLine($"Consult expertise: {Expertise}");
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} is having a workshop in the field of {Expertise}");
        }

        public void ExtendContract(TimeSpan extension) // metod för att förlänga kontraktet
        {
            ContractDuration += extension; // lägg till förläningingen (kontrakt) på den nuvarande kontraktstiden
            int daysOfContract = ContractDuration.Days;
            Console.WriteLine($"The contract has been extended to {daysOfContract} days.");
        }

        public void LogBillableHours(decimal hours) // metod för att logga timmar och uppdatera lönen
        {
            BillableHours += hours; // lägg till timmar på timmarna som redan är loggade
        }



    }
}
