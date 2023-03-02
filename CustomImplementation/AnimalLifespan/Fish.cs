namespace AnimalLifespan
{
    public class Fish : Animal
    {
        public Fish()
        {
            this.Energy = this.MaxEnergy;

            this.Diet = new List<Food>()
            {
                Food.Algae,
                Food.Worms,
                Food.Plankton,
            };

            Console.WriteLine($"{nameof(Fish)} starts with => {this.MaxEnergy} and his died is {string.Join(", ", this.Diet)}");
        }

        public override IReadOnlyList<Food> Diet { get; }

        public override int MaxEnergy => 2;
    }
}
