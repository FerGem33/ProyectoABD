using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Futbol.Views.Parents;
using Futbol.Views.Children;

namespace Futbol.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // === General form ===
            this.BackColor = Color.Linen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // === MenuStrip ===
            menuStrip1.BackColor = Color.Linen;
            menuStrip1.ForeColor = Color.SaddleBrown;
            menuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new FlatMenuRenderer());

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.Linen;
                item.ForeColor = Color.SaddleBrown;

                // Style dropdown items too
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.BackColor = Color.Linen;
                    subItem.ForeColor = Color.SaddleBrown;
                }
            }

            // === ToolStripContainer ===
            toolStripContainer1.BackColor = Color.Linen;
            toolStripContainer1.ContentPanel.BackColor = Color.Linen;
            toolStripContainer1.TopToolStripPanel.BackColor = Color.Linen;

            // === Main panel ===
            mainContainer.BackColor = Color.Linen;
        }

        private void LoadView(UserControl view)
        {
            mainContainer.Controls.Clear();
            view.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(view);
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadView(new Partidos());
        }

        private void posicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadView(new Posiciones());
        }

        private void estadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadView(new Estadios());
        }

        private void ligasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadView(new Ligas());
        }
    }
}

public class FlatMenuRenderer : ProfessionalColorTable
{
    public override Color ToolStripDropDownBackground => Color.Linen;
    public override Color ImageMarginGradientBegin => Color.Linen;
    public override Color ImageMarginGradientMiddle => Color.Linen;
    public override Color ImageMarginGradientEnd => Color.Linen;
    public override Color MenuBorder => Color.SaddleBrown;
    public override Color MenuItemBorder => Color.SaddleBrown;
    public override Color MenuItemSelected => Color.FromArgb(255, 228, 196); // Light bisque
    public override Color MenuItemSelectedGradientBegin => Color.FromArgb(255, 228, 196);
    public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 228, 196);
}

