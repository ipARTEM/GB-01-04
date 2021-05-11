using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_01_04
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

 

        public void GetFullName()
        {
            Console.WriteLine($" Имя: {FirstName}, Фамилия: {LastName}, Отчество: {Patronymic}");

        }

    }
}
