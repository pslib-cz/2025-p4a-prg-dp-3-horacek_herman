using EndlessHeroWorld.Game;
using System;

namespace EndlessHeroWorld.Content
{
    public class Bat : IEnemy
    {
        public string Name => "Cave Bat";

        public void Attack()
        {
            Console.WriteLine("Bat krouží kolem hrdiny a kousá ho křídly!");
        }
    }
}
