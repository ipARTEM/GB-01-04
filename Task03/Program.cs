using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
        Autumn=4
    }

    class Program
    {
        static void Main(string[] args)
        {
            Сycle:


            Console.WriteLine("Введите номер месяца года, числом от 1-12: ");
            string number= Console.ReadLine();

            if (number.ToString() == "1" || number.ToString() == "2" || number.ToString() == "12")
            {
                Console.WriteLine($"Вы ввели время года: Зима - " + Season.Winter);

            }
            else if (number.ToString() == "3" || number.ToString() == "4" || number.ToString() == "5")
            {
                Console.WriteLine($"Вы ввели время года: Весна - " + Season.Spring);

            }
            else if (number.ToString() == "6" || number.ToString() == "7" || number.ToString() == "8")
            {
                Console.WriteLine($"Вы ввели время года: Весна - " + Season.Summer);

            }
            else if (number.ToString() == "9" || number.ToString() == "10" || number.ToString() == "11")
            {
                Console.WriteLine($"Вы ввели время года: Весна - " + Season.Autumn);

            }

            else goto Сycle;
        }
    }
}
