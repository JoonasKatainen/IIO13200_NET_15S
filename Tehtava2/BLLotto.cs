using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Lotto
    {

        public int tyyppi;
        private int pieninnumero;
        private int suurinnumero;
        private int maara;
        Random r = new Random();
        public int[] ArvoRivi(int tyyppi)
        {
            this.tyyppi = tyyppi;
            
            int[] asd;
            switch (tyyppi) {
                case(0):
                    asd = new int[7];
                    for(int i = 0; i <= 6; i++)
                    {
                        asd[i] = r.Next(1, 40);
                    }
                    return asd;
                    break;
                case (1):
                    asd = new int[6];
                    for (int i = 0; i <= 5; i++)
                    {
                        asd[i] = r.Next(1, 49);
                    }
                    return asd;
                    break;
                case (2):
                    asd = new int[7];
                    for (int i = 0; i <= 4; i++)
                    {
                        asd[i] = r.Next(1, 51);
                    }
                    for(int i = 5; i <=6; i++)
                    {
                        asd[i] = r.Next(1, 11);
                    }
                    return asd;
                    break;
                default:
                    asd = new int[7];
                    return asd;
                    break;
            }

            
        }
    }
}
