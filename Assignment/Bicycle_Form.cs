using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Bicycle_Form : Form
    {
        public Bicycle_Form()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox3.TabStop = false;
            btnRentalPrice.Text = "Calculate";
            btnReset.Text = "Reset";
            btnCancel.Text = "Logout";
            label2.Text = "Starting hour (0–23):";
            label3.Text = "Ending hour (1–24):";
            btnRentalPrice.Click += calculateButton_Click;
            btnReset.Click += resetButton_Click;
            btnCancel.Click += logoutButton_Click;
        }

        public bool LogoutRequested { get; private set; }

        private void calculateButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int startHour) ||
                !int.TryParse(textBox2.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int endHour))
            {
                ShowInputError("Wrong input. Enter whole numbers for both hours.");
                return;
            }

            if (startHour < 0 || startHour > 23 || endHour < 1 || endHour > 24)
            {
                ShowInputError("The starting hour must be 0–23 and the ending hour must be 1–24.");
                return;
            }

            if (startHour >= endHour)
            {
                ShowInputError("The starting hour must be earlier than the ending hour.");
                return;
            }

            int total = 0;
            for (int hour = startHour; hour < endHour; hour++)
                total += GetRateForHour(hour);

            textBox3.Text = $"{total:N0} RWF";
        }

        private void resetButton_Click(object? sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void logoutButton_Click(object? sender, EventArgs e)
        {
            LogoutRequested = true;
            Close();
        }

        private static int GetRateForHour(int hour)
        {
            if (hour < 7 || hour >= 21)
                return 500;
            if (hour < 14 || hour >= 19)
                return 1000;
            return 1500;
        }

        private void ShowInputError(string message)
        {
            MessageBox.Show(this, message, "Invalid rental time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
