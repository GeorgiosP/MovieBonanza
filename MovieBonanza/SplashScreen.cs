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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /*
         * This will check the tickers stop it when it hits 3 seconds
         *  and open the selection form
         */
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
            this.Hide();
        }
    }
}
