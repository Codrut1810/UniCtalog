using System.Diagnostics;

namespace UniCatalog_2023
{
    public partial class Form3 : Form
    {
        string excel = "C:\\Users\\PC\\OneDrive\\Desktop\\Proiect\\Note.xlsx";
        string excel1 = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE";
        public Form3()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(excel1, excel);
        }
    }
}
