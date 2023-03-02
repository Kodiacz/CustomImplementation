using AnimalLifespan;

var rabbit = new Rabbit();
var wolf = new Wolf();
var fish = new Fish();
var frog = new Frog();

var random = new Random();

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    int foodForRabbit = random.Next(1, 12);
    int foodForWolf = random.Next(1, 12);
    int foodForFish = random.Next(1, 12);
    int foodForFrog = random.Next(1, 12);

    rabbit.Feed((Food)foodForRabbit);

    wolf.Feed((Food)foodForWolf);

    fish.Feed((Food)foodForFish);

    frog.Feed((Food)foodForFrog);

    Console.WriteLine(new String('=', 50));
}
