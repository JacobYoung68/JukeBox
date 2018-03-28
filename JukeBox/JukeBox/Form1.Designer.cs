namespace JukeBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtGenreTitle = new System.Windows.Forms.TextBox();
            this.lbxGenreList = new System.Windows.Forms.ListBox();
            this.txtCurrentTrack = new System.Windows.Forms.TextBox();
            this.lbxPlayList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Silver;
            this.lblCopyright.Location = new System.Drawing.Point(187, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(159, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright © 2018. Jacob Young";
            // 
            // txtGenreTitle
            // 
            this.txtGenreTitle.Location = new System.Drawing.Point(120, 110);
            this.txtGenreTitle.Name = "txtGenreTitle";
            this.txtGenreTitle.ReadOnly = true;
            this.txtGenreTitle.Size = new System.Drawing.Size(120, 20);
            this.txtGenreTitle.TabIndex = 1;
            // 
            // lbxGenreList
            // 
            this.lbxGenreList.FormattingEnabled = true;
            this.lbxGenreList.HorizontalScrollbar = true;
            this.lbxGenreList.Location = new System.Drawing.Point(120, 136);
            this.lbxGenreList.Name = "lbxGenreList";
            this.lbxGenreList.Size = new System.Drawing.Size(120, 95);
            this.lbxGenreList.TabIndex = 2;
            // 
            // txtCurrentTrack
            // 
            this.txtCurrentTrack.BackColor = System.Drawing.Color.Lime;
            this.txtCurrentTrack.Location = new System.Drawing.Point(85, 259);
            this.txtCurrentTrack.Name = "txtCurrentTrack";
            this.txtCurrentTrack.ReadOnly = true;
            this.txtCurrentTrack.Size = new System.Drawing.Size(185, 20);
            this.txtCurrentTrack.TabIndex = 3;
            // 
            // lbxPlayList
            // 
            this.lbxPlayList.FormattingEnabled = true;
            this.lbxPlayList.Location = new System.Drawing.Point(120, 285);
            this.lbxPlayList.Name = "lbxPlayList";
            this.lbxPlayList.Size = new System.Drawing.Size(120, 95);
            this.lbxPlayList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 485);
            this.Controls.Add(this.lbxPlayList);
            this.Controls.Add(this.txtCurrentTrack);
            this.Controls.Add(this.lbxGenreList);
            this.Controls.Add(this.txtGenreTitle);
            this.Controls.Add(this.lblCopyright);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtGenreTitle;
        private System.Windows.Forms.ListBox lbxGenreList;
        private System.Windows.Forms.TextBox txtCurrentTrack;
        private System.Windows.Forms.ListBox lbxPlayList;
    }
}

