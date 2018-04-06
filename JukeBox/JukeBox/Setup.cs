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
    public partial class Setup : Form
    {
        private Button btnOkay;
        private GroupBox gbxMain;
        private Button btnDeleteTrackFromGenre;
        private Button btnMove;
        private Button btnCopy;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnNext;
        private Button btnAdd;
        private Button btnPrevious;
        private ListBox lbxGenreTrackList;
        private TextBox tbxGenreTitle;
        private Label label1;
        private GroupBox gbxImportedTracks;
        private Button btnClearImport;
        private ListBox lbxImportedTracks;
        private Button btnImport;
        private Button btnCancel;

        int currentGenre = 0;

        public Setup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.btnDeleteTrackFromGenre = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbxGenreTrackList = new System.Windows.Forms.ListBox();
            this.tbxGenreTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxImportedTracks = new System.Windows.Forms.GroupBox();
            this.btnClearImport = new System.Windows.Forms.Button();
            this.lbxImportedTracks = new System.Windows.Forms.ListBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbxMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxImportedTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(479, 330);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(96, 38);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(581, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxMain
            // 
            this.gbxMain.BackColor = System.Drawing.Color.Transparent;
            this.gbxMain.Controls.Add(this.btnDeleteTrackFromGenre);
            this.gbxMain.Controls.Add(this.btnMove);
            this.gbxMain.Controls.Add(this.btnCopy);
            this.gbxMain.Controls.Add(this.groupBox2);
            this.gbxMain.Controls.Add(this.gbxImportedTracks);
            this.gbxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxMain.Location = new System.Drawing.Point(2, 3);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(677, 319);
            this.gbxMain.TabIndex = 4;
            this.gbxMain.TabStop = false;
            // 
            // btnDeleteTrackFromGenre
            // 
            this.btnDeleteTrackFromGenre.Location = new System.Drawing.Point(281, 216);
            this.btnDeleteTrackFromGenre.Name = "btnDeleteTrackFromGenre";
            this.btnDeleteTrackFromGenre.Size = new System.Drawing.Size(101, 55);
            this.btnDeleteTrackFromGenre.TabIndex = 11;
            this.btnDeleteTrackFromGenre.Text = "Delete Track From Genre";
            this.btnDeleteTrackFromGenre.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(281, 119);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(101, 23);
            this.btnMove.TabIndex = 10;
            this.btnMove.Text = "Move Track >>>";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(281, 90);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(101, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy Track >>>";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.lbxGenreTrackList);
            this.groupBox2.Controls.Add(this.tbxGenreTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(388, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 283);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre Track List";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(99, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(179, 222);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 55);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(9, 222);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 55);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbxGenreTrackList
            // 
            this.lbxGenreTrackList.FormattingEnabled = true;
            this.lbxGenreTrackList.Location = new System.Drawing.Point(6, 58);
            this.lbxGenreTrackList.Name = "lbxGenreTrackList";
            this.lbxGenreTrackList.Size = new System.Drawing.Size(257, 160);
            this.lbxGenreTrackList.TabIndex = 2;
            // 
            // tbxGenreTitle
            // 
            this.tbxGenreTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbxGenreTitle.Location = new System.Drawing.Point(6, 32);
            this.tbxGenreTitle.Name = "tbxGenreTitle";
            this.tbxGenreTitle.ReadOnly = true;
            this.tbxGenreTitle.Size = new System.Drawing.Size(257, 20);
            this.tbxGenreTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Title";
            // 
            // gbxImportedTracks
            // 
            this.gbxImportedTracks.Controls.Add(this.btnClearImport);
            this.gbxImportedTracks.Controls.Add(this.lbxImportedTracks);
            this.gbxImportedTracks.Controls.Add(this.btnImport);
            this.gbxImportedTracks.Location = new System.Drawing.Point(6, 19);
            this.gbxImportedTracks.Name = "gbxImportedTracks";
            this.gbxImportedTracks.Size = new System.Drawing.Size(269, 283);
            this.gbxImportedTracks.TabIndex = 7;
            this.gbxImportedTracks.TabStop = false;
            this.gbxImportedTracks.Text = "Imported Tracks";
            // 
            // btnClearImport
            // 
            this.btnClearImport.Location = new System.Drawing.Point(6, 254);
            this.btnClearImport.Name = "btnClearImport";
            this.btnClearImport.Size = new System.Drawing.Size(257, 23);
            this.btnClearImport.TabIndex = 8;
            this.btnClearImport.Text = "Clear Import Tracks";
            this.btnClearImport.UseVisualStyleBackColor = true;
            this.btnClearImport.Click += new System.EventHandler(this.btnClearImport_Click);
            // 
            // lbxImportedTracks
            // 
            this.lbxImportedTracks.FormattingEnabled = true;
            this.lbxImportedTracks.Location = new System.Drawing.Point(6, 19);
            this.lbxImportedTracks.Name = "lbxImportedTracks";
            this.lbxImportedTracks.Size = new System.Drawing.Size(257, 199);
            this.lbxImportedTracks.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 224);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(257, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import Tracks From Directory";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Setup
            // 
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.gbxMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.gbxMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxImportedTracks.ResumeLayout(false);
            this.ResumeLayout(false);

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
            update(genre);
        }

        private void update(List<List<string>> genre)
        {
            tbxGenreTitle.Text = genre[currentGenre][1].ToString();
            lbxGenreTrackList.Items.Clear();
            updateGenrelist(genre);
            //txtCurrentTrack.Text = genre[currentGenre, currentTrack + 1];
        }

        private void updateGenrelist(List<List<string>> genre)
        {
            int max = Convert.ToInt32(genre[currentGenre][0]);
            for (int i = 0; i < max; i++)
            {
                lbxGenreTrackList.Items.Add(genre[currentGenre][i + 2]);
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            readFile();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
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

        private void btnNext_Click(object sender, EventArgs e)
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            // IMPORT TRACKS
            OpenFileDialog newDialogue = new OpenFileDialog();
            newDialogue.Title = "Import Track";
            newDialogue.Filter = "Music files (*.mp3, *.wma) | *.mp3; *.wma";            
            if (newDialogue.ShowDialog() == DialogResult.OK)
            {
                lbxImportedTracks.Items.Add(newDialogue.SafeFileName.ToString());
            }
        }

        private void btnClearImport_Click(object sender, EventArgs e)
        {
            lbxImportedTracks.Items.Clear();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // set the variables for the messagebox options 
            // ask if the user wants to close the form without saving changes
            string message = "Are you sure you want to cancel?";
            string error = "error";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // close the form without passing back variables 
            result = MessageBox.Show(message, error, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
