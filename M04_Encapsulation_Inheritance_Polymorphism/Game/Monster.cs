namespace Game
{
    abstract class Monster : Person
    {
        private int speed;
        protected Monster (Location position, int healthPoints, int damagePoints, int speed) : base (position, healthPoints, damagePoints)
        {
            this.speed = speed;
        }

        public int Speed { get => speed; }

        public void Move (Field field)
        {
            // moving algoritm
        }
    }
}
