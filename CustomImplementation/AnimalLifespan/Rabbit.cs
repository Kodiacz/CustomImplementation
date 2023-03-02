namespace AnimalLifespan
{
    public class Rabbit : Animal
    {
        public Rabbit()
        {
            this.Energy = this.MaxEnergy;

            this.Diet = new List<Food>()
            {
                Food.Hay,
                Food.Basil,
                Food.BokChoy,
                Food.Celery,
            };

            Console.WriteLine($"{nameof(Rabbit)} starts with => {this.MaxEnergy} and his died is {string.Join(", ", this.Diet)}");
        }

        public override IReadOnlyList<Food> Diet { get; }

        public override int MaxEnergy => 5;
    }
}
