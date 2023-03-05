namespace ConsoleApp1;

public class NoInternals
{
    public shape_union[] ShapesArray;

    public NoInternals()
    {
        ShapesArray = new shape_union[100_000];

        for (int i = 0; i < ShapesArray.Length; i+=4)
        {
            ShapesArray[i] = new shape_union(shape_type.Shape_Square, 4f, 4f);
            ShapesArray[i + 1] = new shape_union(shape_type.Shape_Rectangle, 13.4f, 84.6f);
            ShapesArray[i + 2] = new shape_union(shape_type.Shape_Triangle, 49f, 79f);
            ShapesArray[i + 3] = new shape_union(shape_type.Shape_Circle, 74.1f, 79f);
        }
    }

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