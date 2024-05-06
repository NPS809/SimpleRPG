namespace SimpleRPG.Components
{
    internal class Wood : RPGComponent
    {
        internal Wood(int count) : base("Дерево", count) { }
        internal override RPGItem Copy() => new Wood(count);
    }

    internal class Stone : RPGComponent
    {
        internal Stone(int count) : base("Камень", count) { }
        internal override RPGItem Copy() => new Stone(count);
    }

}
