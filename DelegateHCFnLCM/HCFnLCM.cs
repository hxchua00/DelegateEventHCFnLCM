using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHCFnLCM
{
    class HCFnLCM
    {
        int temp, a, b, x, y, HCF, LCM;

        public HCFnLCM(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void findHCFnLCM(int x, int y)
        {
            //No change to original input
            a = x;
            b = y;

            //Finding HCF
            while (b != 0)
            {
                temp = b; //Store in temp to not lose original value
                b = a % b; //if remainder = 0, it means HCF have been reached.
                a = temp;
            }

            HCF = a;
            LCM = (x * y) / HCF;

            Console.WriteLine("HCF is " + HCF);
            Console.WriteLine("LCM is " + LCM);
        }
    }
}
