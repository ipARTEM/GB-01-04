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
            

            Console.WriteLine("Введите число Фибоначчи, а я Вам напищу элемант числовой последовательности: ");
            Console.WriteLine("и Факториал числа: ");
            string numberStr = Console.ReadLine();

            double numberFac = Convert.ToInt32(numberStr);
            double number1 = numberFac;
            numberFac = GetFactorial(number1);
            Console.WriteLine($"Факториал числа  {number1} = {numberFac}");

            double numberFib = Convert.ToInt32(numberStr);
            double number2 = numberFib;
            numberFib=GetFibonacci(number2);
            Console.WriteLine($"Число Фибоначчи  {number2} = {numberFib}");
        }


        static double GetFactorial(double n)
        {
            if (n == 1) // терминальное условие
            {
                return n;
            }
            return n * GetFactorial(n - 1); // рекурсивный вызов
        }

        static double GetFibonacci(double number)
        {
            if (number<1)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            return GetFibonacci(number-1)+ GetFibonacci(number-2);
        }
    }
}
