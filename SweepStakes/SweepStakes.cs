using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {

        //Member Variables (HAS A)
        Dictionary<int, Contestant> contestants;
        string sweepStakesName;
        int registrationNumber = 0;
        Contestant winner;
        public string SweepStakesName
        {
            get
            {
                return sweepStakesName;
            }
        }
        //Constructor
        public SweepStakes()
        {

        }
        //Member Methods (CAN DO)

        public void NameThisSweepStakes(string name)
        {
            sweepStakesName = name;
        }
        public void registerContestant(Contestant contestant)
        {
            registrationNumber++;
            contestant.registrationNumber = this.registrationNumber;
            contestants.Add(registrationNumber, contestant);
        }
        public Contestant ChooseTheWinningContestant()
        {
            Random random = new Random();
            int key = UserInterface.GetRandomInteger(0, registrationNumber + 1, random);
            contestants.TryGetValue(key, out winner);
            return winner;
        }
        public void PrintContestantInfo(Contestant constestant)
        {
            Console.WriteLine($"{constestant.firstName}\n" +
                $"{constestant.lastName}\n" +
                $"{constestant.emailAddress}\n" +
                $"{constestant.registrationNumber}");
            Console.ReadLine();
        }
    }
}
