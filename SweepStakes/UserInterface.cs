using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {

        //Member Variables (HAS A)
       
        //Constructor

        //Member Methods (CAN DO)
        public static Contestant GetContestantInformation()
        {
            Console.WriteLine("Please enter your information to enter our sweepstakes:\n" +
               "First Name:\n" +
               "Last Name:\n" +
               "Email Address:");
            return new Contestant { firstName = Console.ReadLine(), lastName = Console.ReadLine(), emailAddress = Console.ReadLine()};
        }
        public static int GetRandomInteger(int min, int max, Random random)
        {
            int randInteger = random.Next(min, max);
            return randInteger;
        }


    }
}
