using homeworkLib;

namespace InterestDeposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = IO.GetNumber("Введите сумму вклада: ", 1);
            ReportInterestByMounth(deposit); 
            ReportAmountByMounth(deposit);

        }

        static void ReportInterestByMounth(double deposit, int mounth = 1, int mounthCount = 10, double interestRate = 0.02) 
        {
            double increase = Math.Round(deposit * interestRate, 2);
            Console.WriteLine($"Прирост за {mounth}й месяц составит: {increase}");
            
            if (mounth < mounthCount)
                ReportInterestByMounth(Math.Round(deposit += increase, 2), ++mounth);
        }

        static void ReportAmountByMounth(double deposit, int mounth = 0, int startMounth = 3, int endMounth = 12, double interestRate = 0.02)
        {
            if (mounth > endMounth) return;
            
            if (mounth >= startMounth)
                Console.WriteLine($"Сумма вклада через {mounth} месяца(ов) будет: {deposit}");
            deposit += deposit * interestRate;

            ReportAmountByMounth(Math.Round(deposit, 2), ++mounth);

        }
    }
}
