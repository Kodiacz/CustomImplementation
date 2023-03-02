namespace AnimalLifespan
{
    public abstract class Animal
    {
        public abstract int MaxEnergy { get; }

        public virtual int Energy { get; protected set; }

        public abstract IReadOnlyCollection<Food> Diet { get; }

        public void Feed(Food food)
        {
            if (this.Diet.Contains(food) && this.Energy > 0)
            {
                if (this.Energy + 1 <= this.MaxEnergy)
                {
                    this.Energy++;
                }
            }
            else
            {
                if (this.Energy > 0)
                {
                    this.Energy--;

                    if (this.Energy == 0)
                    {
                        Console.WriteLine($"The {this.GetType().Name} died");
                    }
                }
                else
                {
                    Console.WriteLine($"The {this.GetType().Name} is dead");
                }
            }

            Console.WriteLine($"{this.GetType().Name} was fed by {food} => {this.Energy}");
        }
    }
}
