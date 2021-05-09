using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_01_04
{
    class Program
    {
        static void Main(string[] args)
        {

            People people = new People();

            Console.WriteLine("Введите Имя: ");
            people.FirstName = Console.ReadLine();

            Console.WriteLine("Введите Фамилию: ");
            people.LastName = Console.ReadLine();

            Console.WriteLine("Введите Отчество: ");
            people.Patronymic = Console.ReadLine();

            people.GetFullName();


        }
    }
}
