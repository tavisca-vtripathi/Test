using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over_Loading
{
    class Distance
    {
        int km, m;
        public Distance()
        { 
        }
        public Distance(int km, int m)
        {
            this.km = km;
            this.m = m;
        
        }
        public void disp()
        {
            Console.WriteLine("Km={0}", km);
            Console.WriteLine("m={0}",m);

        }
        public static Distance operator +(Distance l1, Distance l2)
        {
            Distance l3 = new Distance();
            l3.km = l1.km + l2.km;
            l3.m = l1.m + l2.m;
            if (l3.m >= 1000)
            {
                l3.km++;
                l3.m = l3.m - 1000;
            }
            return l3;
        }
    }
}
