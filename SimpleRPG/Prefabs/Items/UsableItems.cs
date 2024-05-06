namespace SimpleRPG.Usable
{
    internal class Sword : RPGUsable
    {
        internal Sword() : base("Меч", 1) { }

        internal override void OnUse(RPGEntity user, RPGMap map) =>
            MessageBox.Show($"Игрок {user.avatar.Text} пытается ударить мечом на карте, где {map.objects.Count} объектов");

        internal override RPGItem Copy() => new Sword();
    }

    internal class Axe : RPGUsable
    {
        internal Axe() : base("Топор", 1) { }

        internal override void OnUse(RPGEntity user, RPGMap map) =>
            MessageBox.Show($"Игрок {user.avatar.Text} пытается ударить топором на карте, где {map.objects.Count} объектов");

        internal override RPGItem Copy() => new Axe();
    }
}
