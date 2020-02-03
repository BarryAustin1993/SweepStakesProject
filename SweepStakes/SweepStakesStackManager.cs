using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesStackManager : ISweepStakesManaager
    {

        //Member Variables (HAS A)
        Stack<SweepStakes> stack = new Stack<SweepStakes>();

        //Constructor
        public SweepStakesStackManager()
        {
           
        }

        //Member Methods (CAN DO)
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
             SweepStakes topOfStack = stack.Pop();
            return topOfStack;
        }
    }
}
