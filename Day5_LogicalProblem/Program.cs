namespace Day5_LogicalProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem");
            Console.WriteLine("==========================");


            Console.WriteLine("\n\n Enter Number to run program\n\n1.Flip Coin \n2.Leap Year\n3.Power of 2");
            int entry= Convert.ToInt32(Console.ReadLine());

            switch (entry)
            {
                case 1:
                    FlipCoin.FlipPercent();
                    break;
                case 2:
                    LeapYear.LeapYearMethod();
                    break;
                case 3:
                    PowerOf2.PowerOfTwo();
                    break;

            }
        }
    }
}