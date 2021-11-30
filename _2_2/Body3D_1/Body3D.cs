using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body3D_1
{
    abstract class Body3D
    {
        // H, V, S; Прямоугольный пареллелепипед, Rectangular Parallelepiped. Рёбра
        // R; Шар, Ball. Радиус
        // a, b, c, l, m, n; Тетраэдр, Tetrahedron. Рёбра

        
        abstract public double AreaBody();
        abstract public double VolumeBody();
        abstract public double SumRibBody();
    }
}
