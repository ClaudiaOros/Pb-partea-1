using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavage
{
    public static class Pavage
    {
        public static int CalculateFormulaForPavage(int mLength, int nWidth, int aStone)
        {
            int formula = Math.Round(double)(mLength / aStone) * (nWidth / aStone);
            return formula;
        }

    }
}
