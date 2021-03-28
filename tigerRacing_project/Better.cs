using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigerRacing_project
{
    public class Better:Ground
    {
        Random random = new Random();

        public int moveChetah()
        {
            return random.Next(1, 50);
        }

    }
}
