using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice6
{
    public abstract class GeometricShapes
    {
        public double Width { get; set; }        //Genişlik
        public double Height { get; set; }


        public virtual double CalculateArea()           //Alan hesaplamak için base metot
        {
            double area = Width * Height;
            Console.WriteLine(area);

            return area;
        }

    }
}
