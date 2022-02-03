using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
              //TimeSpan untilDue = futureDate.Subtract(currentDate);
              //int daysTillDue = untilDue.Days;                        // the TimeSpan function can-
                                                                        //be shortened as follows
            int daysTillDue = futureDate.Subtract(currentDate).Days;
            MessageBox.Show
                (
                  "Current date:\t" + currentDate.ToShortDateString() + "\n\n" +
                  "Future date:\t" + futureDate.ToShortDateString() + "\n\n" +
                  "Dayd until due:\t" + daysTillDue,
                  "Due Days Calculation"
                );
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            DateTime currentDate = DateTime.Today;
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.DayOfYear < birthDate.DayOfYear) age--; // this lets the calculation shows you have not -
                                                                    // had your b-day in the current year

            MessageBox.Show
                (
                  "Current date:\t" + currentDate.ToShortDateString() + "\n\n" +
                  "Birth date:\t" + birthDate.ToShortDateString() + "\n\n" +
                  "Age:\t" + age,
                  "Age Calculation"
                );
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
