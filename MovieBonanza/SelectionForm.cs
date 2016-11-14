using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Assignment 3 Movie Bonanaza
 * Georgios Psarakis
 * November 8th 2016
 * 200289922 
 * Steraming movie service with the option to order the DVD 
 */
namespace MovieBonanza
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            TitleTextBox.Text = Convert.ToString(SelectionListBox.Text);
            CheckSelection();
            SetPoster();
            SaveSelection();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();

            orderForm.Show();
            this.Hide();
        }
        private void CheckSelection()
        {
            /* 
             * This if chain will check the TitleTextBox for a film title 
             * if it meets one of the checks its GenereTextBox will be set to 
             * either Comedy, Family, Horror, Thriller, Sci-Fi, Action, Drama or New Release.              
             */
            if (TitleTextBox.Text == "The Dilemma" || TitleTextBox.Text == "No Strings Attached" ||
                TitleTextBox.Text == "Cedar Rapids" || TitleTextBox.Text == "Just Go With It")
            {
                GenreTextBox.Text = "Comedy";
            }
            else if (TitleTextBox.Text == "Gnomeo And Juliet")
            {
                GenreTextBox.Text = "Family";
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                GenreTextBox.Text = "Horror";
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                GenreTextBox.Text = "Thriller";
            }
            else if (TitleTextBox.Text == "Season Of The Witch" || TitleTextBox.Text == "I Am Number Four")
            {
                GenreTextBox.Text = "Sci-Fi";
            }
            else if (TitleTextBox.Text == "The Green Hornet" || TitleTextBox.Text == "Death Race 2" || TitleTextBox.Text == "The Mechanic" ||
                TitleTextBox.Text == "Sanctum" || TitleTextBox.Text == "The Other Woman" || TitleTextBox.Text == "The Eagle")
            {
                GenreTextBox.Text = "Action";
            }
            else if (TitleTextBox.Text == "The Company Men" || TitleTextBox.Text == "The Way Back" || TitleTextBox.Text == "Waiting For Forever")
            {
                GenreTextBox.Text = "Drama";
            }
            else GenreTextBox.Text = "New Release";
            /*
             * This If chain will check the Genre box and set the cost box
             * the correct price based on the genre  
             */
            if (GenreTextBox.Text == "Comedy")
            {
                CostTextBox.Text = "$1.99";
            }

            else if (GenreTextBox.Text == "Family")
            {
                CostTextBox.Text = "$0.99";
            }
            else if (GenreTextBox.Text == "Horror")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (GenreTextBox.Text == "Thriller")
            {
                CostTextBox.Text = "$1.99";
            }
            else if (GenreTextBox.Text == "Sci-Fi")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (GenreTextBox.Text == "Action")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (GenreTextBox.Text == "Drama")
            {
                CostTextBox.Text = "$1.99";
            }
            else CostTextBox.Text = "$4.99";
        }

        /*
         * This will Check the Title and Set the correct poster based on the title in the 
         * TitleTextBox and also save it to the global Poster Movies class.
         */
        public void SetPoster()
        {
            if (TitleTextBox.Text == "Season Of The Witch")
            {
                MoviePictureBox.Image = Properties.Resources.SeasonOfTheWitch;
                Program.SelectionInfo.Poster = Properties.Resources.SeasonOfTheWitch;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            {
                MoviePictureBox.Image = Properties.Resources.TheGreenHornet;
                Program.SelectionInfo.Poster = Properties.Resources.TheGreenHornet;
            }
            else if (TitleTextBox.Text == "The Dilemma")
            {
                MoviePictureBox.Image = Properties.Resources.TheDilemma;
                Program.SelectionInfo.Poster = Properties.Resources.TheDilemma;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.DeathRace2;
                Program.SelectionInfo.Poster = Properties.Resources.DeathRace2;
            }
            else if (TitleTextBox.Text == "The Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.TheCompanyMen;
                Program.SelectionInfo.Poster = Properties.Resources.TheCompanyMen;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.NoStringsAttached;
                Program.SelectionInfo.Poster = Properties.Resources.NoStringsAttached;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.TheWayBack;
                Program.SelectionInfo.Poster = Properties.Resources.TheWayBack;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.TheMechanic;
                Program.SelectionInfo.Poster = Properties.Resources.TheMechanic;
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.TheRite;
                Program.SelectionInfo.Poster = Properties.Resources.TheRite;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.Sanctum;
                Program.SelectionInfo.Poster = Properties.Resources.Sanctum;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.TheOtherWoman;
                Program.SelectionInfo.Poster = Properties.Resources.TheOtherWoman;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.TheRoommate;
                Program.SelectionInfo.Poster = Properties.Resources.TheRoommate;
            }
            else if (TitleTextBox.Text == "Waiting For Forever")
            {
                MoviePictureBox.Image = Properties.Resources.WaitingForForever;
                Program.SelectionInfo.Poster = Properties.Resources.WaitingForForever;
            }
            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.CedarRapids;
                Program.SelectionInfo.Poster = Properties.Resources.CedarRapids;
            }
            else if (TitleTextBox.Text == "Gnomeo And Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.GnomeoAndJuliet;
                Program.SelectionInfo.Poster = Properties.Resources.GnomeoAndJuliet;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = Properties.Resources.JustGoWithIt;
                Program.SelectionInfo.Poster = Properties.Resources.JustGoWithIt;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.TheEagle;
                Program.SelectionInfo.Poster = Properties.Resources.TheEagle;
            }
            else if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.IAmNumberFour;
                Program.SelectionInfo.Poster = Properties.Resources.IAmNumberFour;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.Footloose;
                Program.SelectionInfo.Poster = Properties.Resources.Footloose;
            }
            else
            {  MoviePictureBox.Image = Properties.Resources.RealSteel;
                Program.SelectionInfo.Poster = Properties.Resources.RealSteel;
            }


        }
        /*
         * This will save the selections a user has made 
         * for the title cost and genre. 
         */
        private void SaveSelection()
        {
            Program.SelectionInfo.Title = TitleTextBox.Text;
            Program.SelectionInfo.Cost = CostTextBox.Text.TrimStart('$');
            Program.SelectionInfo.Genre = GenreTextBox.Text;
           
            
        }
        /*
         * This will be used for calling back to this form from 
         * OrderFrom so the data is saved. 
         */
        public void PreviousFormSelections()
        {
            TitleTextBox.Text = Program.SelectionInfo.Title;
            GenreTextBox.Text = Program.SelectionInfo.Genre;
            CostTextBox.Text = Program.SelectionInfo.Cost;


            SelectionListBox.Text = TitleTextBox.Text;
        }




    }
}
