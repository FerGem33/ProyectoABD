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
            mainContainer.Controls.Clear();
            var uc = new Partidos();
            uc.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(uc);
        }
    }
}
