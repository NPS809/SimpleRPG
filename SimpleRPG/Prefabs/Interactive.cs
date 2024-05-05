namespace SimpleRPG.Interactives
{
    internal class Chest : RPGInteractic
    {
        internal List<RPGItem> inventory = new List<RPGItem>();

        internal Chest(v2 pos) : base(pos, Color.SandyBrown, "Chest") { }

        internal override void OnInteract(RPGEntity interacter, RPGMap map) => 
            new ChestInventory(this, interacter).ShowDialog();
    }
}
