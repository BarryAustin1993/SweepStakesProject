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
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //Constructor
        public Contestant()
        {
            UserInterface.GetContestantInformation();
        }

        //Member Methods (CAN DO)

            

    }
}
