namespace SimpleRPG.Entities
{
    internal class Stepper : RPGNPC
    {
        internal Stepper(v2 pos) : base(pos, Color.Brown, "STEP") { }

        internal async void Move(int step_cout)
        {
            while (true)
            {
                for (int i = 0; i < step_cout; i++)
                {
                    position.x += 1;
                    map.drawer.Draw();
                    await Task.Delay(500);
                }
                for (int i = 0; i < step_cout; i++)
                {
                    position.y -= 1;
                    map.drawer.Draw();
                    await Task.Delay(500);
                }
                for (int i = 0; i < step_cout; i++)
                {
                    position.x -= 1;
                    map.drawer.Draw();
                    await Task.Delay(500);
                }
                for (int i = 0; i < step_cout; i++)
                {
                    position.y += 1;
                    map.drawer.Draw();
                    await Task.Delay(500);
                }
            }
            

        }

        internal override void OnInteract(RPGEntity interacter, RPGMap map)
        {
            Move(3);
        }
    }

    internal class Idle : RPGNPC
    {
        internal Idle(v2 pos) : base(pos, Color.Wheat, "Idle") { }

        internal async void Idling()
        {
            while (true)
            {
                if (!(map is null))
                {
                    position.x++;
                    map.drawer.Draw();
                    await Task.Delay(new Random().Next(2000, 10000));
                    position.y--;
                    map.drawer.Draw();
                    await Task.Delay(new Random().Next(2000, 10000));
                    position.x--;
                    map.drawer.Draw();
                    await Task.Delay(new Random().Next(2000, 10000));
                    position.y++;
                    map.drawer.Draw();
                    await Task.Delay(new Random().Next(2000, 10000));
                }
            }
        }

        internal override void OnInteract(RPGEntity interacter, RPGMap map)
        {
            MessageBox.Show("Just idle (‾◡◝)");
        }
    }
}
