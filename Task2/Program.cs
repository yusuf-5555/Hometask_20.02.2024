Rectangle rectangle = new Rectangle();
System.Console.Write("width: ");
rectangle.Width = Convert.ToDouble(Console.ReadLine());
System.Console.Write("height: ");
rectangle.Height = Convert.ToDouble(Console.ReadLine());
rectangle.Area();


public class Rectangle
{
    public double Width;
    public double Height;
    public void Area()
    {
        System.Console.WriteLine("Area = " + Width*Height);
    }
}
