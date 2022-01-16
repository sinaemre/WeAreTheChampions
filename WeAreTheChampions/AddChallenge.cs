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
    public partial class AddChallenge : Form
    {
        private readonly ApplicationDbContext db;
        private readonly Match match;
        private readonly string code;

        public AddChallenge(ApplicationDbContext db, Match match, string code)
        {
            InitializeComponent();
            this.db = db;
            this.match = match;
            this.code = code;
            LoadDtpAndTeams();
        }

        private void LoadDtpAndTeams()
        {
            dtpMatchTime.CustomFormat = "dd/MM/yyyy HH:mm";

            cboHomeTeam.DataSource = db.Teams.ToList();
            cboHomeTeam.DisplayMember = "TeamName";

            cboGuestTeam.DataSource = db.Teams.ToList();
            cboGuestTeam.DisplayMember = "TeamName";

            if (code == "updateMatch")
            {
                btnAdd.Text = "Update";

                cboHomeTeam.SelectedItem = match.HomeTeam;
                cboGuestTeam.SelectedItem = match.GuestTeam;

                if (match.HomeScore != null && match.AwayScore != null)
                {
                    nudHomeScore.Value = (int)match.HomeScore;
                    nudGuestScore.Value = (int)match.AwayScore;
                }
                else
                {
                    nudHomeScore.Value = 0;
                    nudGuestScore.Value = 0;

                }

                dtpMatchTime.Value = match.MatchTime;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Team teamHome = (Team)cboHomeTeam.SelectedItem;
            Team teamGuest = (Team)cboGuestTeam.SelectedItem;

            if (teamHome == teamGuest)
            {
                MessageBox.Show("Teams can't be same!");
                return;
            }

            Result result = Result.NULL;
            if (nudHomeScore.Enabled == false && nudGuestScore.Enabled == false)
                result = Result.NULL;
            else if (nudHomeScore.Value > nudGuestScore.Value)
                result = Result.One;
            else if (nudHomeScore.Value < nudGuestScore.Value)
                result = Result.Two;
            else if (nudHomeScore.Value == nudHomeScore.Value)
                result = Result.Zero;

            if (btnAdd.Text == "Add")
            {
                Match matchCreated = new Match()
                {
                    HomeTeam = teamHome,
                    GuestTeam = teamGuest,
                    HomeTeamName = teamHome.TeamName,
                    GuestTeamName = teamGuest.TeamName,
                    HomeScore = (int)nudHomeScore.Value,
                    AwayScore = (int)nudGuestScore.Value,
                    MatchScore = nudHomeScore.Value.ToString() + " - " + nudGuestScore.Value.ToString(),
                    MatchTime = dtpMatchTime.Value,
                    Result = (Result)result
                };

                if (dtpMatchTime.Value >= DateTime.Now)
                {
                    matchCreated.MatchScore = "Not Played";
                    matchCreated.HomeScore = null;
                    matchCreated.AwayScore = null;
                }

                db.Matches.Add(matchCreated);
                db.SaveChanges();
                MessageBox.Show("The match created.");
                Close();
            }

            else
            {
                match.HomeTeam = teamHome;
                match.HomeTeamName = teamHome.TeamName;
                match.GuestTeam = teamGuest;
                match.GuestTeamName = teamGuest.TeamName;
                match.MatchTime = dtpMatchTime.Value;
                match.HomeScore = (int)nudHomeScore.Value;
                match.AwayScore = (int)nudGuestScore.Value;
                match.MatchScore = nudHomeScore.Value.ToString() + " - " + nudGuestScore.Value.ToString();
                match.Result = result;

                if (dtpMatchTime.Value >= DateTime.Now)
                {
                    match.MatchScore = "Not Played";
                    match.HomeScore = null;
                    match.AwayScore = null;
                }

                db.SaveChanges();
                MessageBox.Show("The match updated.");
                Close();
            }
        }

        private void dtpMatchTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpMatchTime.Value >= DateTime.Now)
            {
                nudHomeScore.Enabled = false;
                nudGuestScore.Enabled = false;
            }
            else
            {
                nudHomeScore.Enabled = true;
                nudGuestScore.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
