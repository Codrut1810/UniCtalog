namespace UniCatalog_2023
{
    partial class Form12
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
            label6 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(378, 142);
            label6.Name = "label6";
            label6.Size = new Size(180, 23);
            label6.TabIndex = 44;
            label6.Text = "Ciclul de care apartine";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.ForeColor = Color.Black;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(378, 168);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 31);
            comboBox3.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(386, 231);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 42;
            label5.Text = "Ani de studii necesari\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(248, 142);
            label4.Name = "label4";
            label4.Size = new Size(27, 23);
            label4.TabIndex = 41;
            label4.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 232);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 40;
            label3.Text = "Program de studii";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2", "3", "4" });
            comboBox2.Location = new Point(378, 257);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 31);
            comboBox2.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(150, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(150, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 37;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(57, 334);
            button2.Name = "button2";
            button2.Size = new Size(218, 48);
            button2.TabIndex = 36;
            button2.Text = "Modifica";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UT Sans Medium", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 37);
            label1.Name = "label1";
            label1.Size = new Size(352, 61);
            label1.TabIndex = 33;
            label1.Text = "Programe de studii";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(378, 334);
            button1.Name = "button1";
            button1.Size = new Size(218, 48);
            button1.TabIndex = 32;
            button1.Text = "Inapoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(673, 450);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form12";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secretary";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox comboBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Button button1;
    }
}