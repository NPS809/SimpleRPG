namespace SimpleRPG.Interfaces
{
    internal partial class DialogueWindow : Form
    {
        internal DialogueWindow(DialogueMessage dm)
        {
            InitializeComponent();
            PlayDialogue(dm);
        }


        internal async void PlayDialogue(DialogueMessage dm)
        {
            textbox.Text = "";
            answers.Controls.Clear();

            foreach (Char c in dm.message)
            {
                textbox.Text += c;
                await Task.Delay(50);
            }
            for (int i = 0; i < dm.answers.Count; i++)
                AddAnswer(dm.answers[i]);
        }

        private async void AddAnswer(string text)
        {
            InvItemLabel iil = new InvItemLabel("");
            iil.Click += (sender, e) =>
            {

            };
            iil.Margin = new Padding(5, 5, 5, 0);
            answers.Controls.Add(iil);
            foreach (Char c in text)
            {
                iil.Text += c;
                await Task.Delay(25);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
