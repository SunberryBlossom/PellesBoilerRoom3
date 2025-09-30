using System.Xml.Linq;

namespace The_OOP_Hotel_part_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Lisa Ledarsson",
                Age = 40,
                EmployeeId = "M001",
                StartDate = new DateTime(2020, 1, 1),
                Salary = 50000m,
                Department = "Administration"
            };

            // Skapa en Employee
            Employee employee = new Employee
            {
                Name = "Erik Eriksson",
                Age = 30,
                EmployeeId = "E001",
                StartDate = new DateTime(2022, 3, 15),
                Salary = 30000m,
                JobTitle = "Receptionist",
                Department = "Front Desk"
            };

            // Anropa metoder för att testa
            Console.WriteLine("\nManager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.DoWork();

            Consultant consultant = new Consultant
            {
                Name = "Eva Expert",
                Age = 35,
                EmployeeId = "C001",
                StartDate = new DateTime(2023, 1, 1),
                Salary = 100, // Konsulter har ofta inte fast lön
                HourlyRate = 1000,
                ConsultingFirm = "Hotell Experterna AB",
                Expertise = "Multitasking"
            };

            Console.WriteLine("\nConsultant:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();
            Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");

            Housekeeper housekeeper1 = new Housekeeper()
            {

                Name = "Anna Clean",
                Age = 32,

            };

            housekeeper1.PrintInfo();
            housekeeper1.DoWork();
            Console.WriteLine("\n\n");

            List<Person> hotelStaff = new List<Person>();

            // Lägg till olika typer av anställda i listan
            hotelStaff.Add(new Manager { Name = "Maria Svensson", Age = 45, EmployeeId = "M002", CurrentManagementLevel = Manager.ManagementLevel.Junior, Department = "Operations", Salary = 55000m, StartDate = new DateTime(2018, 5, 1), BonusPercentage = 0.15m });
            hotelStaff.Add(new Employee { Name = "Johan Andersson", CurrentShiftPreference = Employee.ShiftPreference.Night, Age = 28, EmployeeId = "E002", JobTitle = "Receptionist", Department = "Front Desk", Salary = 32000m, StartDate = new DateTime(2021, 9, 15) });
            hotelStaff.Add(new Consultant { Name = "Sara Lindberg", Age = 38, EmployeeId = "C002", ConsultingFirm = "Hotell Konsulterna AB", HourlyRate = 1200m, StartDate = new DateTime(2023, 3, 1), Expertise = "Interpersional communication" });
            hotelStaff.Add(new Employee { Name = "Kalle Persson", Age = 33, EmployeeId = "E003", JobTitle = "Chef", Department = "Kitchen", Salary = 35000m, StartDate = new DateTime(2020, 11, 1) });
            hotelStaff.Add(new Manager { Name = "Eva Karlsson", Age = 50, EmployeeId = "M003", Department = "HR", Salary = 58000m, StartDate = new DateTime(2015, 2, 1), BonusPercentage = 0.25m });
            hotelStaff.Add(housekeeper1);

            Console.WriteLine("Hotel staff:");
            foreach (var person in hotelStaff)
            {
                person.PrintInfo();
                person.Introduce();


                if (person is Manager m)
                {
                    m.HoldMeeting();
                    m.AssignTeam(10);
                    m.CalculateBonus();

                }
                else if (person is Employee e)
                {
                    e.DoWork();
                }
                else if (person is Consultant c)
                {
                    c.GiveAdvice();
                }

                Console.WriteLine("\n\n");
            }

            double averageAge = hotelStaff.Average(p => p.Age);
            decimal totalSalary = hotelStaff.Sum(p => p.Salary);

            Console.WriteLine($"Average age in the staff: {averageAge:F1} år");
            Console.WriteLine($"Total monthly salary: {totalSalary:C}");

            foreach (var person in hotelStaff) 
            {
                person.DoWork();
                
            }

            Console.WriteLine("\n\n");

        }
    }
}


