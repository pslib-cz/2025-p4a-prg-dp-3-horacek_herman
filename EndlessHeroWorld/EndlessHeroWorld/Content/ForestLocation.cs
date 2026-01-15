using EndlessHeroWorld.Game;

namespace EndlessHeroWorld.Content
{
    public class ForestLocation : ILocation
    {
        public string Name => "Enchanted Forest";

        public IEnemy GenerateEnemy()
        {
            return new Goblin(); 
        }
    }
}
