namespace UniCatalog_2023
{
    partial class Form11
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
            button2 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(98, 290);
            button2.Name = "button2";
            button2.Size = new Size(218, 48);
            button2.TabIndex = 23;
            button2.Text = "Modificare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.CornflowerBlue;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(452, 191);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 22;
            label4.Text = "Id-ul de modificat";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(447, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 30);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(137, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 30);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UT Sans Medium", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 76);
            label1.Name = "label1";
            label1.Size = new Size(365, 61);
            label1.TabIndex = 16;
            label1.Text = "Ciclu de invatamant";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(412, 290);
            button1.Name = "button1";
            button1.Size = new Size(218, 48);
            button1.TabIndex = 15;
            button1.Text = "Inapoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 191);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 24;
            label2.Text = "Ciclul de invatamant";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(718, 433);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form11";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secretary";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}