namespace WeAreTheChampions
{
    partial class AddChallenge
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboGuestTeam = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHomeScore = new System.Windows.Forms.NumericUpDown();
            this.nudGuestScore = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Team";
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(142, 40);
            this.cboHomeTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(200, 28);
            this.cboHomeTeam.TabIndex = 1;
            // 
            // cboGuestTeam
            // 
            this.cboGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuestTeam.FormattingEnabled = true;
            this.cboGuestTeam.Location = new System.Drawing.Point(142, 97);
            this.cboGuestTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGuestTeam.Name = "cboGuestTeam";
            this.cboGuestTeam.Size = new System.Drawing.Size(200, 28);
            this.cboGuestTeam.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 95);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Guest Team";
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(142, 153);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(200, 23);
            this.dtpMatchTime.TabIndex = 4;
            this.dtpMatchTime.ValueChanged += new System.EventHandler(this.dtpMatchTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Home Score";
            // 
            // nudHomeScore
            // 
            this.nudHomeScore.Location = new System.Drawing.Point(542, 42);
            this.nudHomeScore.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHomeScore.Name = "nudHomeScore";
            this.nudHomeScore.Size = new System.Drawing.Size(120, 26);
            this.nudHomeScore.TabIndex = 8;
            // 
            // nudGuestScore
            // 
            this.nudGuestScore.Location = new System.Drawing.Point(542, 99);
            this.nudGuestScore.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGuestScore.Name = "nudGuestScore";
            this.nudGuestScore.Size = new System.Drawing.Size(120, 26);
            this.nudGuestScore.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Guest Score";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(472, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(570, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(687, 200);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudGuestScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudHomeScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpMatchTime);
            this.Controls.Add(this.cboGuestTeam);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cboHomeTeam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddChallenge";
            this.Text = "AddChallenge";
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboGuestTeam;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHomeScore;
        private System.Windows.Forms.NumericUpDown nudGuestScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}