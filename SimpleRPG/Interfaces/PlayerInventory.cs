namespace SimpleRPG.Interfaces
{
    internal partial class PlayerInventory : Form
    {
        private Entities.Player player;

        private List<RPGItem> craft_inventory = new List<RPGItem>();

        internal PlayerInventory(Entities.Player player)
        {
            this.player = player;
            InitializeComponent();
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            lbl_player_name.Text = $"Игрок: {player.gameValues.nickname}";
            health.Text = $"Здоровье: [{player.current_health}/{player.max_health}]";
            healthbar.Maximum = player.max_health;
            healthbar.Value = player.current_health;

            player_inventory.Controls.Clear();
            pnlCraft.Controls.Clear();
            right_hand.Controls.Clear();

            foreach (RPGItem item in player.inventory)
                AddItemToInventory(item);
            foreach (RPGItem item in craft_inventory)
                AddItemToCraft(item);
             

            AddItemToRightHand(player.right_hand);
        }

        private void AddItemToInventory(RPGItem item)
        {
            if (item != null)
            {
                InvItemLabel text = new InvItemLabel(item);
                if (text.ContextMenuStrip != null)
                {
                    if (item is RPGComponent)
                    {
                        text.ContextMenuStrip.Items.Add("Добавить в меню создания");
                        text.ContextMenuStrip.Items[0].Click += (sender, e) =>
                        {
                            RPGUtils.TIBetweenInventories(player.inventory, craft_inventory, player.inventory.IndexOf(item));
                            UpdateTexts();
                        };
                    }
                    else if (item is RPGUsable)
                    {
                        text.ContextMenuStrip.Items.Add("Взять в правую руку");
                        text.ContextMenuStrip.Items[0].Click += (sender, e) =>
                        {
                            player.SetInRightHand(player.inventory.IndexOf(item));
                            UpdateTexts();
                        };
                    }
                    player_inventory.Controls.Add(text);
                }
            }
        }

        private void AddItemToCraft(RPGItem? item)
        {
            if (item is not null)
            {
                InvItemLabel text = new InvItemLabel(item);
                if (text.ContextMenuStrip != null)
                {
                    text.ContextMenuStrip.Items.Add("Убрать из меню создания");
                    text.ContextMenuStrip.Items[0].Click += (sender, e) =>
                    {
                        RPGUtils.TIBetweenInventories(craft_inventory, player.inventory, craft_inventory.IndexOf(item));
                        UpdateTexts();
                    };
                    pnlCraft.Controls.Add(text);
                }
            }
        }

        private void AddItemToRightHand(RPGItem? item)
        {
            if (item is not null)
            {
                InvItemLabel text = new InvItemLabel(item);
                if (text.ContextMenuStrip != null)
                {
                    text.ContextMenuStrip.Items.Add("Убрать из правой руки");
                    text.ContextMenuStrip.Items[0].Click += (sender, e) =>
                    {
                        player.RemoveFromRightHand();
                        UpdateTexts();
                    };
                    right_hand.Controls.Add(text);
                }
            }
        }

        private void PlayerInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (craft_inventory.Count > 0)
                RPGUtils.TIBetweenInventories(craft_inventory, player.inventory, 0);
        }

        private void btn_craft_Click(object sender, EventArgs e)
        {
            new AvailableCrafts(craft_inventory, player.inventory).ShowDialog();
            UpdateTexts();
        }

        private void KeyHandler(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Escape) Close(); }
    }
}
