namespace SimpleRPG
{
    internal partial class ChestInventory : Form
    {
        private Objects.Chest chest;
        private RPGEntity entity;

        internal ChestInventory(Objects.Chest chest, RPGEntity entity)
        {
            this.chest = chest;
            this.entity = entity;
            InitializeComponent();
            UpdateInventories();
        }

        private void UpdateInventories()
        {
            lcb_entity_inventory.Items.Clear();
            lcb_chest_inventory.Items.Clear();
            foreach (RPGItem item in entity.inventory)
                lcb_entity_inventory.Items.Add(item);

            foreach (RPGItem item in chest.inventory)
                lcb_chest_inventory.Items.Add(item);
        }

        private void entity_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lcb_entity_inventory.SelectedIndex >= 0)
                RPGUtils.TIBetweenInventories(entity.inventory, chest.inventory, lcb_entity_inventory.SelectedIndex);
            UpdateInventories();
        }

        private void chest_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lcb_chest_inventory.SelectedIndex >= 0)
                RPGUtils.TIBetweenInventories(chest.inventory, entity.inventory, lcb_chest_inventory.SelectedIndex);
            UpdateInventories();
        }

        private void takeAllToChest_Click(object sender, EventArgs e)
        {
            while (entity.inventory.Count > 0)
                RPGUtils.TIBetweenInventories(entity.inventory, chest.inventory, 0);
            UpdateInventories();
        }

        private void takeAllToEntity_Click(object sender, EventArgs e)
        {
            while (chest.inventory.Count > 0)
                RPGUtils.TIBetweenInventories(chest.inventory, entity.inventory, 0);
            UpdateInventories();
        }

        private void KeyHandler(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Escape) Close(); }
    }
}
