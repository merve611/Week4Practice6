using Week4Practice6;

internal class Program
{
    public static void Main(string[] args)
    {
        GeometricShapes square = new Square();          //Kare nesnesi oluşturuldu
        square.Width = 12;
        square.Height = 12;
        square.CalculateArea();                         //kare nesnesinin alan hesaplama metodu çağırıldı
            
        GeometricShapes rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 6;
        rectangle.CalculateArea();


        GeometricShapes triangle = new Triangle();
        triangle.Width = 3;
        triangle.Height = 7;
        triangle.CalculateArea();
    }
}