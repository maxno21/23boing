using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body3D_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Body3D[] myArr = new Body3D[3];
            myArr[0] = new Ball(5);
            myArr[1] = new Tetrahedron(6,6,6,6,6,6);
            myArr[2] = new RectangularParall(5, 10, 15);

            foreach (Body3D obj in myArr)
            {
                Console.WriteLine("Объект: {3} \n Площадь поверхности: {0}, Объем: {1}, Сумма ребер: {2}\n", obj.AreaBody(), obj.VolumeBody(),
                    obj.SumRibBody(), obj);
            }

            Console.ReadLine();
        }
    }
}
