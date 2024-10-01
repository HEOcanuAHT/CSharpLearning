namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите делимое: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите делитель: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} остаток {remainder}");
        }
    }
}
