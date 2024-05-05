using SimpleRPG.Components;
using SimpleRPG.Usable;

namespace SimpleRPG.Utils
{
    internal static partial class Crafting
    {
        private static List<Craft> crafts = new List<Craft>() {
            new Craft(new Sword(), new List<RPGItem>()
            {
                new Wood(10),
                new Stone(50),
            }),

            new Craft(new Axe(), new List<RPGItem>()
            {
                new Wood(20),
                new Stone(30),
            }),

            new Craft(new Wood(50), new List<RPGItem>()
            {
                new Stone(25),
            }),

            new Craft(new Stone(25), new List<RPGItem>()
            {
                new Wood(50),
            }),

        };
    }
}
