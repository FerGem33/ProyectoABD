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
    }
}
