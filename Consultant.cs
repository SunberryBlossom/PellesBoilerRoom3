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

        public TimeSpan ExtendContract(TimeSpan extension) // metod för att förlänga kontraktet
        {
            ContractDuration += extension; // lägg till förläningingen (kontrakt) på den nuvarande kontraktstiden
            return ContractDuration; // returnera den uppdaterade kontraktstiden
        }

        public decimal LogBillableHours(decimal hours) // metod för att logga timmar och uppdatera lönen
        {
            BillableHours += hours; // lägg till timmar på timmarna som redan är loggade
            _salary = BillableHours * HourlyRate; // uppdatera lönen baserat på de totala timmarna
            return _salary; // returnera den uppdetarade lönen
        }



    }
}
