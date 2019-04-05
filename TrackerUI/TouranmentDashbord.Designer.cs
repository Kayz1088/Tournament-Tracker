namespace TrackerUI
{
    partial class TouranmentDashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadExistingTouranmentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTouranmentLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadExistingTouranmentDropDown
            // 
            this.LoadExistingTouranmentDropDown.FormattingEnabled = true;
            this.LoadExistingTouranmentDropDown.Location = new System.Drawing.Point(186, 217);
            this.LoadExistingTouranmentDropDown.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.LoadExistingTouranmentDropDown.Name = "LoadExistingTouranmentDropDown";
            this.LoadExistingTouranmentDropDown.Size = new System.Drawing.Size(614, 45);
            this.LoadExistingTouranmentDropDown.TabIndex = 24;
            this.LoadExistingTouranmentDropDown.SelectedIndexChanged += new System.EventHandler(this.memberSelectDropDown_SelectedIndexChanged);
            // 
            // LoadExistingTouranmentLabel
            // 
            this.LoadExistingTouranmentLabel.AutoSize = true;
            this.LoadExistingTouranmentLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTouranmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadExistingTouranmentLabel.Location = new System.Drawing.Point(291, 142);
            this.LoadExistingTouranmentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoadExistingTouranmentLabel.Name = "LoadExistingTouranmentLabel";
            this.LoadExistingTouranmentLabel.Size = new System.Drawing.Size(405, 46);
            this.LoadExistingTouranmentLabel.TabIndex = 23;
            this.LoadExistingTouranmentLabel.Text = "Load Existing Touranment";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(243, 43);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(501, 65);
            this.HeaderLabel.TabIndex = 22;
            this.HeaderLabel.Text = "Tournament Dashboard";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(358, 315);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(270, 45);
            this.LoadTournamentButton.TabIndex = 25;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(327, 383);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(333, 86);
            this.createTournamentButton.TabIndex = 28;
            this.createTournamentButton.Text = "Create Tournamnet\r\n";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TouranmentDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 520);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTouranmentDropDown);
            this.Controls.Add(this.LoadExistingTouranmentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TouranmentDashbord";
            this.Text = "Touranment Dashbord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LoadExistingTouranmentDropDown;
        private System.Windows.Forms.Label LoadExistingTouranmentLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}