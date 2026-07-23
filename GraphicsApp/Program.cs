namespace GraphicsApp;
public class Program{

    public static void Main(string[] args)
    {
        Point Point1 = new Point(0, 0);
        Point Point2 = new Point(3, 4);
        Point Point3 = new Point(6, 8);

         Triangle triangle = new Triangle(Point1, Point2, Point3);
         triangle.Display();

        Line line= new Line(Point1, Point3);
        line.Display();

        Point center = new Point(5, 5);
        Circle circle = new Circle(center, 10);
        circle.Display();
         
    }
}   
