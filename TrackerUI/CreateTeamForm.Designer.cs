using System;

namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.memberSelectDropDown = new System.Windows.Forms.ComboBox();
            this.memberSelectLabel = new System.Windows.Forms.Label();
            this.addMemberBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.phoneNumberValue = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMemberListbox = new System.Windows.Forms.ListBox();
            this.removeSelectedPlayerButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(29, 151);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(509, 43);
            this.TeamNameValue.TabIndex = 13;
            this.TeamNameValue.TextChanged += new System.EventHandler(this.TeamNameValue_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(21, 102);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(192, 45);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(14, 21);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(276, 65);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(92, 362);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(202, 45);
            this.addMemberButton.TabIndex = 22;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // memberSelectDropDown
            // 
            this.memberSelectDropDown.FormattingEnabled = true;
            this.memberSelectDropDown.Location = new System.Drawing.Point(29, 271);
            this.memberSelectDropDown.Name = "memberSelectDropDown";
            this.memberSelectDropDown.Size = new System.Drawing.Size(513, 45);
            this.memberSelectDropDown.TabIndex = 21;
            // 
            // memberSelectLabel
            // 
            this.memberSelectLabel.AutoSize = true;
            this.memberSelectLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.memberSelectLabel.Location = new System.Drawing.Point(21, 222);
            this.memberSelectLabel.Name = "memberSelectLabel";
            this.memberSelectLabel.Size = new System.Drawing.Size(322, 45);
            this.memberSelectLabel.TabIndex = 20;
            this.memberSelectLabel.Text = "Select Team Member";
            // 
            // addMemberBox
            // 
            this.addMemberBox.Controls.Add(this.createMemberButton);
            this.addMemberBox.Controls.Add(this.phoneNumberValue);
            this.addMemberBox.Controls.Add(this.PhoneNumberLabel);
            this.addMemberBox.Controls.Add(this.emailValue);
            this.addMemberBox.Controls.Add(this.EmailLabel);
            this.addMemberBox.Controls.Add(this.lastNameValue);
            this.addMemberBox.Controls.Add(this.lastNameLabel);
            this.addMemberBox.Controls.Add(this.firstNameValue);
            this.addMemberBox.Controls.Add(this.firstNameLabel);
            this.addMemberBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))));
            this.addMemberBox.Location = new System.Drawing.Point(29, 435);
            this.addMemberBox.Name = "addMemberBox";
            this.addMemberBox.Size = new System.Drawing.Size(513, 407);
            this.addMemberBox.TabIndex = 23;
            this.addMemberBox.TabStop = false;
            this.addMemberBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(96, 347);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(243, 45);
            this.createMemberButton.TabIndex = 23;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // phoneNumberValue
            // 
            this.phoneNumberValue.Location = new System.Drawing.Point(208, 278);
            this.phoneNumberValue.Name = "phoneNumberValue";
            this.phoneNumberValue.Size = new System.Drawing.Size(270, 51);
            this.phoneNumberValue.TabIndex = 18;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(2, 278);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(141, 45);
            this.PhoneNumberLabel.TabIndex = 17;
            this.PhoneNumberLabel.Text = "Phone #";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(208, 219);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(270, 51);
            this.emailValue.TabIndex = 16;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(6, 216);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(98, 45);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(208, 154);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(270, 51);
            this.lastNameValue.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 151);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(174, 45);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(208, 87);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(270, 51);
            this.firstNameValue.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 84);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(176, 45);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMemberListbox
            // 
            this.teamMemberListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMemberListbox.FormattingEnabled = true;
            this.teamMemberListbox.ItemHeight = 37;
            this.teamMemberListbox.Location = new System.Drawing.Point(649, 102);
            this.teamMemberListbox.Name = "teamMemberListbox";
            this.teamMemberListbox.Size = new System.Drawing.Size(484, 594);
            this.teamMemberListbox.TabIndex = 24;
            // 
            // removeSelectedPlayerButton
            // 
            this.removeSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedPlayerButton.Location = new System.Drawing.Point(1148, 505);
            this.removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            this.removeSelectedPlayerButton.Size = new System.Drawing.Size(144, 60);
            this.removeSelectedPlayerButton.TabIndex = 25;
            this.removeSelectedPlayerButton.Text = "Remove";
            this.removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.removeSelectedPlayerButton.Click += new System.EventHandler(this.removeSelectedPlayerButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(724, 771);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(299, 56);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team\r\n";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 943);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedPlayerButton);
            this.Controls.Add(this.teamMemberListbox);
            this.Controls.Add(this.addMemberBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.memberSelectDropDown);
            this.Controls.Add(this.memberSelectLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addMemberBox.ResumeLayout(false);
            this.addMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox memberSelectDropDown;
        private System.Windows.Forms.Label memberSelectLabel;
        private System.Windows.Forms.GroupBox addMemberBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox phoneNumberValue;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMemberListbox;
        private System.Windows.Forms.Button removeSelectedPlayerButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}