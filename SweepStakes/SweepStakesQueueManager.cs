using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesQueueManager : ISweepStakesManaager
    {

        //Member Variables (HAS A)
        Queue<SweepStakes> queue = new Queue<SweepStakes>();

        //Constructor
        public SweepStakesQueueManager()
        {

        }
        //Member Methods (CAN DO)
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            queue.Enqueue(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
            SweepStakes startOfQueue = queue.Dequeue();
            return startOfQueue;        
        }
    }
}
