using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface ISweepStakesManaager
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        void InsertSweepStakes(SweepStakes sweepStakes);
        SweepStakes GetSweepStakes();
      

    }
}
