namespace formProject
{
    partial class BicycleForm
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
            lblStart = new Label();
            lblEnd = new Label();
            lblTotal = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtTotal = new TextBox();
            btnCalc = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(90, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle Rental";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(30, 90);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(116, 25);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start hour (0-23)";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(30, 135);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(105, 25);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "End hour (1-24)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(30, 180);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(180, 87);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(150, 31);
            txtStart.TabIndex = 0;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(180, 132);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(150, 31);
            txtEnd.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(180, 177);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(30, 235);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(145, 35);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(185, 235);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 310);
            Controls.Add(lblTitle);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblTotal);
            Controls.Add(txtStart);
            Controls.Add(txtEnd);
            Controls.Add(txtTotal);
            Controls.Add(btnCalc);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private Label lblEnd;
        private Label lblTotal;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtTotal;
        private Button btnCalc;
        private Button btnLogout;
    }
}
