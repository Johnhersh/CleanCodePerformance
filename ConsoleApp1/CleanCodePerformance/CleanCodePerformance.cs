namespace ConsoleApp1;

public class CleanCodePerformance
{
    public static Shape[] ShapesArray;

    public CleanCodePerformance()
    {
        ShapesArray = new Shape[100_000];

        for (int i = 0; i < 100_000; i+=4)
        {
            ShapesArray[i] = new Square(4f);
            ShapesArray[i + 1] = new Rectangle(13.4f, 84.6f);
            ShapesArray[i + 2] = new Triangle(49f, 79f);
            ShapesArray[i + 3] = new Circle(74.1f);
        }
    }
}



public abstract class Shape
{
    protected Shape() { }
    public abstract float Area();
}

public class Square : Shape
{
    private float _Sides;
    public Square(float Sides)
    {
        _Sides = Sides;
    }
    
    public override float Area()
    {
        return _Sides * _Sides;
    }
}

public class Rectangle : Shape
{
    private float _width;
    private float _height;
    
    public Rectangle(float Width, float Height)
    {
        _width = Width;
        _height = Height;
    }
    
    public override float Area()
    {
        return _width * _height;
    }
}

public class Triangle : Shape
{
    private float _base;
    private float _height;
    
    public Triangle(float Base, float Height)
    {
        _base = Base;
        _height = Height;
    }
    
    public override float Area()
    {
        return 0.5f * _base * _height;
    }
}

public class Circle : Shape
{
    private float _radius;

    public Circle(float Radius)
    {
        _radius = Radius;
    }
    
    public override float Area()
    {
        return float.Pi * _radius * _radius;
    }
}