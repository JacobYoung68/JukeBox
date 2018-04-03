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
        string[,] genre = new string[10,10];
        int currentGenre;
        int currentTrack;
        StreamReader sr = new StreamReader("../../Media.txt");

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
            currentGenre = 0;
            currentTrack = 1;
            readFile();
            update();
        }

        private void update()
        {
            txtGenreTitle.Text = genre[currentGenre,0];
            txtCurrentTrack.Text = genre[currentGenre, currentTrack + 1];
            updateGenrelist();
        }

        private void updateGenrelist()
        {
            int max = Convert.ToInt32(genre[currentGenre, 1]);
            for (int i = 0; i < max; i++)
            {
                lbxGenreList.Items.Add(genre[currentGenre, i + 2]);
            }                
        }

        private void readFile()
        {
            int genreNumber = Convert.ToInt32(sr.ReadLine());
            int countGenre = 0;
            
            while (genreNumber != 0)
            {
                int countTrack = 2;
                int trackNumber = Convert.ToInt32(sr.ReadLine());
                genre[countGenre, 1] = trackNumber.ToString();
                genre[countGenre, 0] = sr.ReadLine();
                while (trackNumber != 0)
                {                    
                    genre[countGenre,countTrack] = sr.ReadLine();
                    countTrack++;
                    trackNumber--;
                }
                countGenre++;
                genreNumber--;
            }
        }
    }
}
