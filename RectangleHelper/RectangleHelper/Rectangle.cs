namespace RectangleHelper
{
    public class Rectangle
    {

        private readonly float width;
        private readonly float height;

        public Rectangle (float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Perimeter()
        {
            return (width + height) * 2.0f;
        }

        public float Square()
        {
            return width * height;
        }
    }
}
