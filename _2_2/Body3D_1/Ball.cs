using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body3D_1
{
    class Ball:Body3D
    {
        double ArBall;
        double VoBall;
        double SumRibBall;
        public double R { get; set; }
        public Ball(double R)
        {
            this.R = R;
        }
        public override double AreaBody()
        {
            ArBall = 4*3.14*R*R;
            return ArBall;
        }

        public override double VolumeBody()
        {
            VoBall = 4*3.14*R*R*R/3;
            return VoBall;
        }
        public override double SumRibBody()
        {
            SumRibBall = 0;
            return SumRibBall;
        }
    }
}
