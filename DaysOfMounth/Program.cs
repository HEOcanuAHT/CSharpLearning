using homeworkLib;

namespace DaysOfMounth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = IO.GetNumber("Введите год:");
            int mounth = IO.GetNumber("Введите месяц (1-12):");

            int index = 0;
            if (mounth == 2)
            {
                int factor = year % 100 == 0 ? 400 : 4;
                bool leapYear = year % factor == 0;

                if (leapYear)
                    index = 13;
                else 
                    index = mounth;
            }

            string res = index switch
            {
                1 => "31 день",
                2 => "28 дней",
                3 => "31 день",
                4 => "30 дней",
                5 => "31 день",
                6 => "30 дней",
                7 => "31 день",
                8 => "31 день",
                9 => "30 дней",
                10 => "31 день",
                11 => "30 дней",
                12 => "31 день",
                13 => "29 дней",
                _ => ""
            };

            Console.WriteLine("В {0} месяце {1} года : {2}!", mounth, year, res);
        }
    }
}
