namespace WeAreTheChampions
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGuestTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.pbGuestTeamMascod = new System.Windows.Forms.PictureBox();
            this.pbHomeTeamMascod = new System.Windows.Forms.PictureBox();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnNewChallenge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbGuestTeamLogo = new System.Windows.Forms.PictureBox();
            this.pbHomeTeamLogo = new System.Windows.Forms.PictureBox();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuestTeamMascod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeTeamMascod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuestTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.playersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTeamsToolStripMenuItem,
            this.addTeamToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // showTeamsToolStripMenuItem
            // 
            this.showTeamsToolStripMenuItem.Name = "showTeamsToolStripMenuItem";
            this.showTeamsToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.showTeamsToolStripMenuItem.Text = "Show Teams";
            this.showTeamsToolStripMenuItem.Click += new System.EventHandler(this.showTeamsToolStripMenuItem_Click);
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showColorsToolStripMenuItem,
            this.addColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // showColorsToolStripMenuItem
            // 
            this.showColorsToolStripMenuItem.Name = "showColorsToolStripMenuItem";
            this.showColorsToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.showColorsToolStripMenuItem.Text = "Show Colors";
            this.showColorsToolStripMenuItem.Click += new System.EventHandler(this.showColorsToolStripMenuItem_Click);
            // 
            // addColorToolStripMenuItem
            // 
            this.addColorToolStripMenuItem.Name = "addColorToolStripMenuItem";
            this.addColorToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.addColorToolStripMenuItem.Text = "Add Color";
            this.addColorToolStripMenuItem.Click += new System.EventHandler(this.addColorToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPlayersToolStripMenuItem,
            this.addPlayerToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // showPlayersToolStripMenuItem
            // 
            this.showPlayersToolStripMenuItem.Name = "showPlayersToolStripMenuItem";
            this.showPlayersToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.showPlayersToolStripMenuItem.Text = "Show Players";
            this.showPlayersToolStripMenuItem.Click += new System.EventHandler(this.showPlayersToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // lblGuestTeam
            // 
            this.lblGuestTeam.AutoSize = true;
            this.lblGuestTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuestTeam.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGuestTeam.Location = new System.Drawing.Point(357, 166);
            this.lblGuestTeam.Name = "lblGuestTeam";
            this.lblGuestTeam.Size = new System.Drawing.Size(16, 24);
            this.lblGuestTeam.TabIndex = 25;
            this.lblGuestTeam.Text = " ";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHomeTeam.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblHomeTeam.Location = new System.Drawing.Point(42, 166);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(16, 24);
            this.lblHomeTeam.TabIndex = 24;
            this.lblHomeTeam.Text = " ";
            // 
            // pbGuestTeamMascod
            // 
            this.pbGuestTeamMascod.Location = new System.Drawing.Point(361, 34);
            this.pbGuestTeamMascod.Name = "pbGuestTeamMascod";
            this.pbGuestTeamMascod.Size = new System.Drawing.Size(53, 33);
            this.pbGuestTeamMascod.TabIndex = 23;
            this.pbGuestTeamMascod.TabStop = false;
            // 
            // pbHomeTeamMascod
            // 
            this.pbHomeTeamMascod.Location = new System.Drawing.Point(46, 34);
            this.pbHomeTeamMascod.Name = "pbHomeTeamMascod";
            this.pbHomeTeamMascod.Size = new System.Drawing.Size(53, 33);
            this.pbHomeTeamMascod.TabIndex = 22;
            this.pbHomeTeamMascod.TabStop = false;
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditMatch.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditMatch.Location = new System.Drawing.Point(22, 375);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(208, 33);
            this.btnEditMatch.TabIndex = 21;
            this.btnEditMatch.Text = "Edit Match";
            this.btnEditMatch.UseVisualStyleBackColor = false;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMatch.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteMatch.Location = new System.Drawing.Point(245, 375);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(208, 33);
            this.btnDeleteMatch.TabIndex = 20;
            this.btnDeleteMatch.Text = "Delete Match";
            this.btnDeleteMatch.UseVisualStyleBackColor = false;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnNewChallenge
            // 
            this.btnNewChallenge.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewChallenge.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewChallenge.Location = new System.Drawing.Point(263, 205);
            this.btnNewChallenge.Name = "btnNewChallenge";
            this.btnNewChallenge.Size = new System.Drawing.Size(188, 38);
            this.btnNewChallenge.TabIndex = 19;
            this.btnNewChallenge.Text = "New Challenge";
            this.btnNewChallenge.UseVisualStyleBackColor = false;
            this.btnNewChallenge.Click += new System.EventHandler(this.btnNewChallenge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Matches";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.Indigo;
            this.lblScore.Location = new System.Drawing.Point(203, 94);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(17, 25);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = " ";
            // 
            // pbGuestTeamLogo
            // 
            this.pbGuestTeamLogo.Location = new System.Drawing.Point(330, 73);
            this.pbGuestTeamLogo.Name = "pbGuestTeamLogo";
            this.pbGuestTeamLogo.Size = new System.Drawing.Size(114, 80);
            this.pbGuestTeamLogo.TabIndex = 15;
            this.pbGuestTeamLogo.TabStop = false;
            // 
            // pbHomeTeamLogo
            // 
            this.pbHomeTeamLogo.Location = new System.Drawing.Point(15, 73);
            this.pbHomeTeamLogo.Name = "pbHomeTeamLogo";
            this.pbHomeTeamLogo.Size = new System.Drawing.Size(114, 80);
            this.pbHomeTeamLogo.TabIndex = 14;
            this.pbHomeTeamLogo.TabStop = false;
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(15, 249);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(436, 121);
            this.dgvMatches.TabIndex = 26;
            this.dgvMatches.SelectionChanged += new System.EventHandler(this.dgvMatches_SelectionChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(486, 430);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.lblGuestTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.pbGuestTeamMascod);
            this.Controls.Add(this.pbHomeTeamMascod);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.btnDeleteMatch);
            this.Controls.Add(this.btnNewChallenge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGuestTeamLogo);
            this.Controls.Add(this.pbHomeTeamLogo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "We Are the Champions ver. 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuestTeamMascod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeTeamMascod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuestTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.Label lblGuestTeam;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.PictureBox pbGuestTeamMascod;
        private System.Windows.Forms.PictureBox pbHomeTeamMascod;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Button btnNewChallenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbGuestTeamLogo;
        private System.Windows.Forms.PictureBox pbHomeTeamLogo;
        private System.Windows.Forms.ToolStripMenuItem showColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColorToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMatches;
    }
}

