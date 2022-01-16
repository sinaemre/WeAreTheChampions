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

namespace WeAreTheChampions
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Player player = null;
        ColorPaint colorPaint = null;
        Team team = null;
        Match match = null;

        public Form1()
        {
            InitializeComponent();
            LoadMatches();
        }

        private void LoadMatches()
        {
            dgvMatches.DataSource = db.Matches.ToList();

            dgvMatches.Columns["HomeScore"].Visible = false;
            dgvMatches.Columns["AwayScore"].Visible = false;
            dgvMatches.Columns["MatchId"].Visible = false;
            dgvMatches.Columns["HomeTeamId"].Visible = false;
            dgvMatches.Columns["GuestTeamId"].Visible = false;
            dgvMatches.Columns["GuestTeam"].Visible = false;
            dgvMatches.Columns["HomeTeam"].Visible = false;
            dgvMatches.Columns["GuestTeamName"].HeaderText = "Guest Team";
            dgvMatches.Columns["HomeTeamName"].HeaderText = "Home Team";
            dgvMatches.Columns["MatchScore"].HeaderText = "Score";

        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string add = "addPlayer";
            AddPlayer addPlayer = new AddPlayer(db, player, add);
            this.Hide();
            addPlayer.ShowDialog();
            this.Show();
        }

        private void showPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPlayers showPlayers = new ShowPlayers(db);
            this.Hide();
            showPlayers.ShowDialog();
            this.Show();
        }

        private void addColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string add = "addColor";
            AddColor addColor = new AddColor(db, colorPaint, add);
            this.Hide();
            addColor.ShowDialog();
            this.Show();
        }

        private void showColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowColors showColors = new ShowColors(db);
            this.Hide();
            showColors.ShowDialog();
            this.Show();
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string add = "addTeam";
            AddTeam addTeam = new AddTeam(db, team, add);
            this.Hide();
            addTeam.ShowDialog();
            this.Show();
        }

        private void showTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeams showTeams = new ShowTeams(db);
            this.Hide();
            showTeams.ShowDialog();
            this.Show();
        }

        private void btnNewChallenge_Click(object sender, EventArgs e)
        {
            string code = "addNewMatch";
            AddChallenge addChallenge = new AddChallenge(db,match,code);
            this.Hide();
            addChallenge.ShowDialog();
            this.Show();
            LoadMatches();
        }

        private void dgvMatches_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                return;
            }

            Match match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;

            pbHomeTeamLogo.ImageLocation = match.HomeTeam.Logo;
            pbHomeTeamLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            pbHomeTeamMascod.ImageLocation = match.HomeTeam.MascotPicture;
            pbHomeTeamMascod.SizeMode = PictureBoxSizeMode.StretchImage;

            pbGuestTeamLogo.ImageLocation = match.GuestTeam.Logo;
            pbGuestTeamLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            pbGuestTeamMascod.ImageLocation = match.GuestTeam.MascotPicture;
            pbGuestTeamMascod.SizeMode = PictureBoxSizeMode.StretchImage;

            lblScore.Text = match.MatchScore;
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            Match match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;

            DialogResult dr = MessageBox.Show("Are you sure to delete the match?", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                db.Matches.Remove(match);
                db.SaveChanges();
                MessageBox.Show("The match deleted.");
                ClearForm();
                LoadMatches();
            }
            else
                Close();

        }

        private void ClearForm()
        {
            pbGuestTeamLogo.ImageLocation = "";
            pbHomeTeamLogo.ImageLocation = "";
            pbHomeTeamMascod.ImageLocation = "";
            pbGuestTeamMascod.ImageLocation = "";

            lblGuestTeam.Text = "";
            lblHomeTeam.Text = "";
            lblScore.Text = "";
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            string code = "updateMatch";
            
            Match match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
            
            AddChallenge addChallenge = new AddChallenge(db, match, code);
            
            this.Hide();
            addChallenge.ShowDialog();
            this.Show();
            LoadMatches();
        }
    }
}
