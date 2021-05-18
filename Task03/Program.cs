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
            int monthInt = 0;
            

            do
            {
                Console.WriteLine("Введите номер месяца года, числом от 1-12: ");

                string month = Console.ReadLine();
                try
                {
                    monthInt = Convert.ToInt32( month);
                }
                catch (Exception)
                {
                }
            } while (!(0<monthInt&& monthInt<12));

            GetSeason( monthInt);

            GetSeasonName(yourSeason);

            Console.WriteLine($"Вы выбрали время года '{SeasonRus}' ");
        }

        /// <summary>
        /// Определяет сезон по номеру месяца
        /// </summary>
        /// <param name="monthNumber">номер месяца от 1 до 12</param>
        /// <returns>Значение сезона</returns>
        public static Season GetSeason(int monthNumber)
        {
            if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
                return yourSeason= Season.Winter;

            else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
                return yourSeason = Season.Spring;

            else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
                return yourSeason = Season.Summer;

            else 
                return yourSeason = Season.Autumn;
            
        }
        static string SeasonRus;
        private static Season yourSeason;
        


        /// <summary>
        /// Определяет название сезона
        /// </summary>
        /// <param name="season">Значение сезона для которого необходимо получить название</param>
        /// <returns>Строка содержащая название сезона</returns>
        public static string GetSeasonName(Season season)
        {
            if (season== Season.Winter)
            {
                return SeasonRus = "Зима";
            }
            else if (season == Season.Spring)
            {
                return SeasonRus = "Весна";
            }
            else if (season == Season.Summer)
            {
                return SeasonRus = "Лето";
            }
            else 
            {
                return SeasonRus = "Осень";
            }
        }
    }
}
