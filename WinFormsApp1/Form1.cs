using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Fare
        private const double BaseRate = 100.0;
        private const double PerKmRate = 12.0;
        private readonly double StudentDiscountRate = 0.20;
        private readonly double PremiumMultiplier = 1.5;

        // Distances
        private readonly Dictionary<(string, string), double> _distances = new()
        {
            { ("Marquee", "AUF"), 5.0 },
            { ("Marquee", "SMC"), 8.0 },
            { ("AUF", "SMC"), 6.0 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wire events that Designer didn't attach
            bookbtn.Click += bookbtn_Click;

            stdntBtn.CheckedChanged += PassengerTypeChanged;
            rglrBtn.CheckedChanged += PassengerTypeChanged;
            nrmlBtn.CheckedChanged += RideClassChanged;
            prmmBtn.CheckedChanged += RideClassChanged;

            // Wire combo box selection changes so fare summary updates every time the user changes selection
            pickUpBox.SelectedIndexChanged += LocationSelectionChanged;
            dropOffBox.SelectedIndexChanged += LocationSelectionChanged;

            // Ensure controls have sensible defaults (set after wiring so the SelectedIndexChanged handlers run)
            if (pickUpBox.Items.Count > 0) pickUpBox.SelectedIndex = 0;
            if (dropOffBox.Items.Count > 1) dropOffBox.SelectedIndex = 1;
            // Default passenger type and ride class
            rglrBtn.Checked = true;
            nrmlBtn.Checked = true;

            // Initial fare summary
            UpdateFareSummary();
        }

        private void LocationSelectionChanged(object? sender, EventArgs e)
        {
            UpdateFareSummary();
        }

  

        // Passenger Type
        private void PassengerTypeChanged(object? sender, EventArgs e)
        {
            if (sender == stdntBtn && stdntBtn.Checked)
                rglrBtn.Checked = false;
            else if (sender == rglrBtn && rglrBtn.Checked)
                stdntBtn.Checked = false;

            UpdateFareSummary();
        }

        // Ride Class
        private void RideClassChanged(object? sender, EventArgs e)
        {
            if (sender == nrmlBtn && nrmlBtn.Checked)
                prmmBtn.Checked = false;
            else if (sender == prmmBtn && prmmBtn.Checked)
                nrmlBtn.Checked = false;

            UpdateFareSummary();
        }

        private void bookbtn_Click(object? sender, EventArgs e)
        {
            if (pickUpBox.SelectedItem == null || dropOffBox.SelectedItem == null)
            {
                MessageBox.Show("Please choose both pick-up and drop-off locations.", "Missing selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pick = pickUpBox.SelectedItem.ToString() ?? string.Empty;
            var drop = dropOffBox.SelectedItem.ToString() ?? string.Empty;

            if (pick == drop)
            {
                MessageBox.Show("Pick-up and drop-off cannot be the same.", "Invalid route", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (distanceFee, discount, total) = CalculateFare(pick, drop);

            var msg =
                $"Route: {pick} → {drop}\n" +
                $"Distance fee: {distanceFee:0.##}₱\n" +
                $"Discount: {discount:0.##}₱\n" +
                $"Total fare: {total:0.##}₱\n\n" +
                "Confirm booking?";

            var res = MessageBox.Show(msg, "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show($"Booking confirmed. Total fare: {total:0.##}₱", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Updates the labels in the fare summary panel
        private void UpdateFareSummary()
        {
            if (pickUpBox.SelectedItem == null || dropOffBox.SelectedItem == null)
            {
                distFeeTxt.Text = "Distance Fee:";
                dscntTxt.Text = "Passenger Discount:";
                totalTxt.Text = "0";
                return;
            }

            var pick = pickUpBox.SelectedItem.ToString() ?? string.Empty;
            var drop = dropOffBox.SelectedItem.ToString() ?? string.Empty;

            if (pick == drop)
            {
                distFeeTxt.Text = "Distance Fee: 0₱";
                dscntTxt.Text = "Passenger Discount: 0₱";
                totalTxt.Text = $"{BaseRate:0.##}₱";
                return;
            }

            var (distanceFee, discount, total) = CalculateFare(pick, drop);

            distFeeTxt.Text = $"Distance Fee: {distanceFee:0.##}₱";
            dscntTxt.Text = $"Passenger Discount: {discount:0.##}₱";
            totalTxt.Text = $"{total:0.##}₱";
        }

        // Returns (distanceFee, discountAmount, totalFare)
        private (double distanceFee, double discount, double total) CalculateFare(string pick, string drop)
        {
            var distance = GetDistanceBetween(pick, drop);
            var distanceFee = PerKmRate * distance;
            var subtotal = BaseRate + distanceFee;

            var isStudent = stdntBtn.Checked;
            var discount = isStudent ? subtotal * StudentDiscountRate : 0.0;
            var afterDiscount = subtotal - discount;

            var classMultiplier = prmmBtn.Checked ? PremiumMultiplier : 1.0;
            var total = Math.Round(afterDiscount * classMultiplier, 2);

            return (Math.Round(distanceFee, 2), Math.Round(discount, 2), total);
        }

        private double GetDistanceBetween(string a, string b)
        {
            if (a == b) return 0.0;

            if (_distances.TryGetValue((a, b), out var d)) return d;
            if (_distances.TryGetValue((b, a), out d)) return d;

            // If pair not explicitly defined, provide a conservative default (e.g., 10 km)
            return 10.0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // optional: show information about pick-up label
            MessageBox.Show("Choose your pick-up location from the dropdown.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
