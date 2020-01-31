using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {

        //Member   (HAS A)
        static string[] UserInformation = new string[4];
        string firstName = UserInformation[1];
        string lastName = UserInformation[2];
        string emailAddress = UserInformation[3];
        string registrationNumber = UserInformation[4];

        //Constructor
        public Contestant()
        {
            UserInterface.GetContestant

        }
        public Contestant(string firstName, string lastName, string emailAddress, string registrationNumber)
        {

        }

        //Member Methods (CAN DO)


    }
}
