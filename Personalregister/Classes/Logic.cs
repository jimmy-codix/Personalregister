using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister.Classes
{

    internal class Logic
    {
        private List<Employee> employees;

        public Logic()
        {
            this.employees = new List<Employee>();
        }

        public void ShowMenu(bool doClear = false)
        {
            if (doClear)
                Console.Clear();
            CW("Personalregister (CTRL-C för att avsluta)");
            CW("_________________");
            CW("Skriv 1 för att lägga till personal.");
            CW("Skriv 2 för att visa alla i personalen.");
            string value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PrintEmployees();
                    break;
                default:
                    ShowMenu(true);
                    break;
            }
        }

        private void AddEmployee()
        {
            while (true)
            {
                CW("Förnamn:");
                string surName = Console.ReadLine();
                CW("Efternamn:");
                string lastName = Console.ReadLine();
                CW("Lön: ");
                string sallary = Console.ReadLine();

                employees.Add(new Employee(surName, lastName, sallary));
                CW($"Person inlagd: {surName} {lastName} {sallary}");
                CW("Vill du lägga till 1 person till? Skriv 1 för att fortsätta, skriv 2 för att avsluta.");
                string value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        continue;
                        break;
                    default:
                        ShowMenu(true);
                        break;
                }
            }
        }

        private void PrintEmployees()
        {
            CW("Anställda:");
            CW();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.PrintEmployee());
            }

            //Give some space
            CW();
            CW();
            ShowMenu(false);

        }

        //Just because Console.WriteLine is long.
        private void CW(string str = "")
        {
            Console.WriteLine(str);
        }

    }
}
