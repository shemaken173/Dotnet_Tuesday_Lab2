namespace formProject
{
    // Bicycle rental screen: start/end time -> Total
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtStart.Text.Trim(), out int startTime) ||
                !int.TryParse(txtEnd.Text.Trim(), out int endTime))
            {
                MessageBox.Show("Please enter whole numbers for the start and end time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Clear();
                return;
            }

            if (!IsValidHourRange(startTime, endTime))
            {
                MessageBox.Show("Invalid input range or starting time is not less than ending time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Clear();
                return;
            }

            int totalCost = CalculateTotalCost(startTime, endTime);
            txtTotal.Text = $"{totalCost} RWF";
        }

        public static bool IsValidHourRange(int startTime, int endTime)
        {
            return startTime >= 0 && startTime <= 23 && endTime >= 1 && endTime <= 24 && startTime < endTime;
        }

        public static int CalculateTotalCost(int startTime, int endTime)
        {
            int totalCost = 0;

            for (int hour = startTime; hour < endTime; hour++)
            {
                if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                {
                    totalCost += 500;
                }
                else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                {
                    totalCost += 1000;
                }
                else if (hour >= 14 && hour < 19)
                {
                    totalCost += 1500;
                }
            }

            return totalCost;
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort; // tells ChooseForm to return to Login
            Close();
        }
    }
}
