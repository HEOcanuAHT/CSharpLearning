using homeworkLib;

namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = IO.GetNumber("Введите делимое: ");

            int b = IO.GetNumber("Введите делитель: ");
            if (b == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
                return;
            }
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} остаток {remainder}");
        }
    }
}
