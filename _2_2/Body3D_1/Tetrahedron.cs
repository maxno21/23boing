using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body3D_1
{
    class Tetrahedron:Body3D
    {
        double ArTetrah, PolPer;
        double VolTetrah;
        double SumRibTetrah;

        public double a { set; get; }
        public double b { set; get; }
        public double c { set; get; }
        public double n { set; get; }
        public double m { set; get; }
        public double l { set; get; }

        public Tetrahedron(double a, double b, double c, double n, double m, double l)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.n = n;
            this.m = m;
            this.l = l;
        }

        public override double AreaBody()
        {
            PolPer = (a + b + c)/2;
            ArTetrah = 4*Math.Sqrt(PolPer*(PolPer-a)*(PolPer-b)*(PolPer-c));
            return ArTetrah;
        }

        public override double VolumeBody()
        {
            VolTetrah = Math.Sqrt(4*a*b*c*n*m*l/288);
            return VolTetrah;
        }
        public override double SumRibBody()
        {
            SumRibTetrah = a+b+c+n+m+l;
            return SumRibTetrah;
        }
    }
}
