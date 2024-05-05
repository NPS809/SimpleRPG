namespace SimpleRPG.PlayerOptions
{
    internal class PlayerControls
    {
        internal Keys move_up = Keys.W;
        internal Keys move_down = Keys.S;
        internal Keys move_right = Keys.D;
        internal Keys move_left = Keys.A;

        internal Keys rotate_right = Keys.Right;
        internal Keys rotate_left = Keys.Left;

        internal Keys interact = Keys.F;
        internal Keys inventory = Keys.Tab;

        internal bool can_use = true;
        internal bool can_move = true;
        internal bool can_interact = true;
        internal bool can_inventory = true;
    }
}
