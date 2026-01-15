using EndlessHeroWorld.Game;
using EndlessHeroWorld.Content;
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

       
        LocationRegistry.RegisterLocation(new ForestLocation());
        LocationRegistry.RegisterLocation(new CaveLocation());

        Console.WriteLine("=== Welcome to Endless Hero World ===");

        while (true)
        {
            
            var locations = LocationRegistry.GetLocations();
            var currentLocation = locations[random.Next(locations.Count)];
            Console.WriteLine($"\nYou have entered: {currentLocation.Name}");

           
            var enemy = currentLocation.GenerateEnemy();
            Console.WriteLine($"An enemy appears: {enemy.Name}");
            enemy.Attack();

            Console.WriteLine("\nPress any key to move to the next location...");
            Console.ReadKey();
        }
    }
}
