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
    public partial class ShowPlayers : Form
    {
        private readonly ApplicationDbContext db;

        public ShowPlayers(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadPicture();
            LoadPlayers();
        }

        private void LoadPicture()
        {
            pbPicture.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Ball.png";
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadPlayers()
        {
            dgvPlayers.DataSource = db.Players.Select(x => new
            {
                x.PlayerId,
                x.Name,
                x.BirthPlace,
                x.BirthDate,
                x.Position,
                x.Rating,
                x.Team.TeamName,
                x.Pace,
                x.Shoot,
                x.Pass,
                x.Drippling,
                x.Physics,
                x.Defence,
            }).OrderByDescending(x => x.Rating).ToList();
            cboTeams.Items.Clear();
            cboTeams.Items.Insert(0, string.Empty);
            for (int i = 1; i <= db.Teams.ToList().Count; i++)
            {
                cboTeams.Items.Insert(i, db.Teams.ToList()[i - 1]);
            }
            cboTeams.DisplayMember = "TeamName";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            Player choosenPlayer = (Player)db.Players.Find(id);
            if (choosenPlayer == null)
            {
                return;
            }
            else
            {
                pbPlayerPhoto.ImageLocation = choosenPlayer.PlayerPhoto;
                pbPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            Player choosenPlayer = (Player)db.Players.Find(id);
            string update = "updatePlayer";
            AddPlayer addPlayer = new AddPlayer(db, choosenPlayer, update);
            this.Hide();
            addPlayer.ShowDialog();
            this.Show();
            LoadPlayers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            Player choosenPlayer = (Player)db.Players.Find(id);
            db.Players.Remove(choosenPlayer);
            db.SaveChanges();
            LoadPlayers();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex == -1)
            {
                return;
            }
            if (cboTeams.SelectedIndex == 0)
            {
                dgvPlayers.DataSource = db.Players.Select(x => new
                {
                    x.PlayerId,
                    x.Name,
                    x.BirthPlace,
                    x.BirthDate,
                    x.Position,
                    x.Rating,
                    x.Team.TeamName,
                    x.Pace,
                    x.Shoot,
                    x.Pass,
                    x.Drippling,
                    x.Physics,
                    x.Defence,
                }).OrderByDescending(x => x.Rating).ToList();
            }
            else
            {
                dgvPlayers.DataSource = null;
                Team team = cboTeams.SelectedItem as Team;
                List<Player> playerList = db.Players.Where(x => x.Team.TeamName == team.TeamName).ToList();
                dgvPlayers.DataSource = playerList.Select(x => new
                {
                    x.PlayerId,
                    x.Name,
                    x.BirthPlace,
                    x.BirthDate,
                    x.Position,
                    x.Rating,
                    x.Team.TeamName,
                    x.Pace,
                    x.Shoot,
                    x.Pass,
                    x.Drippling,
                    x.Physics,
                    x.Defence
                }).OrderByDescending(x => x.Rating).ToList();
            }
        }
    }
}
