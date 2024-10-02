using homeworkLib;

namespace Two_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V1 = IO.GetNumber("Введите скорость первого автомобиля: ");

            int V2 = IO.GetNumber("Введите скорость второго автомобиля: ");

            if (V1 == V2) 
            {
                Console.WriteLine("Скорости автомобилей совпадают, никто никого не опередит!"); 
                return; 
            };

            int S = IO.GetNumber("Введите расстояние с которого начнем отчет: ");

            int res = S + (Math.Abs(V1 - V2) / 2);

            Console.WriteLine("Через пол часа между ними будет " + res + "км.");
        }
    }
}
