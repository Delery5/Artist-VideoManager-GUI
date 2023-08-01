namespace Harrison_CourseProject_Part1
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.songListLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(111, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(199, 84);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(270, 32);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(199, 153);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(270, 32);
            this.artistText.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(111, 159);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(68, 26);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist:";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(199, 216);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(270, 32);
            this.genreText.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(111, 222);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(78, 26);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(199, 279);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(270, 32);
            this.yearText.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(111, 282);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(65, 26);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(199, 348);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(270, 32);
            this.urlText.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(111, 348);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(62, 26);
            this.urlLabel.TabIndex = 8;
            this.urlLabel.Text = "URL:";
            this.urlLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(156, 420);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(235, 81);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Song";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(576, 449);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(410, 385);
            this.outputText.TabIndex = 11;
            this.outputText.TabStop = false;
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 25;
            this.songList.Location = new System.Drawing.Point(576, 138);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(410, 254);
            this.songList.TabIndex = 12;
            this.songList.TabStop = false;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.Location = new System.Drawing.Point(156, 522);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(235, 81);
            this.allSongsButton.TabIndex = 6;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = true;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Location = new System.Drawing.Point(571, 84);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(109, 26);
            this.songListLabel.TabIndex = 14;
            this.songListLabel.Text = "Song List:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(571, 420);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(85, 26);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(156, 627);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(235, 81);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(156, 737);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(235, 81);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(1046, 138);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(624, 465);
            this.webViewDisplay.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.ZoomFactor = 1D;
            this.webViewDisplay.Click += new System.EventHandler(this.webView21_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(1046, 627);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(235, 81);
            this.PlayButton.TabIndex = 19;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 856);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button PlayButton;
    }
}

