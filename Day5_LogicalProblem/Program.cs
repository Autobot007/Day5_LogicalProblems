namespace Day5_LogicalProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem");
            Console.WriteLine("==========================");


            Console.WriteLine("\n\n Enter Number to run program\n\n 1.Flip Coin \n");
            int entry= Convert.ToInt32(Console.ReadLine());

            switch (entry)
            {
                case 1:
                    FlipCoin.FlipPercent();
                    break;
                case 2:

                    break;
            }
        }
    }
}