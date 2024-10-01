namespace ArrayFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            PrintNumbers(numbers);

            Reverse(ref numbers);
            PrintNumbers(numbers);

        }
        static int[] GenerateNumbers(int lenght = 10)
        {
            int[] ints = new int[lenght];
            Random rnd = new Random();
            
            for (int i = 0; i < lenght; i++) ints[i] = rnd.Next(1, 40);

            return ints;                
        }
        static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine("источник [{0}]", string.Join(", ", numbers));
        }
        static void Reverse(ref int[] numbers)
        {
            int[] reversed = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[numbers.Length - 1 - i] = numbers[i];
            }

            numbers = reversed;
        }
    }
}
