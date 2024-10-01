namespace CopyingAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = new int[10];

            // fill
            Random rnd = new Random();
            for (int i = 0; i < source.Length; i++) source[i] = rnd.Next(1, 50);

            var destination = new int[10];
            // copy
            for (int i = 0; i < source.Length; i++) destination[i] = source[i];

            Console.WriteLine("источник [{0}]", string.Join(", ", source));
            Console.WriteLine("приемник [{0}]", string.Join(", ", destination));
        }
    }
}
