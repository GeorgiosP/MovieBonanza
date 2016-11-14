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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            PurchaseInfoLabel.Text = "    Your movie is: " + Program.SelectionInfo.Title + "\r\n"
                + "Your credit card will be charged: " + "$"+Program.SelectionInfo.Total;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
