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
        //Declare variables to store:        
        //Current genre selected
        int currentGenre;  

        public Main()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the Setup form
            Setup Setup = new Setup();
            Setup.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the About form
            About About = new About();
            About.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // set values for current genre and track
            // genre to 0 so it starts on the first
            // current track set to 1 because 0 is the name of the genre
            currentGenre = 0;

            //first read the file to setup the genre listbox
            readFile();

            
        }

        private void update(List<List<string>> genre)
        {
            txtGenreTitle.Text = genre[currentGenre][1].ToString();
            lbxGenreList.Items.Clear();
            updateGenrelist(genre);
            //txtCurrentTrack.Text = genre[currentGenre, currentTrack + 1];

        }

        private void updateGenrelist(List<List<string>> genre)
        {
            int max = Convert.ToInt32(genre[currentGenre][0]);
            for (int i = 0; i < max; i++)
            {
                lbxGenreList.Items.Add(genre[currentGenre][i + 2]);
            }                
        }

        private void readFile()
        {            
            // add file location to streamreader
            StreamReader sr = new StreamReader("../../Media.txt");

            // read in the number of genres from the file
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            //List of lists to hold Genre name, number of tracks, track names with a new list for each genre 
            List<List<string>> genre = new List<List<string>>();

            for (int i = 0; i < genreNumber; i++)
            {
                List<string> newgenre = new List<string>();
                int trackNumber = Convert.ToInt32(sr.ReadLine());
                newgenre.Add((trackNumber.ToString()));
                newgenre.Add(sr.ReadLine());
                for (int f = 0; f < trackNumber; f++)                    
                {
                    newgenre.Add(sr.ReadLine());                
                }
                genre.Add(newgenre);
            }
            // update the information depending on whats been read in the file
            update(genre);
        }



        private void lbxGenreList_DoubleClick(object sender, EventArgs e)
        {
            if (lbxGenreList.SelectedItem != null)
            {          
                if (lbxPlayList.Items.Count == 0 && txtCurrentTrack.Text == "")
                {
                    txtCurrentTrack.Text = lbxGenreList.SelectedItem.ToString();
                    playTrack();
                    
                }
                else if (lbxPlayList.Items.Count > 0 || (lbxPlayList.Items.Count == 0 && txtCurrentTrack.Text != ""))
                {
                    // add to the playlist
                    lbxPlayList.Items.Add(lbxGenreList.SelectedItem.ToString());
                }
            }
             readFile();            
        }

        private void playTrack()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            // select the track, play the track
            axWindowsMediaPlayer1.URL = filename();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnNextGenre_Click(object sender, EventArgs e)
        {
            // read in the number of genres from the file
            StreamReader sr = new StreamReader("../../Media.txt");
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            if (currentGenre < genreNumber - 1)
            {
                currentGenre = currentGenre + 1;
                readFile();
            }            
        }

        private void btnPreviousGenre_Click(object sender, EventArgs e)
        {
            // read in the number of genres from the file
            StreamReader sr = new StreamReader("../../Media.txt");
            int genreNumber = Convert.ToInt32(sr.ReadLine());

            if (currentGenre > 0)
            {
                currentGenre = currentGenre - 1;
                readFile();
            }
        }

        private string filename()
        {
            // combine the filename with the current directory, but up a few folders
            // this gives the full path to the current track
            string filename = txtCurrentTrack.Text;
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            string finalPath = newPath + "Tracks\\" + filename;
            return finalPath;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // if track has ended, enable timer
            if (e.newState == 8)
            {                
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // when timer interval has ticked
            txtCurrentTrack.Text = lbxPlayList.Items[0].ToString();
            lbxPlayList.Items.RemoveAt(0);
            playTrack();
            timer1.Enabled = false;
        }
    }
}

