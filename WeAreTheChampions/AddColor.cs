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
    public partial class AddColor : Form
    {
        private readonly ApplicationDbContext db;
        private readonly ColorPaint colorPaint;
        private readonly string code;

        public AddColor(ApplicationDbContext db, ColorPaint colorPaint, string code)
        {
            InitializeComponent();
            this.db = db;
            this.colorPaint = colorPaint;
            this.code = code;
            if (code == "updateColor")
            {
                this.Text = "Update Color";
                LoadUpdate();
            }
        }

        private void LoadUpdate()
        {
            btnAdd.Text = "Update";
            txtColorName.Text = colorPaint.ColorName;
            nudRed.Value = (int)colorPaint.Red;
            nudGreen.Value = (int)colorPaint.Green;
            nudBlue.Value = (int)colorPaint.Blue;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int red = (int)nudRed.Value;
            int green = (int)nudGreen.Value;
            int blue = (int)nudBlue.Value;

            Color colorOriginal = new Color();
            colorOriginal = Color.FromArgb(red, green, blue);
            pbColor.BackColor = colorOriginal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                ColorPaint color = new ColorPaint()
                {
                    ColorName = txtColorName.Text,
                    Red = (int)nudRed.Value,
                    Green = (int)nudGreen.Value,
                    Blue = (int)nudBlue.Value
                };
                db.Colors.Add(color);
                db.SaveChanges();
                MessageBox.Show($"{color.ColorName} added.");
                Close();
            }
            else
            {
                colorPaint.ColorName = txtColorName.Text;
                colorPaint.Red = (int)nudRed.Value;
                colorPaint.Green = (int)nudGreen.Value;
                colorPaint.Blue = (int)nudBlue.Value;
                db.SaveChanges();
                Close();
            }

        }
    }
}
