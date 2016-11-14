namespace MovieBonanza
{
    partial class SelectionForm
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
            this.SelectionListBox = new System.Windows.Forms.ListBox();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionListBox
            // 
            this.SelectionListBox.FormattingEnabled = true;
            this.SelectionListBox.ItemHeight = 26;
            this.SelectionListBox.Items.AddRange(new object[] {
            "Season of the Witch",
            "The Green Hornet",
            "The Dilemma",
            "Death Race 2",
            "Company Men",
            "No Strings Attached",
            "The Way Back",
            "The Mechanic",
            "The Rite Horror Sanctum",
            "The Other Woman",
            "The Roommate",
            "Waiting for Forever",
            "Cedar Rapids",
            "Gnomeo and Juliet",
            "Just Go With It",
            "The Eagle",
            "I Am Number Four",
            "Footloose",
            "Real Steel"});
            this.SelectionListBox.Location = new System.Drawing.Point(42, 102);
            this.SelectionListBox.Name = "SelectionListBox";
            this.SelectionListBox.Size = new System.Drawing.Size(227, 290);
            this.SelectionListBox.TabIndex = 0;
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.GenreLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectionGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(275, 102);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(470, 272);
            this.SelectionGroupBox.TabIndex = 1;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(258, 172);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(54, 23);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(253, 107);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(69, 23);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(253, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(54, 23);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(253, 202);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(178, 31);
            this.CostTextBox.TabIndex = 3;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(253, 130);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(178, 31);
            this.GenreTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(253, 61);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(178, 31);
            this.TitleTextBox.TabIndex = 1;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(18, 34);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(171, 222);
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(37, 72);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(168, 27);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Our Selection";
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.Location = new System.Drawing.Point(36, 9);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(314, 32);
            this.FormTitleLabel.TabIndex = 3;
            this.FormTitleLabel.Text = "Make A Film Selection";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(634, 408);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(111, 37);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(517, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 37);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 457);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FormTitleLabel);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.SelectionListBox);
            this.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SelectionListBox;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

