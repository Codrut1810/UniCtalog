using System.Diagnostics;

namespace UniCatalog_2023
{
    public partial class Form4 : Form
    {
        string excel = "C:\\Users\\PC\\OneDrive\\Desktop\\Proiect\\Note.xlsx";
        string excel1 = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE";
        public Form4()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(excel1, excel);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
