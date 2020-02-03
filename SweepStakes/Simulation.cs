using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Simulation
    {

        //Member Variables (HAS A)
        
        //Constructor
        public Simulation()
        {

        }

        //Member Methods (CAN DO)

        public void RunSimulation()
        {
            CreateMarketingFirmWithManager();
        }
        void CreateMarketingFirmWithManager()
        {
            ISweepStakesManaager manager;
            switch (UserInterface.GetUserInput("Choose Your Manager: Stack or Queue.").ToLower())
            {
                case "stack":
                    manager = new SweepStakesStackManager();
                    MarketingFirm Mf = new MarketingFirm(manager);
                    break;
                case "queue":
                    manager = new SweepStakesQueueManager();
                    Mf = new MarketingFirm(manager);
                    break;
                default:
                    CreateMarketingFirmWithManager();
                    break;
            }

            

        }
    }
}
