using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using WeAreTheChampions.Enums;

namespace WeAreTheChampions
{
    public partial class AddPlayer : Form
    {
        private readonly ApplicationDbContext db;
        private readonly Player player;
        private readonly string code;

        public AddPlayer(ApplicationDbContext db, Player player, string code)
        {
            InitializeComponent();
            this.db = db;
            this.player = player;
            this.code = code;
            if (code == "updatePlayer")
            {
                this.Text = "Update Player";
            }
            LoadTeamsAndPositions(code);
        }

        private void LoadTeamsAndPositions(string code)
        {
            if (db.Teams == null)
            {
                cboTeam.DataSource = null;
            }
            else
            {
                cboTeam.DataSource = db.Teams.ToList();
                cboTeam.DisplayMember = "TeamName";
                cbxPosition.DataSource = Enum.GetValues(typeof(Positions));
                pbPlayerPhoto.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Player-Photo-None.png";
                pbPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
               

                if (code == "updatePlayer")
                {
                    btnAddPlayer.Text = "Update";
                    txtName.Text = player.Name;
                    txtImageLocation.Text = player.PlayerPhoto;
                    txtPlaceOfBirth.Text = player.BirthPlace;
                    dtpDayOfBirth.Value = player.BirthDate.Value;
                    nudPace.Value = player.Pass;
                    nudShoot.Value = player.Shoot;
                    nudPass.Value = player.Pass;
                    nudDrippling.Value = player.Drippling;
                    nudPhysics.Value = player.Physics;
                    nudDefence.Value = player.Defence;
                    cboTeam.SelectedItem = player.Team;
                    cbxPosition.SelectedItem = player.Position;
                    if (player.Team != null)
                    {
                        cbxAddTeam.Checked = true;
                        cboTeam.Enabled = true;
                        lblTeam.Enabled = true;
                    }
                }
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (btnAddPlayer.Text == "Add")
            {
                Player player = new Player()
                {
                    Name = txtName.Text,
                    PlayerPhoto = txtImageLocation.Text,
                    BirthPlace = txtPlaceOfBirth.Text,
                    BirthDate = dtpDayOfBirth.Value.Date,
                    Pace = (int)nudPace.Value,
                    Shoot = (int)nudShoot.Value,
                    Pass = (int)nudPass.Value,
                    Drippling = (int)nudDrippling.Value,
                    Physics = (int)nudPhysics.Value,
                    Defence = (int)nudDefence.Value,
                    Position = (Positions)cbxPosition.SelectedItem
                };
                if (cbxAddTeam.Checked == true)
                {
                    player.Team = (Team)cboTeam.SelectedValue;
                }
                if (player.PlayerPhoto == "")
                {
                    player.PlayerPhoto = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Player-Photo-None.png";
                }
                player.Rating = (player.Pace + player.Shoot + player.Pass + player.Drippling + player.Physics + player.Defence) / 6;
                db.Players.Add(player);
                db.SaveChanges();
                MessageBox.Show($"Created player with {player.Rating} rating");
                this.Close();
            }
            else
            {
                player.Name = txtName.Text;
                player.PlayerPhoto = txtImageLocation.Text;
                player.BirthPlace = txtPlaceOfBirth.Text;
                player.BirthDate = dtpDayOfBirth.Value.Date;
                player.Pace = (int)nudPace.Value;
                player.Shoot = (int) nudShoot.Value;
                player.Pass = (int)nudPass.Value;
                player.Drippling = (int)nudDrippling.Value;
                player.Physics = (int)nudPhysics.Value;
                player.Defence = (int)nudDefence.Value;
                if (cbxAddTeam.Checked == false)
                {
                    player.Team = null;
                }
                else
                    player.Team = (Team)cboTeam.SelectedItem;

                player.Position = (Positions)cbxPosition.SelectedItem;
                player.Rating = (player.Pace + player.Shoot + player.Pass + player.Drippling + player.Physics + player.Defence) / 6;

                db.SaveChanges();
                MessageBox.Show($"Update succesfully!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImageLocation_TextChanged(object sender, EventArgs e)
        {
            pbPlayerPhoto.ImageLocation = txtImageLocation.Text;
            pbPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (txtImageLocation.Text == "")
            {
                pbPlayerPhoto.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Player-Photo-None.png";
            }
        }

        private void cbxAddTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddTeam.Checked == true)
            {
                cboTeam.Enabled = true;
                lblTeam.Enabled = true;
            }
            else
            {
                cboTeam.Enabled = false;
                lblTeam.Enabled = false;
            }
        }
    }
}
