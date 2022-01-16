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
    public partial class ShowTeams : Form
    {
        private readonly ApplicationDbContext db;
        
        public ShowTeams(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadTeams();
        }

        private void LoadTeams()
        {
            //if (dgvTeams.SelectedRows.Count == 0)
            //{
            //    return;
            //}
            dgvTeams.DataSource = db.Teams.Select(x => new 
            {
                x.TeamId,
                x.TeamName,
                x.TeamRating
            }).ToList();
        }

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team team = db.Teams.Find(id);

            pbLogo.ImageLocation = team.Logo;
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            pbMascod.ImageLocation = team.MascotPicture;
            pbMascod.SizeMode = PictureBoxSizeMode.StretchImage;

            dgvPlayers.DataSource = team.Players.Select(x => new 
            {
                x.PlayerId,
                x.Name,
                x.Rating
            }).ToList();
            lstColors.DataSource = team.Colors.ToList();
            lstColors.DisplayMember = "ColorName";
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorPaint colorPaint = lstColors.SelectedItem as ColorPaint;
            Color color = Color.FromArgb((int)colorPaint.Red, (int)colorPaint.Green, (int)colorPaint.Blue);
            pbColor.BackColor = color;
        }

        private void btnShowAllPlayers_Click(object sender, EventArgs e)
        {
            ShowPlayers showPlayers = new ShowPlayers(db);
            this.Hide();
            showPlayers.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team chooseTeam = db.Teams.Find(id);
            MessageBox.Show($"{chooseTeam.TeamName} deleted.");
            db.Teams.Remove(chooseTeam);
            db.SaveChanges();
            LoadTeams();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string update = "updateTeam";
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team chooseTeam = db.Teams.Find(id);
            AddTeam addTeam = new AddTeam(db, chooseTeam, update);
            this.Hide();
            addTeam.ShowDialog();
            this.Show();
            LoadTeams();
        }
    }
}
