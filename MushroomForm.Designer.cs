namespace formProject
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInstructions = new Label();
            btnStart = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(188, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Identifier";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(148, 89);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(406, 25);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Answer the questions to identify your mushroom.";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(128, 174);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(145, 35);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(409, 174);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 426);
            Controls.Add(lblTitle);
            Controls.Add(lblInstructions);
            Controls.Add(btnStart);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Identifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private Button btnStart;
        private Button btnLogout;
    }
}
