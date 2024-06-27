namespace UniCatalog_2023
{
    partial class Form17
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
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(154, 174);
            label3.Name = "label3";
            label3.Size = new Size(204, 23);
            label3.TabIndex = 15;
            label3.Text = "Numar studenti pe grupa";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(154, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 30);
            textBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(313, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 31);
            comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(313, 65);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 12;
            label2.Text = "Selecteaza specializare";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 11;
            label1.Text = "Selecteaza anul";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(43, 295);
            button1.Name = "button1";
            button1.Size = new Size(202, 75);
            button1.TabIndex = 9;
            button1.Text = "Imparte grupe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2023", "2022", "2021", "2020" });
            comboBox1.Location = new Point(43, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(279, 295);
            button2.Name = "button2";
            button2.Size = new Size(204, 75);
            button2.TabIndex = 16;
            button2.Text = "Iesire";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(524, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form17";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Form17_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}