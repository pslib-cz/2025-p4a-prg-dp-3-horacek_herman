namespace EndlessHeroWorld.Game
{
    public interface ILocation
    {
        string Name { get; }             
        IEnemy GenerateEnemy();           
    }
}
