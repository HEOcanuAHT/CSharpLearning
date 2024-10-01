namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputRow;

            for (int i = 1; i <= 100; i++)
            {
                outputRow = "";

                if (i % 3 == 0) 
                    outputRow = "Fizz";

                if (i % 5 == 0) 
                    outputRow += "Buzz";

                if (outputRow.Length == 0) 
                    outputRow = i.ToString();

                Console.Write(outputRow + " ");
            }
        }
    }
}
