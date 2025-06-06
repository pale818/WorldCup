﻿namespace WorldCup.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbGender = new ComboBox();
            cmbCountry = new ComboBox();
            lblGender = new Label();
            lblCountry = new Label();
            cmbLang = new ComboBox();
            lblLang = new Label();
            btnPlayers = new Button();
            btnMatches = new Button();
            btnRemoveTeam = new Button();
            btnAddTeam = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            lblMatchesList = new Label();
            lblFavTeam = new Label();
            flpPlayers = new FlowLayoutPanel();
            flpFavPlayers = new FlowLayoutPanel();
            lblPlayers = new Label();
            lblFavPlayers = new Label();
            SuspendLayout();
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(22, 40);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(123, 28);
            cmbGender.TabIndex = 0;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(230, 41);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(115, 28);
            cmbCountry.TabIndex = 1;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(51, 18);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender";
            lblGender.Click += lblGender_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(257, 18);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "Country";
            lblCountry.Click += lblCountry_Click;
            // 
            // cmbLang
            // 
            cmbLang.FormattingEnabled = true;
            cmbLang.Location = new Point(883, 39);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(87, 28);
            cmbLang.TabIndex = 4;
            cmbLang.SelectedIndexChanged += cmbLang_SelectedIndexChanged;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Location = new Point(883, 18);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(74, 20);
            lblLang.TabIndex = 5;
            lblLang.Text = "Language";
            // 
            // btnPlayers
            // 
            btnPlayers.Location = new Point(22, 138);
            btnPlayers.Name = "btnPlayers";
            btnPlayers.Size = new Size(132, 29);
            btnPlayers.TabIndex = 6;
            btnPlayers.Text = "Load Players";
            btnPlayers.UseVisualStyleBackColor = true;
            // 
            // btnMatches
            // 
            btnMatches.Location = new Point(513, 39);
            btnMatches.Name = "btnMatches";
            btnMatches.Size = new Size(259, 29);
            btnMatches.TabIndex = 7;
            btnMatches.Text = "Load Matches";
            btnMatches.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTeam
            // 
            btnRemoveTeam.Location = new Point(513, 318);
            btnRemoveTeam.Name = "btnRemoveTeam";
            btnRemoveTeam.Size = new Size(259, 29);
            btnRemoveTeam.TabIndex = 8;
            btnRemoveTeam.Text = "Remove Team";
            btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // btnAddTeam
            // 
            btnAddTeam.Location = new Point(230, 84);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(192, 29);
            btnAddTeam.TabIndex = 9;
            btnAddTeam.Text = "Add Favourite Team";
            btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(513, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 144);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(513, 366);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(259, 144);
            listBox2.TabIndex = 11;
            // 
            // lblMatchesList
            // 
            lblMatchesList.AutoSize = true;
            lblMatchesList.Location = new Point(519, 242);
            lblMatchesList.Name = "lblMatchesList";
            lblMatchesList.Size = new Size(108, 20);
            lblMatchesList.TabIndex = 12;
            lblMatchesList.Text = "List of matches";
            // 
            // lblFavTeam
            // 
            lblFavTeam.AutoSize = true;
            lblFavTeam.Location = new Point(516, 521);
            lblFavTeam.Name = "lblFavTeam";
            lblFavTeam.Size = new Size(109, 20);
            lblFavTeam.TabIndex = 13;
            lblFavTeam.Text = "Favourite Team";
            // 
            // flpPlayers
            // 
            flpPlayers.Location = new Point(22, 194);
            flpPlayers.Name = "flpPlayers";
            flpPlayers.Size = new Size(250, 125);
            flpPlayers.TabIndex = 14;
            // 
            // flpFavPlayers
            // 
            flpFavPlayers.Location = new Point(22, 386);
            flpFavPlayers.Name = "flpFavPlayers";
            flpFavPlayers.Size = new Size(250, 124);
            flpFavPlayers.TabIndex = 15;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.Location = new Point(30, 327);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(100, 20);
            lblPlayers.TabIndex = 16;
            lblPlayers.Text = "List of players";
            // 
            // lblFavPlayers
            // 
            lblFavPlayers.AutoSize = true;
            lblFavPlayers.Location = new Point(26, 518);
            lblFavPlayers.Name = "lblFavPlayers";
            lblFavPlayers.Size = new Size(120, 20);
            lblFavPlayers.TabIndex = 17;
            lblFavPlayers.Text = "Favourite players";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 576);
            Controls.Add(lblFavPlayers);
            Controls.Add(lblPlayers);
            Controls.Add(flpFavPlayers);
            Controls.Add(flpPlayers);
            Controls.Add(lblFavTeam);
            Controls.Add(lblMatchesList);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnAddTeam);
            Controls.Add(btnRemoveTeam);
            Controls.Add(btnMatches);
            Controls.Add(btnPlayers);
            Controls.Add(lblLang);
            Controls.Add(cmbLang);
            Controls.Add(lblCountry);
            Controls.Add(lblGender);
            Controls.Add(cmbCountry);
            Controls.Add(cmbGender);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGender;
        private ComboBox cmbCountry;
        private Label lblGender;
        private Label lblCountry;
        private ComboBox cmbLang;
        private Label lblLang;
        private Button btnPlayers;
        private Button btnMatches;
        private Button btnRemoveTeam;
        private Button btnAddTeam;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label lblMatchesList;
        private Label lblFavTeam;
        private FlowLayoutPanel flpPlayers;
        private FlowLayoutPanel flpFavPlayers;
        private Label lblPlayers;
        private Label lblFavPlayers;
    }
}
