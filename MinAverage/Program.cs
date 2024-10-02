namespace MinAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = [95, 922, 73, 499, 561, 61, 700, 887, 98, 150, 846];
            int sum = 0;
            int min = ints[0];

            foreach (int i in ints)
            {
                sum += i;
                if (i < min) min = i;
            }
            Console.WriteLine($"min = {min}, average = {sum / ints.Length}");
        }
    }
}
