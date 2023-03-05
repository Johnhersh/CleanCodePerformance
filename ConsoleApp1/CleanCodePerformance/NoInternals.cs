namespace ConsoleApp1;

public class NoInternals
{
    public static List<shape_union> ShapesStruct = new()
    {
        new shape_union(shape_type.Shape_Square, 4f, 4f),
        new shape_union(shape_type.Shape_Rectangle, 13.4f, 84.6f),
        new shape_union(shape_type.Shape_Triangle, 49f, 79f),
        new shape_union(shape_type.Shape_Circle, 74.1f, 79f)
    };

    private static float[] ShapesTable = { 1.0f, 1.0f, 0.5f, float.Pi };

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

    public static float TotalAreaSwitchNoInternals(shape_union Shape)
    {
        var result = ShapesTable[(int)Shape.Type] * Shape.Width * Shape.Height;
        return result;
    }
}