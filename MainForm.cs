using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Harrison_CourseProject_Part1
{
    public partial class MainForm : Form
    {

        // class level referneces
        String[] titleArray = new String[5];
        String[] artistArray = new String[5];
        String[] genreArray = new String[5];
        int[] yearArray = new int[5];
        String[] urlArray = new String[5];
        int songCount = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        public bool validInput() 
        {
            // Return true if all fields are non-empty
            bool isValid = true;

            if (String.IsNullOrEmpty(titleText.Text))
            {
                //Title is blank
                MessageBox.Show("The song title cannot be blank.");
                isValid = false;
            }
            else if (String.IsNullOrEmpty(artistText.Text))
            {
                //Artist is blank
                MessageBox.Show("The artist cannot be blank.");
                isValid = false;
            }
            else if (String.IsNullOrEmpty(genreText.Text))
            {
                //Genre is blank
                MessageBox.Show("The genre cannot be blank.");
                isValid = false;
            }
            else if (String.IsNullOrEmpty(yearText.Text))
            {
                //Year is blank
                MessageBox.Show("The year cannot be blank.");
                isValid = false;
            }
            else if (String.IsNullOrEmpty(urlText.Text))
            {
                //URL is blank
                MessageBox.Show("The url cannot be blank.");
                isValid = false;
            }

            return isValid;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string n1 = "\r\n";

           
            if(validInput() )
            {
                // Add title to ListBox and song list
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreText.Text;
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                // Increment the song counter
                songCount++;

                // Build the output text
                sb.Append(titleText.Text);
                sb.Append(n1);
                sb.Append(artistText.Text);
                sb.Append(n1);
                sb.Append(genreText.Text);
                sb.Append(n1);
                sb.Append(yearText.Text);
                sb.Append(n1);
                sb.Append(urlText.Text);
                sb.Append(n1);
                sb.Append(n1);     // blank line

                outputText.Text = sb.ToString();
            }
           
        }

        private bool SongInList(String songTitle)
        {
            bool found = false;

            foreach (var item in songList.Items)
            {
                String currentSong = item as String;
                // lowercase comparison not case sensitive
                if (songTitle.ToLower() == currentSong.ToLower() )
                {
                    found = true;
                }
            }
            return found;
        }

        private int GetSongIndex(String songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;

            // If song is selected (index greater than -1), show the details
            if (songIndex > -1)
            {
                StringBuilder sb = new StringBuilder(String.Empty);
                string n1 = "\r\n";

                // Build the output text
                sb.Append(titleText.Text);
                sb.Append(n1);
                sb.Append(artistText.Text);
                sb.Append(n1);
                sb.Append(genreText.Text);
                sb.Append(n1);
                sb.Append(yearText.Text);
                sb.Append(n1);
                sb.Append(urlText.Text);
                sb.Append(n1);
                sb.Append(n1);     // blank line

                outputText.Text = sb.ToString();
            }
        }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(String.Empty);
            string n1 = "\r\n";

            // Build the output text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(n1);
            }

            // Put the output text into the output textbox
            outputText.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SongInList(titleText.Text) )
            {
                StringBuilder sb = new StringBuilder(String.Empty);
                string n1 = "\r\n";

                int songIndex = GetSongIndex(titleText.Text);

                // Build the output text
                sb.Append(titleArray[songIndex]);
                sb.Append(n1);
                sb.Append(artistArray[songIndex]);
                sb.Append(n1);
                sb.Append(genreArray[songIndex]);
                sb.Append(n1);
                sb.Append(yearArray[songIndex]);
                sb.Append(n1);
                sb.Append(urlArray[songIndex]);
                sb.Append(n1);

                outputText.Text = sb.ToString();
            }
    }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Text = ""; // one way to clear textbox
            artistText.Text = String.Empty; // senond way to clear textbox
            genreText.Clear();   // third way to clear textbox
            yearText.Clear();
            urlText.Clear();

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            String url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }
    }
}
