namespace SimpleRPG
{

    internal static class RPGUtils
    {
        internal static void TIBetweenInventories(List<RPGItem> inventory_from, List<RPGItem> inventory_to, int index)
        {
            try
            {
                RPGItem item = inventory_from[index];
                inventory_from.RemoveAt(index);
                foreach (RPGItem i in inventory_to)
                {
                    if (i.GetType() == item.GetType() && !(i is RPGUsable))
                    {
                        i.count += item.count;
                        return;
                    }
                }
                inventory_to.Add(item);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    
        internal static void PutItemInInventory(List<RPGItem> inventory, RPGItem item)
        {
            foreach (RPGItem i in inventory)
            {
                if (i.GetType() == item.GetType() && !(i is RPGUsable))
                {
                    i.count += item.count;
                    return;
                }
            }
            inventory.Add(item);
        }
    }

    internal class InvItemLabel : Label
    {
        internal InvItemLabel(RPGItem item)
        {
            Text = item.ToString();
            Set();
        }
        internal InvItemLabel(string text)
        {
            Text = text;
            Set();
        }

        private void Set()
        {
            ForeColor = Color.FromArgb(255, 128, 0);
            Margin = new Padding(10, 10, 10, 0);
            BorderStyle = BorderStyle.FixedSingle;
            AutoSize = true;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MouseEnter += (sender, e) => BackColor = Color.FromArgb(45, 45, 45);
            MouseLeave += (sender, e) => BackColor = Color.FromArgb(35, 35, 35);
            ContextMenuStrip cms = new ContextMenuStrip();
            ContextMenuStrip = cms;
        }
    }
    
    internal class Cell : Panel
    {
        internal Cell(int size)
        {
            Size = new Size(size, size);
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(0);
        }
    }

    internal class SButton : Button
    {
        internal SButton(RPGObject rpgo, Color color, string sign)
        {
            Text = sign;
            TabStop = false;
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.White;
            Dock = DockStyle.Fill;
            BackColor = color;
        }
    }

    internal class Field : FlowLayoutPanel
    {
        internal Field(int rows, int cols, int cell_size)
        {
            Dock = DockStyle.Fill;
            Size = new Size(
                cols * cell_size + 16,
                rows * cell_size + 39);
        }
    }

    internal struct DialogueMessage
    {
        internal string message = "";
        internal List<string> answers = new List<string>();

        public DialogueMessage() {}

        public DialogueMessage(string message, List<string> answers) {
            this.message = message;
            this.answers = answers;
        }
        internal void Add(string text) => answers.Add(text);
    }
}
