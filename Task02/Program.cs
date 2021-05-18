using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел разделив их пробелами: ");
             string strNum = Console.ReadLine();

            int[] number  = strNum.Split(' ').Select(x => int.Parse(x)).ToArray();

            int sumNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sumNumber += number[i];
            }



            Console.WriteLine($"Э-мм, сейчас попробую угадать... какая же сумма будет)))");
            Thread.Sleep(300);
            Console.Write(" . ");
            Thread.Sleep(300);
            Console.Write(" . ");
            Thread.Sleep(300);
            Console.Write(" . ");
            Console.WriteLine($"Может быть {sumNumber}");




        }
    }
}
