using SimpleRPG.Interfaces;
using SimpleRPG.PlayerOptions;

namespace SimpleRPG.Entities
{
    internal class Player : RPGEntity
    {
        private v2 direction = new v2(-1, 0);

        internal PlayerStatistics stats = new PlayerStatistics();
        internal PlayerGameValues gameValues = new PlayerGameValues();
        internal PlayerControls controls = new PlayerControls();

        internal Player(v2 pos) : base(pos, Color.Black, "↑", 100, 100)
            => avatar.Font = Fonts.classic_sized;

        private void MoveHandler(KeyEventArgs e)
        {
            if (map is null) return;
            v2 next_pos = position;

            if (e.KeyCode == controls.move_down)
            {
                avatar.Text = "↓";
                direction = new v2(1, 0);
                Move();
            }
            else if (e.KeyCode == controls.move_up)
            {
                direction = new v2(-1, 0);
                avatar.Text = "↑";
                Move();
            }
            else if (e.KeyCode == controls.move_right)
            {
                direction = new v2(0, 1);
                avatar.Text = "→";
                Move();
            }
            else if (e.KeyCode == controls.move_left)
            {
                direction = new v2(0, -1);
                avatar.Text = "←";
                Move();
            }
            if (e.KeyCode == controls.rotate_right)
            {
                if (direction == new v2(1, 0))
                {
                    direction = new v2(0, -1);
                    avatar.Text = "←";
                }
                else if (direction == new v2(-1, 0))
                {
                    direction = new v2(0, 1);
                    avatar.Text = "→";
                }
                else if (direction == new v2(0, 1))
                {
                    direction = new v2(1, 0);
                    avatar.Text = "↓";
                }
                else if (direction == new v2(0, -1))
                {
                    direction = new v2(-1, 0);
                    avatar.Text = "↑";
                }
                map.drawer.Draw();
            }
            if (e.KeyCode == controls.rotate_left)
            {
                if (direction == new v2(1, 0))
                {
                    direction = new v2(0, 1);
                    avatar.Text = "→";
                }
                else if (direction == new v2(-1, 0))
                {
                    direction = new v2(0, -1);
                    avatar.Text = "←";
                }
                else if (direction == new v2(0, 1))
                {
                    direction = new v2(-1, 0);
                    avatar.Text = "↑";
                }
                else if (direction == new v2(0, -1))
                {
                    direction = new v2(1, 0);
                    avatar.Text = "↓";

                }
                map.drawer.Draw();
            }

            void Move()
            {
                next_pos.x += direction.x;
                next_pos.y += direction.y;
                if (next_pos.isInRange0toMax(map.drawer.screen_border)
                    && map.Get(next_pos) is null
                    && controls.can_move)
                    position = next_pos;
                map.drawer.Draw();
            }
        }

        private void InteractHandler()
        {
            if (map == null) return;
            v2 nPos = new v2(position.y + direction.y, position.x + direction.x);
            RPGObject? nObj = map.Get(nPos);
            if (nObj is not null && controls.can_interact)
                if (nObj is RPGInteractic)
                    ((RPGInteractic)nObj).OnInteract(this, map);
                else if (nObj is RPGNPC)
                    ((RPGNPC)nObj).OnInteract(this, map);

        }

        public void SetInRightHand(int index)
        {
            try
            {
                if (right_hand is not null)
                {
                    inventory.Add(right_hand);
                    right_hand = null;
                }
                right_hand = (RPGUsable)inventory[index];
                inventory.RemoveAt(index);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void RemoveFromRightHand()
        {
            if (right_hand is not null)
            {
                inventory.Add(right_hand);
                right_hand = null;
            }
        }

        private void UseHandler()
        {
            if (map == null) return;
            if (right_hand != null && controls.can_use)
                right_hand.OnUse(this, map);
        }

        public void KeyHandler(KeyEventArgs e)
        {
            MoveHandler(e);
            if (e.KeyCode == Keys.F)
                InteractHandler();
            if (e.KeyCode == Keys.Tab && controls.can_inventory)
                new PlayerInventory(this).ShowDialog();
            if (e.KeyCode == Keys.Space)
                UseHandler();
        }
    }
}
