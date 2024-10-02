namespace homeworkLib;

public static class IO
{
    public static int GetNumber(string Message, int min = int.MinValue, int max = int.MaxValue)
    {
        int result;

        string? input;
        do
        {
            Console.WriteLine(Message);
            input = Console.ReadLine();
        } 
        while (!int.TryParse(input, out result) || result < min || result > max);
         
        return result;
    }
}
