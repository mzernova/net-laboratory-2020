namespace Game
{
    abstract class Bonus : Object
    {
        private int bonusPoints;

        protected Bonus (Location position, int bonusPoints) : base (position)
        {
            this.bonusPoints = bonusPoints;
        }

        public int BonusPoints { get => bonusPoints; }
    }
}
