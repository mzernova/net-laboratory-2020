namespace Rectangle
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

        public float Width => width;
        public float Height => height;
    }
}
