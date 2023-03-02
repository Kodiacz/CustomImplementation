namespace AnimalLifespan
{
    public class Frog : Animal
    {
        public Frog()
        {
            this.Energy = this.MaxEnergy;

            this.Diet = new List<Food>()
            {
                Food.Insects,
                Food.Snails ,
                Food.Slugs ,
            };

            Console.WriteLine($"{nameof(Frog)} starts with => {this.MaxEnergy} and his died is {string.Join(", ", this.Diet)}");
        }

        public override IReadOnlyList<Food> Diet { get; }

        public override int MaxEnergy => 4;
    }
}
