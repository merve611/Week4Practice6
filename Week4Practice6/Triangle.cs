using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice6
{
    public class Triangle : GeometricShapes         //Üçgen classı
    {
        public override double CalculateArea()
        {
            Console.Write("Dik Üçgenin Alani : ");
            double area = (Width * Height) / 2;
            Console.WriteLine(area);

            return area;           //Dik üçgende diğerlerinden farklı olan bir durum olduğu için ona özel body yazıldı
            
        }
    }
}
