namespace WeAreTheChampions
{
    partial class AddTeam
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
            this.clbColors = new System.Windows.Forms.CheckedListBox();
            this.clbPlayers = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtMascodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMascodLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogoLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbMascod = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbPlayerPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMascod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // clbColors
            // 
            this.clbColors.BackColor = System.Drawing.Color.IndianRed;
            this.clbColors.FormattingEnabled = true;
            this.clbColors.Location = new System.Drawing.Point(391, 44);
            this.clbColors.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clbColors.Name = "clbColors";
            this.clbColors.Size = new System.Drawing.Size(180, 130);
            this.clbColors.TabIndex = 0;
            this.clbColors.SelectedIndexChanged += new System.EventHandler(this.clbColors_SelectedIndexChanged);
            // 
            // clbPlayers
            // 
            this.clbPlayers.BackColor = System.Drawing.Color.Gold;
            this.clbPlayers.FormattingEnabled = true;
            this.clbPlayers.Location = new System.Drawing.Point(391, 247);
            this.clbPlayers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clbPlayers.Name = "clbPlayers";
            this.clbPlayers.Size = new System.Drawing.Size(180, 130);
            this.clbPlayers.TabIndex = 1;
            this.clbPlayers.SelectedIndexChanged += new System.EventHandler(this.clbPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Free Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team Name:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(147, 25);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(207, 26);
            this.txtTeamName.TabIndex = 5;
            // 
            // txtMascodName
            // 
            this.txtMascodName.Location = new System.Drawing.Point(147, 72);
            this.txtMascodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascodName.Name = "txtMascodName";
            this.txtMascodName.Size = new System.Drawing.Size(207, 26);
            this.txtMascodName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mascod Name:";
            // 
            // txtMascodLocation
            // 
            this.txtMascodLocation.Location = new System.Drawing.Point(147, 166);
            this.txtMascodLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascodLocation.Name = "txtMascodLocation";
            this.txtMascodLocation.Size = new System.Drawing.Size(207, 26);
            this.txtMascodLocation.TabIndex = 11;
            this.txtMascodLocation.TextChanged += new System.EventHandler(this.txtMascodLocation_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mascod";
            // 
            // txtLogoLocation
            // 
            this.txtLogoLocation.Location = new System.Drawing.Point(147, 119);
            this.txtLogoLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogoLocation.Name = "txtLogoLocation";
            this.txtLogoLocation.Size = new System.Drawing.Size(207, 26);
            this.txtLogoLocation.TabIndex = 9;
            this.txtLogoLocation.TextChanged += new System.EventHandler(this.txtLogoLocation_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Logo";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(20, 247);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(139, 130);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // pbMascod
            // 
            this.pbMascod.Location = new System.Drawing.Point(208, 247);
            this.pbMascod.Name = "pbMascod";
            this.pbMascod.Size = new System.Drawing.Size(139, 130);
            this.pbMascod.TabIndex = 13;
            this.pbMascod.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mascod Picture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Logo Picture";
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(589, 44);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(139, 130);
            this.pbColor.TabIndex = 16;
            this.pbColor.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(628, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 34);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(531, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbPlayerPhoto
            // 
            this.pbPlayerPhoto.Location = new System.Drawing.Point(589, 247);
            this.pbPlayerPhoto.Name = "pbPlayerPhoto";
            this.pbPlayerPhoto.Size = new System.Drawing.Size(139, 130);
            this.pbPlayerPhoto.TabIndex = 19;
            this.pbPlayerPhoto.TabStop = false;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.pbPlayerPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbMascod);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtMascodLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogoLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMascodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbPlayers);
            this.Controls.Add(this.clbColors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddTeam";
            this.Text = "Add Team";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMascod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbColors;
        private System.Windows.Forms.CheckedListBox clbPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtMascodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMascodLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogoLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbMascod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbPlayerPhoto;
    }
}