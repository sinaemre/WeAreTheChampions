namespace WeAreTheChampions
{
    partial class AddPlayer
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
            this.pbPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudPace = new System.Windows.Forms.NumericUpDown();
            this.nudShoot = new System.Windows.Forms.NumericUpDown();
            this.nudPass = new System.Windows.Forms.NumericUpDown();
            this.nudDrippling = new System.Windows.Forms.NumericUpDown();
            this.nudPhysics = new System.Windows.Forms.NumericUpDown();
            this.nudDefence = new System.Windows.Forms.NumericUpDown();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbxAddTeam = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrippling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhysics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefence)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerPhoto
            // 
            this.pbPlayerPhoto.Location = new System.Drawing.Point(28, 26);
            this.pbPlayerPhoto.Name = "pbPlayerPhoto";
            this.pbPlayerPhoto.Size = new System.Drawing.Size(291, 139);
            this.pbPlayerPhoto.TabIndex = 0;
            this.pbPlayerPhoto.TabStop = false;
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImageLocation.Location = new System.Drawing.Point(147, 215);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(200, 26);
            this.txtImageLocation.TabIndex = 1;
            this.txtImageLocation.TextChanged += new System.EventHandler(this.txtImageLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(147, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 3;
            // 
            // nudPace
            // 
            this.nudPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPace.Location = new System.Drawing.Point(147, 314);
            this.nudPace.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudPace.Name = "nudPace";
            this.nudPace.Size = new System.Drawing.Size(199, 26);
            this.nudPace.TabIndex = 5;
            // 
            // nudShoot
            // 
            this.nudShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudShoot.Location = new System.Drawing.Point(147, 349);
            this.nudShoot.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudShoot.Name = "nudShoot";
            this.nudShoot.Size = new System.Drawing.Size(199, 26);
            this.nudShoot.TabIndex = 6;
            // 
            // nudPass
            // 
            this.nudPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPass.Location = new System.Drawing.Point(147, 384);
            this.nudPass.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudPass.Name = "nudPass";
            this.nudPass.Size = new System.Drawing.Size(199, 26);
            this.nudPass.TabIndex = 7;
            // 
            // nudDrippling
            // 
            this.nudDrippling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudDrippling.Location = new System.Drawing.Point(147, 419);
            this.nudDrippling.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudDrippling.Name = "nudDrippling";
            this.nudDrippling.Size = new System.Drawing.Size(199, 26);
            this.nudDrippling.TabIndex = 8;
            // 
            // nudPhysics
            // 
            this.nudPhysics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPhysics.Location = new System.Drawing.Point(147, 454);
            this.nudPhysics.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudPhysics.Name = "nudPhysics";
            this.nudPhysics.Size = new System.Drawing.Size(199, 26);
            this.nudPhysics.TabIndex = 9;
            // 
            // nudDefence
            // 
            this.nudDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudDefence.Location = new System.Drawing.Point(147, 489);
            this.nudDefence.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudDefence.Name = "nudDefence";
            this.nudDefence.Size = new System.Drawing.Size(199, 26);
            this.nudDefence.TabIndex = 10;
            // 
            // cboTeam
            // 
            this.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam.Enabled = false;
            this.cboTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(148, 585);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(200, 28);
            this.cboTeam.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pace:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shoot:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pass:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Drippling:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Physics:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Defence:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Enabled = false;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam.Location = new System.Drawing.Point(12, 593);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(58, 20);
            this.lblTeam.TabIndex = 18;
            this.lblTeam.Text = "Team:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Position:";
            // 
            // cbxPosition
            // 
            this.cbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(147, 524);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(200, 28);
            this.cbxPosition.TabIndex = 19;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAddPlayer.Location = new System.Drawing.Point(230, 630);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(118, 36);
            this.btnAddPlayer.TabIndex = 21;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCancel.Location = new System.Drawing.Point(110, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Place of Birth:";
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(147, 250);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(200, 26);
            this.txtPlaceOfBirth.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(11, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Day of Birth:";
            // 
            // dtpDayOfBirth
            // 
            this.dtpDayOfBirth.Location = new System.Drawing.Point(147, 285);
            this.dtpDayOfBirth.Name = "dtpDayOfBirth";
            this.dtpDayOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDayOfBirth.TabIndex = 26;
            // 
            // cbxAddTeam
            // 
            this.cbxAddTeam.AutoSize = true;
            this.cbxAddTeam.Location = new System.Drawing.Point(303, 565);
            this.cbxAddTeam.Name = "cbxAddTeam";
            this.cbxAddTeam.Size = new System.Drawing.Size(15, 14);
            this.cbxAddTeam.TabIndex = 27;
            this.cbxAddTeam.UseVisualStyleBackColor = true;
            this.cbxAddTeam.CheckedChanged += new System.EventHandler(this.cbxAddTeam_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(11, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Do you wanna player add to team?";
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(383, 668);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxAddTeam);
            this.Controls.Add(this.dtpDayOfBirth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.nudDefence);
            this.Controls.Add(this.nudPhysics);
            this.Controls.Add(this.nudDrippling);
            this.Controls.Add(this.nudPass);
            this.Controls.Add(this.nudShoot);
            this.Controls.Add(this.nudPace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.pbPlayerPhoto);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Name = "AddPlayer";
            this.Text = "Add Player";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrippling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhysics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerPhoto;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudPace;
        private System.Windows.Forms.NumericUpDown nudShoot;
        private System.Windows.Forms.NumericUpDown nudPass;
        private System.Windows.Forms.NumericUpDown nudDrippling;
        private System.Windows.Forms.NumericUpDown nudPhysics;
        private System.Windows.Forms.NumericUpDown nudDefence;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDayOfBirth;
        private System.Windows.Forms.CheckBox cbxAddTeam;
        private System.Windows.Forms.Label label13;
    }
}