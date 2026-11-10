namespace formProject
{
    // "Choose" screen: pick Bicycle or Mushroom
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object? sender, EventArgs e)
        {
            OpenChild(new BicycleForm());
        }

        private void btnMushroom_Click(object? sender, EventArgs e)
        {
            OpenChild(new MushroomForm());
        }

        private void OpenChild(Form child)
        {
            Hide();
            DialogResult result;
            using (child)
            {
                child.ShowDialog();
                result = child.DialogResult;
            }

            // Logout in the child sets DialogResult.Abort -> go all the way back to Login
            if (result == DialogResult.Abort)
            {
                Close();
            }
            else
            {
                Show(); // child was just closed with X, stay on Choose
            }
        }
    }
}
