namespace AnimalLifespan
{
    public class Rabbit : Animal
    {
        private readonly int maxEnergy;
        private int energy;

        public Rabbit(int maxEnergy)
        {
            this.maxEnergy = maxEnergy;
            this.energy = maxEnergy;

            this.Diet = new List<Food>()
            {
                Food.Hay,
                Food.Basil,
                Food.BokChoy,
                Food.Celery,
            };
        }

        public override int Energy => this.energy;

        public override IReadOnlyList<Food> Diet { get; }

        public override void Feed(Food food)
        {
            if (this.Diet.Contains(food))
            {
                if (this.Energy + 1 < this.maxEnergy)
                {
                    this.energy++;
                }
            }
            else
            {
                if (this.energy > 0)
                {
                    this.energy--;
                }

                if (this.energy == 0)
                {
                    Console.WriteLine("The animal died");
                }
            }
        }
    }
}
