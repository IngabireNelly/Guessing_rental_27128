using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class choose_form : Form
    {
        public choose_form()
        {
            InitializeComponent();
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            using var bicycleForm = new Bicycle_Form();
            Hide();
            bicycleForm.ShowDialog(this);
            if (bicycleForm.LogoutRequested)
                Close();
            else
                Show();
        }

        private void mushroomButton_Click(object sender, EventArgs e)
        {
            using var mushroomForm = new Mushroom_Form();
            Hide();
            mushroomForm.ShowDialog(this);
            if (mushroomForm.LogoutRequested)
                Close();
            else
                Show();
        }
    }
}
