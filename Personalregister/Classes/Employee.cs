using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister.Classes
{
    internal class Employee
    {
        private string surname;
        private string lastname;
        //TODO maybe change to floating point.
        private int sallary;
        public Employee(string surname, string lastname, int sallary) 
        {
            this.surname = surname;
            this.lastname = lastname;
            this.sallary = sallary;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetLastname()
        {
            return lastname;
        }

        public int GetSallary()
        {
            return sallary;
        }

    }
}
