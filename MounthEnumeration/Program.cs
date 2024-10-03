using homeworkLib;

namespace MounthEnumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mounthIndex = IO.GetNumber("Введите номер месяца (1-12), название которого хотите узнать: ", 1, 12);
            Console.WriteLine((Mounth)mounthIndex);
        }
    }
    public enum Mounth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
