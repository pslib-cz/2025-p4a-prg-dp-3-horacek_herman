using EndlessHeroWorld.Game;
using System;

namespace EndlessHeroWorld.Content
{
    public class Goblin : IEnemy
    {
        public string Name => "Goblin";

        public void Attack()
        {
            Console.WriteLine("Goblin pohlédne na hrdinu zlobně a škrábe ho!");
        }
    }
}
