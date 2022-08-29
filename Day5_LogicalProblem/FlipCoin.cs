using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_LogicalProblem
{
    internal class FlipCoin
    {

        public static void FlipPercent() {
            int head = 0;
            int tail = 0;

            Console.WriteLine("Enter the number of time you want to flip");
            int numberOfFlip =Convert.ToInt16(Console.ReadLine());

            while (numberOfFlip <= 0)
            {
                Console.WriteLine("Please Enter Valid Entry");
                Console.WriteLine("Please enter again");
                numberOfFlip = Convert.ToInt16(Console.ReadLine());
            }

            for(int i = 0; i < numberOfFlip; i++)
            {
                Random flip = new Random();
                int value = flip.Next(0, 2);

                if (value < 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }

            }
            float headPercent = (float)head * 100 / numberOfFlip;
            float tailPercent = (float)tail * 100 / numberOfFlip;


            Console.WriteLine(headPercent + "% of time result was head");
            Console.WriteLine(tailPercent + "%of time result was tail");    


                
        }


    }
}
