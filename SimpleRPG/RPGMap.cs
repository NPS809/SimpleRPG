namespace SimpleRPG
{
    internal class RPGMap
    {
        internal List<RPGObject> objects;
        internal MapDrawer drawer;

        internal RPGMap(MapDrawer drawer)
        {
            objects = new List<RPGObject>();
            drawer.map = this;
            this.drawer = drawer;
        }

        internal void Add(RPGObject rpgo) {
            if (!objects.Contains(rpgo))
            {
                rpgo.map = this;
                objects.Add(rpgo);
            }
        }  

        internal RPGObject? Get(v2 pos)
        {
            foreach (RPGObject rpgo in objects)
                if (rpgo.position == pos)
                    return rpgo;
            return null;
        }

        internal void KeyHandler(KeyEventArgs e) {
            foreach (RPGObject rpgo in objects)
                if (rpgo.GetType() == typeof(Entities.Player)) 
                    ((Entities.Player)rpgo).KeyHandler(e);
        }
    }

    internal class MapDrawer
    {
        internal v2 screen_border = new v2(9, 16);
        internal RPGMap? map;

        private Dictionary<RPGObject, v2>? prev_states;
        private FlowLayoutPanel field;
        private Cell[,] cells;

        internal MapDrawer (Form form, int rows=9, int cols=16, int cell_size=50)
        {
            screen_border = new v2(rows, cols);
            field = new Field(screen_border.y, screen_border.x, cell_size);

            cells = new Cell[screen_border.y, screen_border.x];
            for (int y = 0; y < screen_border.y; y++)
            {
                for (int x = 0; x < screen_border.x; x++)
                {
                    Cell cell = new Cell(cell_size);
                    cells[y, x] = cell;
                    field.Controls.Add(cell);
                }
            }

            form.Size = new Size(field.Size.Width, field.Size.Height);
            form.Controls.Clear();
            form.Controls.Add(field);
        }

        internal void Draw()
        {
            if (map is null) return;
            if (prev_states is null)
            {
                prev_states = new Dictionary<RPGObject, v2>();
                foreach (RPGObject rpgo in map.objects)
                {
                    cells[rpgo.position.y, rpgo.position.x].Controls.Add(rpgo.avatar);
                    prev_states.Add(rpgo, rpgo.position);
                }
            } 
            else
            {
                foreach (RPGObject rpgo in map.objects)
                {
                    if (!prev_states.ContainsKey(rpgo))
                    {
                        cells[rpgo.position.y, rpgo.position.x].Controls.Add(rpgo.avatar);
                        prev_states.Add(rpgo, rpgo.position);
                    }
                }
            }
            foreach (var(key, value) in prev_states)
            {
                if (key.position != value)
                {
                    if (value.isInRange0toMax(screen_border))
                        cells[value.y, value.x].Controls.Remove(key.avatar);
                    if (key.position.isInRange0toMax(screen_border))
                        cells[key.position.y, key.position.x].Controls.Add(key.avatar);
                    prev_states[key] = key.position;
                }
            }
        }
    }
}
