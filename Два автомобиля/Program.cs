namespace Два_автомобиля
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость первого автомобиля: ");
            int V1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите скорость второго автомобиля: ");
            int V2 = Convert.ToInt32(Console.ReadLine());

            if (V1 == V2) {Console.WriteLine("Скорости автомобилей совпадают, никто никого не опередит!"); return; };

            Console.Write("Введите расстояние с которого начнем отчет: ");
            int S = Convert.ToInt32(Console.ReadLine());

            int res = S + (Math.Abs(V1 - V2) / 2);

            Console.WriteLine("Через пол часа между ними будет " + res + "км.");
        }
    }
}
