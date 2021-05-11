using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Введите число Фибоначчи, а я Вам напищу элкскнт числовой последовательности: ");
            string fib=Console.ReadLine();
            int fibonacci = Convert.ToInt32( fib);

            GetFront(fibonacci);
            GetFibonacci(fibonacci);


        }


        static int GetFibonacci(int number)
        {
            if (number == 1) // терминальное условие
            {
                return number;
            }
            return number * GetFibonacci(number - 1); // рекурсивный вызов

            Console.WriteLine(number);
        }

        static int GetFront(int number)
        {
            int number1 = 0;
            int number2 = 1;

            int numberN = number1 + number2;

            if (numberN==1)
            {
                return numberN;
            }
            return numberN + GetFront(numberN);


        }

    }
}
