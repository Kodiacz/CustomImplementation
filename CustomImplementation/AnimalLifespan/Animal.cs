namespace AnimalLifespan
{
    public abstract class Animal
    {
        public abstract int Energy { get; }

        public abstract IReadOnlyCollection<Food> Diet { get; }

        public abstract void Feed(Food food);
    }
}
