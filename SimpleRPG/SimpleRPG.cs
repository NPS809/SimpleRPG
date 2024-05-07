using SimpleRPG.Components;
using SimpleRPG.Interfaces;

namespace SimpleRPG
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SimpleRPG());
        }
    }   

    internal partial class SimpleRPG : Form
    {
        private RPGMap? map;
        private MapDrawer? md;

        internal SimpleRPG()
        {
            InitializeComponent();

            MaximizeBox = false;

            md = new MapDrawer(this);
            map = new RPGMap(md);

            Entities.Idle idle = new Entities.Idle(new v2(4, 4));
            Entities.Player ply = new Entities.Player(new v2(2, 2));
            Entities.Stepper stepp = new Entities.Stepper(new v2(7, 5));

            Objects.Chest chest = new Objects.Chest(new v2(1, 0));
            Objects.Chest chest2 = new Objects.Chest(new v2(0, 1));

            #region Adding Items
            chest.inventory.Add(new Wood(100));
            chest.inventory.Add(new Stone(50));
            chest2.inventory.Add(new Wood(20));
            chest2.inventory.Add(new Stone(30));
            #endregion

            map.Add(ply);
            map.Add(chest);
            map.Add(chest2);
            map.Add(stepp);
            map.Add(idle);

            md.Draw();
        }


        private void KeyHandler(object sender, KeyEventArgs e) {
            Text = $"Pressed key: {e.KeyCode}";
            map?.KeyHandler(e);
            if (e.KeyCode == Keys.F1)
            {
                new SpeechWindow(this, "Привет!", "Внутренний голос").ShowDialog();
                new SpeechWindow(this, "Я - Твой внутренний голос", "Внутренний голос").ShowDialog();
            }
                
        }

    }

    
}