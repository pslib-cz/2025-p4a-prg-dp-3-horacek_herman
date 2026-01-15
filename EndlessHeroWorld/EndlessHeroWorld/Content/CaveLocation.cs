using EndlessHeroWorld.Game;

namespace EndlessHeroWorld.Content
{
    public class CaveLocation : ILocation
    {
        public string Name => "Dark Cave";

        public IEnemy GenerateEnemy()
        {
            return new Bat();
        }
    }
}
