namespace SimpleRPG.Utils
{
    internal static partial class Crafting
    {
        internal static List<Craft> GetAvailableCrafts(List<RPGItem> components)
        {
            List<Craft> ac = new List<Craft>();

            foreach (Craft craft in crafts)
            {
                bool isAvailable = true;
                foreach (RPGItem craft_component in craft.components)
                {
                    bool isComponent = false;
                    foreach (RPGItem available_component in components)
                        if (craft_component.GetType() == available_component.GetType()) 
                            if (craft_component.count <= available_component.count)
                                isComponent = true;
                    if (!isComponent)
                        isAvailable = false;
                    if (!isAvailable)
                        break;
                }
                if (isAvailable)
                    ac.Add(craft);
            }
            return ac;
        }
    }

    internal class Craft
    {
        internal RPGItem result;
        internal List<RPGItem> components;

        internal Craft(RPGItem result, List<RPGItem> components)
        {
            this.result = result;
            this.components = components;
        }

        public override string ToString()
        {
            string comps = "Using components: \n";
            foreach (RPGItem comp in components)
                comps += comp.ToString() + "\n";
            comps += $"You can make: {result.ToString()}";
            return comps;
        }
        
    }
}
