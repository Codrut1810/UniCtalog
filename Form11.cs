using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form11 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();

            connetionString = link;
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "UPDATE Ciclurideinvatamant SET [Ciclu de invatamant] = @value WHERE ID = @id";

            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@value", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Row changed !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
