using SimpleRPG.Utils;

namespace SimpleRPG.Interfaces
{
    internal partial class AvailableCrafts : Form
    {
        internal AvailableCrafts(List<RPGItem> components, List<RPGItem> player_inventory)
        {
            InitializeComponent();

            List<Craft> acrafts = Crafting.GetAvailableCrafts(components);
            foreach (Craft craft in acrafts)
            {
                string text = $"=> {craft.result}\n-----\n";
                foreach (RPGItem item in craft.components)
                    text += $"{item}\n";
                InvItemLabel iil = new InvItemLabel(text);

                iil.Click += (sender, e) =>
                {
                    foreach (RPGItem craft_component in craft.components) {
                        foreach (RPGItem available_component in components) {
                            if (available_component.GetType() == craft_component.GetType())
                            {
                                available_component.count -= craft_component.count;
                                if (available_component.count <= 0)
                                    components.Remove(available_component);
                                break;
                            }
                        }
                    }
                    RPGUtils.PutItemInInventory(player_inventory, craft.result.Copy());
                    Close();
                };
                acrafts_pnl.Controls.Add(iil);
            }
        }
    }
}
