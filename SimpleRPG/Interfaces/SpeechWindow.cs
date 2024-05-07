namespace SimpleRPG.Interfaces
{
    public partial class SpeechWindow : Form
    {
        public SpeechWindow(Form parent_form, string text, string Speeker)
        {
            InitializeComponent();

            this.ControlBox = false;
            this.MinimizeBox = false;

            Location = parent_form.Location;
            Text = Speeker;
            Size = new Size(parent_form.Width, 150);
            Top = parent_form.Top + (parent_form.Size.Height - Size.Height);

            SetText(text);
        }
        internal async void SetText(string text)
        {
            textbox.Text = "";
            foreach (Char c in text)
            {
                textbox.Text += c;
                await Task.Delay(50);
            }
        }

        private void SpeechWindow_KeyUp(object sender, KeyEventArgs e) => Close();
    }
}
