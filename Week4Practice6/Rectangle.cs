using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice6
{
    public class Rectangle : GeometricShapes             //Dikdörtgen classı
    {
        public override double CalculateArea()
        {
            Console.Write("Dikdörtgenin Alani : ");
            return base.CalculateArea();        //base motot aynen kullanıldı
        }
    }
}
