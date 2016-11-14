namespace MovieBonanza
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.DVDLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SelectedMovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedMovieGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(12, 40);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(279, 502);
            this.SelectedMovieGroupBox.TabIndex = 1;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(24, 188);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(227, 308);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 7;
            this.MoviePictureBox.TabStop = false;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(24, 76);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(227, 31);
            this.TitleTextBox.TabIndex = 6;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(24, 136);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(227, 31);
            this.GenreTextBox.TabIndex = 5;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(20, 110);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(69, 23);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(20, 50);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(54, 23);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.OrderGroupBox.Controls.Add(this.TotalLabel);
            this.OrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.OrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.OrderGroupBox.Controls.Add(this.TotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.DVDTextBox);
            this.OrderGroupBox.Controls.Add(this.CostTextBox);
            this.OrderGroupBox.Controls.Add(this.CostLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.DVDLabel);
            this.OrderGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBox.Location = new System.Drawing.Point(297, 90);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(564, 384);
            this.OrderGroupBox.TabIndex = 2;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order ";
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVDCheckBox.Location = new System.Drawing.Point(110, 301);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(315, 27);
            this.DVDCheckBox.TabIndex = 15;
            this.DVDCheckBox.Text = "Order The DVD ($10 Charge)";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(154, 254);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(65, 23);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(60, 212);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(159, 23);
            this.SalesTaxLabel.TabIndex = 13;
            this.SalesTaxLabel.Text = "Sales Tax(13%):";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(245, 204);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(180, 31);
            this.SalesTaxTextBox.TabIndex = 12;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(245, 246);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(180, 31);
            this.TotalTextBox.TabIndex = 11;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(245, 138);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(180, 31);
            this.SubTotalTextBox.TabIndex = 10;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(245, 60);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(180, 31);
            this.CostTextBox.TabIndex = 9;
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.Location = new System.Drawing.Point(245, 99);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.ReadOnly = true;
            this.DVDTextBox.Size = new System.Drawing.Size(180, 31);
            this.DVDTextBox.TabIndex = 8;
            this.DVDTextBox.Text = "$10.00";
            this.DVDTextBox.Visible = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(159, 68);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(60, 23);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // DVDLabel
            // 
            this.DVDLabel.AutoSize = true;
            this.DVDLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVDLabel.Location = new System.Drawing.Point(110, 107);
            this.DVDLabel.Name = "DVDLabel";
            this.DVDLabel.Size = new System.Drawing.Size(109, 23);
            this.DVDLabel.TabIndex = 6;
            this.DVDLabel.Text = "DVD Cost:";
            this.DVDLabel.Visible = false;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(117, 146);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(102, 23);
            this.SubTotalLabel.TabIndex = 7;
            this.SubTotalLabel.Text = "Sub-Total";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(307, 504);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(103, 38);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamButton.Location = new System.Drawing.Point(700, 480);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(161, 62);
            this.StreamButton.TabIndex = 4;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(416, 504);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 38);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 554);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label DVDLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button CancelButton;
    }
}