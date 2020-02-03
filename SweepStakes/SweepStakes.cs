using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {

        //Member Variables (HAS A)
        Dictionary<int, Contestant> contestants;
        string sweepStakesName;
        int registrationNumber = 0;
        int winner;

        string SweepStakesName
        {
            get
            {
               return sweepStakesName;
            }
        }
        //Constructor
        SweepStakes()
        {

        }
        //Member Methods (CAN DO)

        void registerContestant(Contestant contestant)
        {
            registrationNumber++;
            contestant.registrationNumber = this.registrationNumber;
            contestants.Add(registrationNumber, contestant);
        }
        void ChooseTheWinningContestant()
        {
           Random random = new Random();
           winner = UserInterface.GetRandomInteger(0, registrationNumber + 1, random);
        }
        void PrintContestantInfo()
        {

        }
    }
}
