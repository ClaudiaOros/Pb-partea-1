using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciuperci
{
    public static class Ciuperci
    {
        public static int FormulaCiuperciAlbe(int numarCiuperci, int x)
        {
            int ciuperciAlbe = numarCiuperci / (x + 1);
            return ciuperciAlbe;                
        }

        public static int FormulaCiuperciRosii(int numarCiuperciAlbe, int x)
        {
            int ciuperciRosii = x * numarCiuperciAlbe;
            return ciuperciRosii;                
        }
    }
}
      