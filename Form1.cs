namespace formProject
{
    // Login screen (first box on the board)
    public partial class Form1 : Form
    {
        // Change these to whatever credentials you want
        private const string ValidUsername = "admin";
        private const string ValidPassword = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (username == ValidUsername && password == ValidPassword)
            {
                // Login -> Choose
                Hide();
                using (var choose = new ChooseForm())
                {
                    choose.ShowDialog();
                }

                // Came back after logout
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
