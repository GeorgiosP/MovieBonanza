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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reciept:" + "\r\n" + "Movie Ordered: " + Program.SelectionInfo.Title + "\r\n" + 
                "Genre: " + Program.SelectionInfo.Genre + "\r\n" + "Total Cost: " + Program.SelectionInfo.Total);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By: Georgios Psarakis" + "\r\n" + "Version 1.0" + "\r\n" 
                + "Website: www.MovieBonanza.ca" + "\r\n" + "Contact Number: 1-800-647-1337");
        }
    }
}
