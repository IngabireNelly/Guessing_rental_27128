using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Mushroom_Form : Form
    {
        private int questionIndex;
        private readonly bool[] answers = new bool[3];

        public bool LogoutRequested { get; private set; }

        public Mushroom_Form()
        {
            InitializeComponent();
            ShowQuestion();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer(false);
        }

        private void Answer(bool yes)
        {
            answers[questionIndex] = yes;
            questionIndex++;

            if (questionIndex == answers.Length)
                ShowResult(IdentifyMushroom());
            else
                ShowQuestion();
        }

        private void ShowQuestion()
        {
            lblResult.Text = string.Empty;
            btnYes.Enabled = true;
            btnNo.Enabled = true;
            lblQuestion.Text = questionIndex switch
            {
                0 => "Does the mushroom have gills under its cap?",
                1 when answers[0] => "Does it usually grow in a cluster?",
                1 => "Does the cap have a honeycomb-like surface with pits?",
                2 when answers[0] && answers[1] => "Does it grow on wood?",
                2 when answers[0] => "Is its cap usually dark brown?",
                2 when answers[1] => "Is the cap usually tan or brown?",
                2 => "Is the cap bright red with white spots?",
                _ => "Identify the mushroom"
            };
        }

        private string IdentifyMushroom()
        {
            if (answers[0])
            {
                if (answers[1])
                    return answers[2] ? "Oyster mushroom" : "Button mushroom";

                return answers[2] ? "Shiitake" : "Button mushroom";
            }

            if (answers[1])
                return answers[2] ? "Morel" : "Porcini";

            return answers[2] ? "Fly agaric" : "Porcini";
        }

        private void ShowResult(string mushroomName)
        {
            lblResult.Text = mushroomName;
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            MessageBox.Show(this, $"The mushroom is: {mushroomName}", "Mushroom result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            questionIndex = 0;
            Array.Clear(answers);
            ShowQuestion();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested = true;
            Close();
        }
    }
}
