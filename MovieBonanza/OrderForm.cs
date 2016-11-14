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
 */
namespace MovieBonanza
{
    public partial class OrderForm : Form
    {
        SelectionForm selectionForm = new SelectionForm();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.SelectionInfo.Title;
            GenreTextBox.Text = Program.SelectionInfo.Genre;
            CostTextBox.Text = "$" + Program.SelectionInfo.Cost;
            MoviePictureBox.Image = Program.SelectionInfo.Poster;

            getTotals();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            selectionForm.Show();
            this.Hide();
            selectionForm.PreviousFormSelections();
        }
        /*
         * This method will first check if DVDCheckBox is 
         * checked if not then it will not add the cost of a dvd to 
         * the calcutalted total other wise it will and the 10 if checked
         */
        private void getTotals()
        {
            if (DVDCheckBox.Checked == true)
            {
                DVDLabel.Show();
                DVDTextBox.Show();
                double SubTotal = Convert.ToDouble(Program.SelectionInfo.Cost) + 10;

                double Taxs = SubTotal * 0.13;
                double Total = SubTotal * 1.13;

                SubTotalTextBox.Text = SubTotal.ToString("C2");
                SalesTaxTextBox.Text = Taxs.ToString("C2");
                TotalTextBox.Text = Total.ToString("C2");
                Program.SelectionInfo.Total = TotalTextBox.Text.TrimStart('$');



            }
            else
            {
                DVDLabel.Hide();
                DVDTextBox.Hide();
                double SubTotal = Convert.ToDouble(Program.SelectionInfo.Cost);

                double Taxs = SubTotal * 0.13;
                double Total = SubTotal * 1.13;

                SubTotalTextBox.Text = SubTotal.ToString("C2");
                SalesTaxTextBox.Text = Taxs.ToString("C2");
                TotalTextBox.Text = Total.ToString("C2");
                Program.SelectionInfo.Total = TotalTextBox.Text.TrimStart('$');

            }
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getTotals();
        }
        /*
         * Format MessageBox to show a recipet for the movie they've selected 
         */
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reciept:" + "\r\n" + "Movie Ordered: " + Program.SelectionInfo.Title + "\r\n" + 
                "Genre: " + Program.SelectionInfo.Genre + "\r\n" + "Total Cost: " + Program.SelectionInfo.Total);
        }
        /*
         * Format the About MessageBox to show my information
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By: Georgios Psarakis" + "\r\n" + "Version 1.0" + "\r\n" 
                + "Website: www.MovieBonanza.ca" + "\r\n" + "Contact Number: 1-800-647-1337");
        }
        /*
         * This will close the program the same way the cancel button does by calling the button to do it.
         */
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton.PerformClick();
        }
       
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            stream.Show();
            this.Hide();
        }
        /*
         * This will Preform the click for the Steram button by from the menu strip selection 
         */
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton.PerformClick();
        }
    }
}
