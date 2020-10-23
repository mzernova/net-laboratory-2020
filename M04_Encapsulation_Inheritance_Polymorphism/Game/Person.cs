namespace Game
{
    abstract class Person
    {
        protected Location position;
        protected int healthPoints;
        protected int damagePoints;

        protected Person (Location position, int healthPoints, int damagePoints)
        {
            this.position = position;
            this.healthPoints = healthPoints;
        }

        public Location Position { get => position; }

        public int HealthPoints { get => healthPoints; }

        public void EatFruit(int healthPoints)
        {
            this.healthPoints += healthPoints;
        }

        public void Hit (int damagePoints)
        {
            this.healthPoints -= damagePoints;
            if (this.healthPoints <= 0)
            {
                Dead();
            }
        }

        public void Dead()
        {
            // erase character from screen
        }

        public void Up()
        {
            position.Y++;
        }

        public void Up(int step)
        {
            position.Y += step;
        }

        public void Down()
        {
            position.Y--;
        }

        public void Down(int step)
        {
           position.Y -= step;
        }

        public void Right()
        {
            position.X++;
        }

        public void Right(int step)
        {
            position.X += step;
        }

        public void Left()
        {
            position.X--;
        }

        public void Left(int step)
        {
            position.X -= step;
        }
    }
}
