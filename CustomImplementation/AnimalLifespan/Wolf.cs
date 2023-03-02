namespace AnimalLifespan
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            this.Energy = this.MaxEnergy;

            this.Diet = new List<Food>()
            {
                Food.RawMeat,
            };

            Console.WriteLine($"{nameof(Wolf)} starts with => {this.MaxEnergy} and his died is {string.Join(", ", this.Diet)}");
        }

        public override IReadOnlyList<Food> Diet { get; }

        public override int MaxEnergy => 8;
    }
}
