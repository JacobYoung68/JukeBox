using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JukeBox
{
    public partial class Main : Form
    {
        string[,] genre = new string[10,3];
        int currentGenre;
        int currentTrack;

        public Main()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup Setup = new Setup();
            Setup.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void update()
        {
            txtGenreTitle.Text = genre[currentGenre,2];
            txtCurrentTrack.Text = genre[]
        }
    }
}
