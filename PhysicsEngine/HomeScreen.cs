using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsEngine
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void ParticleBtn_Click(object sender, EventArgs e)
        {
            ParticleEngine.ParticleWindow window = new ParticleEngine.ParticleWindow();
            window.Show();
        }

        private void BallisticsBtn_Click(object sender, EventArgs e)
        {
            BallisticsEngine.BallisticsWindow window = new BallisticsEngine.BallisticsWindow();
            window.Show();
        }
    }
}
