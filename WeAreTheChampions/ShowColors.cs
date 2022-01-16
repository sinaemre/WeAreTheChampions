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
    public partial class ShowColors : Form
    {
        private readonly ApplicationDbContext db;

        public ShowColors(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadPicture();
            LoadColors();
        }

        private void LoadPicture()
        {
            pbPicture.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Colors.jpeg";
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadColors()
        {
            dgvColors.DataSource = db.Colors.Select(x => new
            {
                x.ColorPaintId,
                x.ColorName,
                x.Red,
                x.Green,
                x.Blue
            }).ToList();
        }

        private void dgvColors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;
            ColorPaint choosenColor = (ColorPaint)db.Colors.Find(id);
            Color color = Color.FromArgb((int)choosenColor.Red, (int)choosenColor.Green, (int)choosenColor.Blue);
            pbColor.BackColor = color;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;
            ColorPaint choosenColor = (ColorPaint)db.Colors.Find(id);
            db.Colors.Remove(choosenColor);
            db.SaveChanges();
            LoadColors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "updateColor";
            if (dgvColors.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;
            ColorPaint choosenColor = (ColorPaint)db.Colors.Find(id);
            AddColor addColor = new AddColor(db, choosenColor, update);
            this.Hide();
            addColor.ShowDialog();
            this.Show();
            LoadColors();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
