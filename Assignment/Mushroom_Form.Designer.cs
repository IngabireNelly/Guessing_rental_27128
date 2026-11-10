namespace Assignment
{
    partial class Mushroom_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            lblResult = new Label();
            btnRestart = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Location = new Point(30, 35);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(540, 60);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "The current question appears here.";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(165, 120);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(100, 35);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(315, 120);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 35);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(30, 175);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(540, 45);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(165, 245);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(100, 30);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Start again";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(315, 245);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Mushroom_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 320);
            Controls.Add(btnLogout);
            Controls.Add(btnRestart);
            Controls.Add(lblResult);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Name = "Mushroom_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mushroom Identifier";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Label lblResult;
        private Button btnRestart;
        private Button btnLogout;
    }
}
