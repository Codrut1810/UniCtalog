namespace UniCatalog_2023
{
    partial class Form16
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
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 151);
            label3.Name = "label3";
            label3.Size = new Size(204, 23);
            label3.TabIndex = 22;
            label3.Text = "Numar studenti pe grupa";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(31, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 30);
            textBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 31);
            comboBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 41);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 19;
            label2.Text = "Selecteaza Numar Matricol";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(365, 41);
            button1.Name = "button1";
            button1.Size = new Size(189, 72);
            button1.TabIndex = 17;
            button1.Text = "Imparte grupe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(365, 152);
            button2.Name = "button2";
            button2.Size = new Size(189, 72);
            button2.TabIndex = 23;
            button2.Text = "Iesire";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(626, 282);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form16";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secretary";
            Load += Form16_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}