using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo
{
    internal class DiagPerim
    {
        public double H;
        public double B;

        public double CalcularArea()
        {
            return H * B;
        }

        public double CalcularPerimetro()
        {
            return 2 * (B + H);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(B * B + H * H);
        }

    }
}
