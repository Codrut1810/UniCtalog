namespace UniCatalog_2023
{

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
        }
    }
}
