using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        //Member Variables (HAS A)
        public ISweepStakesManaager _manager;
        //Constructor
       public MarketingFirm(ISweepStakesManaager manager)
        {
            this._manager = manager;
        }

        //Member Methods (CAN DO)
        public void CreateSweepStakes()
        {
            SweepStakes sweepStakes = new SweepStakes();
            string name = UserInterface.GetUserInput("Please enter a name for you Sweepstakes.");
            sweepStakes.NameThisSweepStakes(name);
        }
        public void RunSweepStakes()
        {
            SweepStakes sweepStakes = _manager.GetSweepStakes();
        }
    }
}
