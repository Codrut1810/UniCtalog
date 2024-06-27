namespace UniCatalog_2023
{
    partial class Form4
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
            button2 = new Button();
            button6 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UT Sans Medium", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 46);
            label1.Name = "label1";
            label1.Size = new Size(347, 61);
            label1.TabIndex = 2;
            label1.Text = "Welcome, Teacher!";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(64, 208);
            button2.Name = "button2";
            button2.Size = new Size(218, 47);
            button2.TabIndex = 11;
            button2.Text = "Studenți";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.RoyalBlue;
            button6.Location = new Point(213, 361);
            button6.Name = "button6";
            button6.Size = new Size(218, 47);
            button6.TabIndex = 18;
            button6.Text = "Iesire";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.RoyalBlue;
            button8.Location = new Point(379, 208);
            button8.Name = "button8";
            button8.Size = new Size(218, 47);
            button8.TabIndex = 17;
            button8.Text = "Cataloage";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(639, 450);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button6;
        private Button button8;
    }
}