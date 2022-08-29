namespace Day5_LogicalProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem");
            Console.WriteLine("==========================");


            Console.WriteLine("\n\n Enter Number to run program\n\n1.Flip Coin \n2.Leap Year");
            int entry= Convert.ToInt32(Console.ReadLine());

            switch (entry)
            {
                case 1:
                    FlipCoin.FlipPercent();
                    break;
                case 2:
                    LeapYear.LeapYearMethod();
                    break;
            }
        }
    }
}