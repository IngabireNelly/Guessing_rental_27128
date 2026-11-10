namespace Assignment
{
    partial class choose_form
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 90);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose the Task to Perform";
            // 
            // button1
            // 
            button1.Location = new Point(197, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Bicycle Rental";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bicycleButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Mushroom";
            button2.UseVisualStyleBackColor = true;
            button2.Click += mushroomButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 170);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 3;
            label2.Text = "Bicycle Rental";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 238);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 4;
            label3.Text = "Mushroom";
            // 
            // choose_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 350);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "choose_form";
            Text = "choose_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
