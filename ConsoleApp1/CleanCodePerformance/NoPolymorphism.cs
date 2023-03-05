namespace ConsoleApp1;

public class NoPolymorphism
{
    public static List<shape_union> ShapesStruct = new()
    {
        new shape_union(shape_type.Shape_Square, 4f, 4f),
        new shape_union(shape_type.Shape_Rectangle, 13.4f, 84.6f),
        new shape_union(shape_type.Shape_Triangle, 49f, 79f),
        new shape_union(shape_type.Shape_Circle, 74.1f, 79f)
    };

    public enum shape_type
    {
        Shape_Square,
        Shape_Rectangle,
        Shape_Triangle,
        Shape_Circle
    }

    public struct shape_union
    {
        public shape_union(shape_type _Type, float _Width, float _Height)
        {
            Type = _Type;
            Width = _Width;
            Height = _Height;
        }
        
        public shape_type Type;
        public float Width;
        public float Height;
    }

    public static float TotalAreaSwitch(shape_union Shape)
    {
        var result = 0f;

        switch (Shape.Type)
        {
            case shape_type.Shape_Square:
                result = Shape.Width * Shape.Height;
                break;
            case shape_type.Shape_Rectangle:
                result = Shape.Width * Shape.Height;
                break;
            case shape_type.Shape_Triangle:
                result = 0.5f * Shape.Width * Shape.Height;
                break;
            case shape_type.Shape_Circle:
                result = float.Pi * Shape.Width * Shape.Width;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return result;
    }
}