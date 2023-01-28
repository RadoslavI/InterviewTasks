using System;
using System.Text;
using System.Transactions;

namespace AnimalLifespan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Creating foxes and adding them to a list
            Fox fox1 = new Fox(6);
            Fox fox2 = new Fox(7);
            Fox fox3 = new Fox(8);
            var foxes = new List<Fox>
            {
                fox1,
                fox2,
                fox3
            };

            //Creating bunnies and adding them to a list
            Bunny bunny1 = new Bunny(5);
            Bunny bunny2 = new Bunny(6);
            Bunny bunny3 = new Bunny(7);
            var bunnies = new List<Bunny>
            {
                bunny1,
                bunny2,
                bunny3
            };

            //Creating bears and adding them to a list.
            Bear bear1 = new Bear(7);
            Bear bear2 = new Bear(8);
            Bear bear3 = new Bear(9);
            var bears = new List<Bear>
            {
                bear1,
                bear2,
                bear3
            };

            //Creating a list of animals and adding all of the animal collections
            var animals = new List<Animal>();
            animals.AddRange(bears);
            animals.AddRange(bunnies);
            animals.AddRange(foxes);

            var rnd = new Random();

            while (animals.Any(a => a.CurrEnergy != 0))
            {
                animals.ForEach(f => f.Feed((Foods)rnd.Next(Enum.GetNames(typeof(Foods)).Length)));
            }

            Console.WriteLine("=======Animal statistics=======");
            Console.WriteLine("Bunnies: ");
            Console.WriteLine($"Minimum lifespan = {bunnies.Min(b => b.DaysSurvived)}");
            Console.WriteLine($"Maximum lifespan = {bunnies.Max(b => b.DaysSurvived)}");
            Console.WriteLine($"Avarage lifespan = {bunnies.Average(b => b.DaysSurvived):f2}");
            Console.WriteLine("=================");
            Console.WriteLine("Bears: ");
            Console.WriteLine($"Minimum lifespan = {bears.Min(b => b.DaysSurvived)}");
            Console.WriteLine($"Maximum lifespan = {bears.Max(b => b.DaysSurvived)}");
            Console.WriteLine($"Avarage lifespan = {bears.Average(b => b.DaysSurvived):f2}");
            Console.WriteLine("=================");
            Console.WriteLine("Foxes: ");
            Console.WriteLine($"Minimum lifespan = {foxes.Min(b => b.DaysSurvived)}");
            Console.WriteLine($"Maximum lifespan = {foxes.Max(b => b.DaysSurvived)}");
            Console.WriteLine($"Avarage lifespan = {foxes.Average(b => b.DaysSurvived):f2}");

        }
    }
}