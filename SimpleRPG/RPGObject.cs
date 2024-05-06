using SimpleRPG.Utils;

namespace SimpleRPG
{
    internal abstract class RPGObject
    {
        internal v2 position;
        internal RPGMap? map;
        internal SButton avatar;

        internal RPGObject(v2 position, Color color, string name)
        {
            this.position = position;
            avatar = new SButton(this, color, name);
        }
    }

    internal abstract class RPGStatic : RPGObject
    {
        protected RPGStatic(
            v2 position, 
            Color color, 
            string name) : base(position, color, name) { }
    }

    internal abstract class RPGResource : RPGStatic
    {
        internal int current_health;
        internal int max_health;

        protected RPGResource(
            v2 position,
            Color color,
            string name,
            int c_health,
            int m_health) : base(position, color, name) {

            current_health = c_health;
            max_health = m_health;
        } 
    }

    internal abstract class RPGInteractic : RPGStatic
    {
        protected RPGInteractic(
            v2 position, 
            Color color, 
            string name) 
            : base(position, color, name) { }

        internal abstract void OnInteract(RPGEntity interacter, RPGMap map);
    }

    internal abstract class RPGEntity : RPGObject
    {
        internal int current_health;
        internal int max_health;
        internal RPGUsable? right_hand;
        internal List<RPGItem> inventory;

        internal RPGEntity(
            v2 position, 
            Color color, 
            string name, 
            int c_health, 
            int m_health) : base (position, color, name) {

            current_health = c_health;
            max_health = m_health;
            inventory = new List<RPGItem>();
        }
    }

    internal abstract class RPGNPC : RPGEntity
    {
        NPCOptions options = new NPCOptions();

        internal RPGNPC(
            v2 position, 
            Color color, 
            string name) : base(position, color, name, 100, 100) { }
        
        internal abstract void OnInteract(RPGEntity interacter, RPGMap map);
    }
}
