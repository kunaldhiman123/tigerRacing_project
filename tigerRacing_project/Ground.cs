using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigerRacing_project
{
   public  class Ground
    {
        public int lastPoint()
        {
            return 680;
        }

        public int winner(String optn, int Winner, int Budget)
        {
            String[] data = optn.Split(' ');
            int Chetah = Convert.ToInt32(data[2].ToString());
            int betAmount = Convert.ToInt32(data[6].ToString());
            if (Chetah == Winner)
            {
                return Budget + betAmount;
            }
            else
            {
                return Budget - betAmount;
            }
        }

    }
}
