namespace Game
{
    class Obstacle : Object
    {
        private int damagePoints;

        protected Obstacle (Location position, int damagePoints) : base (position)
        {
            this.damagePoints = damagePoints;
        }

        public int DamagePoints { get => damagePoints; }
    }
}
