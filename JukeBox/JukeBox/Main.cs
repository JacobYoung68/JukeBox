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
        //Genre name, number of tracks, track name

        //string[,] genre = new string[10,10];

        
        
        //Current genre selected
        int currentGenre;

        //Current Track Playing  
        int currentTrack;

        //Enable reading from files
        StreamReader sr = new StreamReader("../../Media.txt");  

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
            currentTrack = 1;

            //first read the file to setup the genre listbox
            readFile();

            
        }

        //private void update()
        //{
        //    txtGenreTitle.Text = genre[currentGenre,0];
        //    lbxGenreList.Items.Clear();
        //    updateGenrelist();
        //    //txtCurrentTrack.Text = genre[currentGenre, currentTrack + 1];
        //
        //}

        private void update(List<List<string>> genre)
        {
            txtGenreTitle.Text = genre[currentGenre].ToString();
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
            int genreNumber = Convert.ToInt32(sr.ReadLine());            
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
                if (lbxPlayList.Items.Count == 0)
                {
                    lbxPlayList.Items.Add(lbxGenreList.SelectedItem.ToString());                    
                } else if (lbxPlayList.Items.Count >= 1)
                {
                    lbxPlayList.Items.Add(lbxGenreList.SelectedItem.ToString());
                }
            }
             readFile();            
        }
    }
}
