using System.Diagnostics;

namespace RectangleHelper
{
    public class RectangleHelper
    {
        public static float Perimeter (Rectangle.Rectangle rect)
        {
            Debug.Assert (rect != null, "Wrong rectangle");
            return (rect.Width + rect.Height) * 2.0f;
        }

        public static float Square (Rectangle.Rectangle rect)
        {
            Debug.Assert (rect != null, "Wrong rectangle");
            return rect.Width * rect.Height;
        }
    }
}
