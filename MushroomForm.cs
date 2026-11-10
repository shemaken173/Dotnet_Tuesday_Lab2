namespace formProject
{
    // Mushroom identifier screen: questions are asked with MessageBox (Yes / No)
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            Identify();
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort; // tells ChooseForm to return to Login
            Close();
        }

        private void Identify()
        {
            if (!AskQuestion("Does your mushroom have gills?"))
            {
                DisplayResult("Cèpe de Bordeaux");
                return;
            }

            bool growsInForest = AskQuestion("Does your mushroom grow in a forest?");

            if (!growsInForest)
            {
                if (AskQuestion("Does your mushroom have a convex cap?"))
                    DisplayResult("Agaric Jaunissant");
                else
                    DisplayResult("Coprin chevelu");
            }
            else
            {
                if (AskQuestion("Does your mushroom have a ring?"))
                {
                    DisplayResult("Amanite tue-mouches");
                }
                else
                {
                    if (AskQuestion("Does your mushroom have a convex cap?"))
                        DisplayResult("Pied bleu");
                    else
                        DisplayResult("Girolle");
                }
            }
        }

        private static bool AskQuestion(string question)
        {
            return MessageBox.Show(question, "Mushroom question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private static void DisplayResult(string mushroomName)
        {
            MessageBox.Show($"Your mushroom is: {mushroomName}!", "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
