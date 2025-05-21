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
        //TODO maybe change to floating point. Not needed right now because no caluculation is done.
        private string sallary;
        public Employee(string surname, string lastname, string sallary) 
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

        public string GetSallary()
        {
            return sallary;
        }

        public string PrintEmployee()
        {
            return $"{surname} {lastname} {sallary}";
        }

    }
}
