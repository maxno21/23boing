using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body3D_1
{
    class RectangularParall:Body3D
    {
        public double H { get; set; }
        public double V { get; set; }
        public double S { get; set; }

        public RectangularParall (double H, double V, double S)
        {
            this.H = H;
            this.V = V;
            this.S = S;
        }
        double ArRecPar;
        double VoRecPar;
        double SumRibRecPar;
        public override double AreaBody()
        {
            ArRecPar= H * V * 2 + V * S * 2 + H * S * 2;
            return ArRecPar;
        }

        public override double VolumeBody()
        {
            VoRecPar = H * V * S;
            return VoRecPar;
        }
        public override double SumRibBody ()
        {
            SumRibRecPar = (H + V + S) * 4;
            return SumRibRecPar;
        }
    }
}
