namespace SimpleRPG
{
    internal abstract class RPGItem
    {
        internal string name;
        internal string description;
        internal int count;

        internal RPGItem(string name, int count, string desc="Item")
        {
            description = desc;
            this.count = count;
            this.name = name;
        }
        public override string ToString() => $"{name} x{count}";

        internal abstract RPGItem Copy();
    }

    internal abstract class RPGUsable : RPGItem 
    {
        internal RPGUsable(string name, int count) : base (name, count) { }

        internal abstract void OnUse(RPGEntity user, RPGMap map);

        public override string ToString() => $"{name}";
    }

    internal abstract class RPGComponent : RPGItem 
    {
        internal RPGComponent(string name, int count) : base(name, count) { }

        internal abstract override RPGItem Copy(); 
    }
}
