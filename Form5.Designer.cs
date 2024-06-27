namespace UniCatalog_2023
{
    partial class Form5
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
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UT Sans Medium", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 44);
            label1.Name = "label1";
            label1.Size = new Size(351, 61);
            label1.TabIndex = 3;
            label1.Text = "Welcome, Student!";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.RoyalBlue;
            button7.Location = new Point(80, 171);
            button7.Name = "button7";
            button7.Size = new Size(218, 48);
            button7.TabIndex = 16;
            button7.Text = "Cataloage";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.RoyalBlue;
            button5.Location = new Point(372, 171);
            button5.Name = "button5";
            button5.Size = new Size(218, 48);
            button5.TabIndex = 14;
            button5.Text = " Cadre didactice";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.RoyalBlue;
            button6.Location = new Point(228, 319);
            button6.Name = "button6";
            button6.Size = new Size(218, 48);
            button6.TabIndex = 19;
            button6.Text = "Iesire";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(655, 450);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label1);
            Name = "Form5";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button7;
        private Button button5;
        private Button button6;
    }
}