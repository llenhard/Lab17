using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Prime
    {
        public static bool IsPrime(int candidate)
        {
            //shamelessly stolen from the internet
            if ((candidate & 1) == 0)//i cannot into maths
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public static int PrimeIndex(int maxIndex)
        {
            int numPrimes = 0;
            for(int i = 1; i>0; i++)
            {
                if (IsPrime(i))
                {
                    numPrimes++;
                }
                if (numPrimes == maxIndex)
                {
                    return i;
                }
            }//wont happen ever but the ide yells at me without a return at the bottom
            throw new Exception("Something bad");
        }
    }
}
