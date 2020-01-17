using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        DateTime currentDateTime = DateTime.Today;
        decimal pricePerNight = 0m;
        decimal totalPrice = 0m;
       
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            return
            IsDateTime(txtArrivalDate, "Arrival Date") &&
            IsWithinRange(txtArrivalDate, "Arrival Date", currentDateTime, currentDateTime.AddYears(5));


        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime number;
            if (DateTime.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a date.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            DateTime enteredDate = DateTime.Parse(textBox.Text);
            if (enteredDate < min || enteredDate > max)
            {
                MessageBox.Show(name + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {

                DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text);
                DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);

                TimeSpan timeSpan = departureDate.Subtract(arrivalDate);
                int numberOfDays = timeSpan.Days;


                DayOfWeek dayOfWeek = arrivalDate.DayOfWeek;
                int numberOfDaysCounter = numberOfDays;

                while (numberOfDaysCounter > 0)
                {
                    if (dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday)
                    {
                        pricePerNight = 150m;
                    }
                    else
                    {
                        pricePerNight = 120m;
                    }
                    totalPrice += pricePerNight;
                    arrivalDate = arrivalDate.AddDays(1);
                    dayOfWeek = arrivalDate.DayOfWeek;
                    numberOfDaysCounter--;

                }

                decimal average = totalPrice / numberOfDays;
                txtAvgPrice.Text = average.ToString("c");
                txtTotalPrice.Text = totalPrice.ToString("c");
                txtNights.Text = numberOfDays.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string currentDate = currentDateTime.ToShortDateString();
            txtArrivalDate.Text = currentDate;

            DateTime departureDate = DateTime.Today;
            DateTime leaveDate = departureDate.AddDays(3);
            txtDepartureDate.Text = leaveDate.ToShortDateString(); 

            
        }
    }
}