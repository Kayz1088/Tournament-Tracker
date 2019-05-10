namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.teamSelectDropDown = new System.Windows.Forms.ComboBox();
            this.teamSelectLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListbox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.removeSelectedTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesListLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(411, 65);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(27, 139);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(379, 43);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(19, 90);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(290, 45);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(183, 224);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 43);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "$0.00";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(19, 224);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(153, 45);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // teamSelectDropDown
            // 
            this.teamSelectDropDown.FormattingEnabled = true;
            this.teamSelectDropDown.Location = new System.Drawing.Point(23, 332);
            this.teamSelectDropDown.Name = "teamSelectDropDown";
            this.teamSelectDropDown.Size = new System.Drawing.Size(383, 45);
            this.teamSelectDropDown.TabIndex = 14;
            // 
            // teamSelectLabel
            // 
            this.teamSelectLabel.AutoSize = true;
            this.teamSelectLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamSelectLabel.Location = new System.Drawing.Point(15, 283);
            this.teamSelectLabel.Name = "teamSelectLabel";
            this.teamSelectLabel.Size = new System.Drawing.Size(191, 45);
            this.teamSelectLabel.TabIndex = 13;
            this.teamSelectLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLink.Location = new System.Drawing.Point(295, 301);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(111, 28);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(115, 414);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(202, 45);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(115, 485);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(202, 45);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListbox
            // 
            this.tournamentTeamsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListbox.FormattingEnabled = true;
            this.tournamentTeamsListbox.ItemHeight = 37;
            this.tournamentTeamsListbox.Location = new System.Drawing.Point(520, 139);
            this.tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            this.tournamentTeamsListbox.Size = new System.Drawing.Size(364, 187);
            this.tournamentTeamsListbox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(512, 90);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(233, 45);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams/ Players";
            // 
            // removeSelectedTeamButton
            // 
            this.removeSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedTeamButton.Location = new System.Drawing.Point(890, 202);
            this.removeSelectedTeamButton.Name = "removeSelectedTeamButton";
            this.removeSelectedTeamButton.Size = new System.Drawing.Size(139, 45);
            this.removeSelectedTeamButton.TabIndex = 20;
            this.removeSelectedTeamButton.Text = "Remove";
            this.removeSelectedTeamButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamButton.Click += new System.EventHandler(this.removeSelectedTeamButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(890, 477);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(139, 45);
            this.removeSelectedPrizeButton.TabIndex = 23;
            this.removeSelectedPrizeButton.Text = "Remove";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // PrizesListLabel
            // 
            this.PrizesListLabel.AutoSize = true;
            this.PrizesListLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizesListLabel.Location = new System.Drawing.Point(512, 365);
            this.PrizesListLabel.Name = "PrizesListLabel";
            this.PrizesListLabel.Size = new System.Drawing.Size(170, 45);
            this.PrizesListLabel.TabIndex = 22;
            this.PrizesListLabel.Text = "Prizes List ";
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 37;
            this.prizeListBox.Location = new System.Drawing.Point(520, 414);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(364, 187);
            this.prizeListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(341, 646);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(299, 56);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 733);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.PrizesListLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.removeSelectedTeamButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentTeamsListbox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.teamSelectDropDown);
            this.Controls.Add(this.teamSelectLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox teamSelectDropDown;
        private System.Windows.Forms.Label teamSelectLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListbox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button removeSelectedTeamButton;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label PrizesListLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}