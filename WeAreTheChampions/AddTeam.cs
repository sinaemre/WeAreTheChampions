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
    public partial class AddTeam : Form
    {
        private readonly ApplicationDbContext db;
        private readonly Team team;
        private readonly string code;

        public AddTeam(ApplicationDbContext db, Team team, string code)
        {
            InitializeComponent();
            this.db = db;
            this.team = team;
            this.code = code;
            if (code == "updateTeam")
            {
                this.Text = "Update Team";
            }
            LoadColorsPlayersAndPictures();
        }

        private void LoadColorsPlayersAndPictures()
        {
            if (code == "addTeam")
            {

                clbPlayers.DataSource = db.Players.Where(x => x.Team == null).OrderByDescending(x => x.Rating).ToList();
                clbPlayers.DisplayMember = "Name";
                if (clbPlayers.Items.Count == 0)
                {
                    MessageBox.Show("Sorry! There is no free players for now. If you still want to add team, you can add. After some player be free, you can add to your team.");
                }

                clbColors.DataSource = db.Colors.OrderByDescending(x => x.ColorName).ToList();
                clbColors.DisplayMember = "ColorName";

                pbLogo.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "ChampionsLeague.jpeg";
                pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

                pbMascod.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Mascot.png";
                pbMascod.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                btnAdd.Text = "Update";
                clbPlayers.DataSource = db.Players.Where(x => x.Team == null || x.TeamId == team.TeamId).OrderByDescending(x => x.Rating).ToList();
                clbPlayers.DisplayMember = "Name";
                if (db.Players.Where(x => x.Team == null).OrderByDescending(x => x.Rating).ToList().Count == 0)
                {
                    MessageBox.Show("Sorry! There is no free players for now. After some player be free, you can add to your team.");
                }
                for (int i = 0; i < clbPlayers.Items.Count; i++)
                {
                    Player player = (Player)clbPlayers.Items[i];
                    if (team.Players.Any(x => x.TeamId == team.TeamId))
                    {
                        clbPlayers.SetItemChecked(i, true);
                        if (player.Team == null)
                        {
                            clbPlayers.SetItemChecked(i, false);
                        }
                    }
                    else
                    {
                        clbPlayers.SetItemChecked(i, false);

                    }
                }
                clbColors.DataSource = db.Colors.OrderByDescending(x => x.ColorName).ToList();
                clbColors.DisplayMember = "ColorName";
                for (int i = 0; i < clbColors.Items.Count; i++)
                {
                    ColorPaint colorPaint = (ColorPaint)clbColors.Items[i];
                    if (team.Colors.Any(x => x.ColorPaintId == colorPaint.ColorPaintId))
                    {
                        clbColors.SetItemChecked(i, true);
                    }
                }
                txtTeamName.Text = team.TeamName;
                txtMascodName.Text = team.MascotName;
                txtLogoLocation.Text = team.Logo;
                txtMascodLocation.Text = team.MascotPicture;
            }
        }

        private void txtLogoLocation_TextChanged(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = txtLogoLocation.Text;
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            if (txtLogoLocation.Text == "")
            {
                pbLogo.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "ChampionsLeague.jpeg";
                pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtMascodLocation_TextChanged(object sender, EventArgs e)
        {
            pbMascod.ImageLocation = txtMascodLocation.Text;
            pbMascod.SizeMode = PictureBoxSizeMode.StretchImage;
            if (txtMascodLocation.Text == "")
            {
                pbMascod.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Mascot.png";
                pbMascod.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                List<Player> players = new List<Player>();

                foreach (Player player in clbPlayers.CheckedItems)
                {
                    players.Add(player);
                }

                Team team = new Team()
                {
                    TeamName = txtTeamName.Text,
                    MascotName = txtMascodName.Text,
                    Logo = txtLogoLocation.Text,
                    MascotPicture = txtMascodLocation.Text,
                    Players = players
                };
                if (txtLogoLocation.Text == "")
                {
                    team.Logo = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "ChampionsLeague.jpeg";
                }
                if (txtMascodLocation.Text == "")
                {
                    team.MascotPicture = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Mascot.png";
                }

                foreach (ColorPaint color in clbColors.CheckedItems)
                {
                    team.Colors.Add(color);
                }
                foreach (Player player in team.Players)
                {
                    team.TeamRating += player.Rating;
                }
                db.Teams.Add(team);
                db.SaveChanges();
                MessageBox.Show($"{team.TeamName} created.");
                Close();
            }
            
            else
            { 
                List<Player> players = new List<Player>();

                foreach (Player player in clbPlayers.CheckedItems)
                {
                    players.Add(player);
                }
                
                team.TeamName = txtTeamName.Text;
                team.MascotName = txtMascodName.Text;
                team.MascotPicture = txtMascodLocation.Text;
                team.Logo = txtLogoLocation.Text;
                team.Players.Clear();
                team.Players = players;
                
                if (txtLogoLocation.Text == "")
                {
                    team.Logo = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "ChampionsLeague.jpeg";
                }
                if (txtMascodLocation.Text == "")
                {
                    team.MascotPicture = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Mascot.png";
                }

                team.Colors.Clear();
                team.TeamRating = 0;
                foreach (ColorPaint color in clbColors.CheckedItems)
                {
                    team.Colors.Add(color);
                }
                foreach (Player player in team.Players)
                {
                    team.TeamRating += player.Rating;
                }
                db.SaveChanges();
                MessageBox.Show($"{team.TeamName} updated.");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = clbPlayers.SelectedItem as Player;
            pbPlayerPhoto.ImageLocation = player.PlayerPhoto;
            pbPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void clbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorPaint colorPaint = clbColors.SelectedItem as ColorPaint;
            Color color = Color.FromArgb((int)colorPaint.Red, (int)colorPaint.Green, (int)colorPaint.Blue);
            pbColor.BackColor = color;
        }
    }
}
