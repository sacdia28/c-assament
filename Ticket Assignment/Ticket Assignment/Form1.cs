using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ticket_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdobusiness_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string passengerName = txtname.Text.Trim();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            // Variables
            int age;
            int tickets;
            double baggage;

            // TryParse Age
            if (!int.TryParse(txtage.Text, out age))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                return;
            }

            // TryParse Number of Tickets
            if (!int.TryParse(txtticket.Text, out tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            // TryParse Baggage Weight
            if (!double.TryParse(txtbaggage.Text, out baggage))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            // Age validation
            if (age < 1 || age > 100)
            {
                MessageBox.Show("enter a valid age");
            }

            // Ticket validation
            else if (tickets < 1 || tickets > 5)
            {
               
           MessageBox.Show("Number of tickets must be between 1 and 5.");
            }

            // Baggage validation
            else if (baggage < 0 || baggage > 50)
            {
                 MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
            }

            // First Class validation
            else if (age < 12 && rdofirst.Checked)
            {
                 MessageBox.Show("Passengers below 12 years cannot book First Class.");
            }

            // Ticket prices
            double ticketPrice = 0;

            if (rdofirst.Checked)
            {
                ticketPrice = 300;
            }
            else if (rdonormal.Checked)
            {
                ticketPrice = 100;
            }
            else if (rdobusiness.Checked)
            {
                ticketPrice = 200;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Basic Ticket Cost
            double basicCost = ticketPrice * tickets;

            // Ticket discount
            double ticketDiscount = 0;

            if (tickets >= 3 && tickets <= 4)
            {
                ticketDiscount = basicCost * 0.05;
            }
            else if (tickets == 5)
            {
                ticketDiscount = basicCost * 0.10;
            }

            // Age discount
            double ageDiscount = 0;

            if (age < 12)
            {
                ageDiscount = basicCost * 0.20;
            }
            else if (age >= 60)
            {
                ageDiscount = basicCost * 0.10;
            }

            // Total discount
            double totalDiscount = ticketDiscount + ageDiscount;

            // Cost after discount
            double discountedCost = basicCost - totalDiscount;

            // Travel insurance
            double insuranceCost = 0;

            if (chadd.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // Final total
            double totalCost = discountedCost + insuranceCost;

            // Baggage
            string baggageMessage;

            if (baggage <= 20)
            {
                baggageMessage = "Free";
            }
            else
            {
                baggageMessage = "Within allowed limit";
            }

            // Display result
            string travelClass = "";

            if (rdofirst.Checked)
            {
                travelClass = "First Class";
            }
            else if (rdonormal.Checked)
            {
                travelClass = "Normal Class";
            }
            else if (rdobusiness.Checked)
            {
                travelClass = "Business Class";
            }

            lstbox.Text =
                "AIRLINE TICKET BOOKING DETAILS\r\n" +
                "--------------------------------------\r\n" +
                "Booking Status: APPROVED\r\n" +
                "Passenger Name: " + passengerName + "\r\n" +
                "Passenger Age: " + age + "\r\n" +
                "Number of Tickets: " + tickets + "\r\n" +
                "Baggage Weight: " + baggage + " kg\r\n" +
                "Travel Class: " + travelClass + "\r\n" +
                "Ticket Price: $" + ticketPrice.ToString("0.00") + "\r\n" +
                "Basic Ticket Cost: $" + basicCost.ToString("0.00") + "\r\n" +
                "Ticket Discount: $" + ticketDiscount.ToString("0.00") + "\r\n" +
                "Age Discount: $" + ageDiscount.ToString("0.00") + "\r\n" +
                "Total Discount: $" + totalDiscount.ToString("0.00") + "\r\n" +
                "Insurance: $" + insuranceCost.ToString("0.00") + "\r\n" +
                "Baggage: " + baggageMessage + "\r\n" +
                "--------------------------------------\r\n" +
                "TOTAL COST: $" + totalCost.ToString("0.00");
            //add list bos
            lstbox.Items.Clear();

            lstbox.Items.Add("Booking Status: APPROVED");
            lstbox.Items.Add("Passenger Name: " + passengerName);
            lstbox.Items.Add("Passenger Age: " + age);
            lstbox.Items.Add("Number of Tickets: " + tickets);
            lstbox.Items.Add("Baggage Weight: " + baggage + " kg");
            lstbox.Items.Add("Travel Class: " + travelClass);
            lstbox.Items.Add("Ticket Price: $" + ticketPrice.ToString("0.00"));
            lstbox.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("0.00"));
            lstbox.Items.Add("Total Discount: $" + totalDiscount.ToString("0.00"));
            lstbox.Items.Add("Insurance: $" + insuranceCost.ToString("0.00"));
            lstbox.Items.Add("TOTAL COST: $" + totalCost.ToString("0.00"));
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtticket.Text = String.Empty;
            txtbaggage.Text = string.Empty;
               
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

