namespace formProject
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(90, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose Activity";
            // 
            // btnBicycle
            // 
            btnBicycle.Location = new Point(45, 105);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(270, 45);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle Rental";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.Location = new Point(45, 165);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(270, 45);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom Identifier";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(lblTitle);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Activity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}
