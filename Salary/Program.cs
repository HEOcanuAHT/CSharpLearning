using homeworkLib;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel = {
            {1,1,1,1,1,1,2,2,2,2,2,2 },
            {1,1,1,1,1,1,2,2,2,2,2,2 },
            {1,1,1,1,1,1,2,2,2,2,2,2 },
            {1,1,1,1,1,1,2,2,2,2,2,2 },
            {1,1,1,1,1,1,2,2,2,2,2,2 },
            {2,2,2,2,2,2,3,3,3,3,3,3 }, // это тим лид, зп больше и в середине года индексация была
            {5,5,5,5,5,5,6,6,6,6,6,6 }, // СТО
            };

            var mounth = IO.GetNumber("Введите номер месяца (1-12):", 1, 12);
            int total = 0;
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                total += tabel[i, mounth-1];
            }
            Console.WriteLine("Фонд заработной платы за указанный месяц составил: " + total);
        }
    }
}
