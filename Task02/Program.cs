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
            Console.WriteLine("Введите любой набор символов, а я напишу сумму всех чисел: ");
            string set = Console.ReadLine();

            char[] setChar = set.ToCharArray();

            int intSet=0 ;

            for (int i = 0; i < setChar.Length; i++)
            {
                if ('0' <= setChar[i] && setChar[i] <= '9')
                {

                    int intChat=Convert.ToInt32(setChar[i].ToString());
                    intSet = intSet + intChat;

                }

            }

            Console.WriteLine($"Э-мм, сейчас попробую угадать... какая же сумма будет)))");
            Thread.Sleep(300);
            Console.Write(" . ");
            Thread.Sleep(300);
            Console.Write(" . ");
            Thread.Sleep(300);
            Console.Write(" . ");
            Console.WriteLine($"Может быть {intSet}");




        }
    }
}
