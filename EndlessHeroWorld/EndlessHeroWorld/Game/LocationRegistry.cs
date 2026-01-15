using EndlessHeroWorld.Game;
using EndlessHeroWorld.Content;
using System;
using System.Collections.Generic;

namespace EndlessHeroWorld.Game
{
    public static class LocationRegistry
    {
        private static readonly List<ILocation> _locations = new List<ILocation>();

        public static void RegisterLocation(ILocation location)
        {
            _locations.Add(location);
        }

        public static IReadOnlyList<ILocation> GetLocations() => _locations;
    }
}
