using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over_Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance atb = new Distance(245, 700);
            Distance btc = new Distance(248,500);
            Distance atc = atb + btc;
            atc.disp();
        }
    }
}
