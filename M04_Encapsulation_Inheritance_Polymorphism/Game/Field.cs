namespace Game
{
    class Field
    {
        private int width;
        private int height;

        public Field (int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width { get => width; }
        public int Height { get => height; }
    }
}
