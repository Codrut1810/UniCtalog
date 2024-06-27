using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form12 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            string selectQuery = "SELECT [Ciclu de invatamant] FROM Ciclurideinvatamant";
            string connetionString = null;
            connetionString = link;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                comboBox3.Items.Add(reader["Ciclu de invatamant"].ToString());
            }
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

            string sql = "UPDATE Programedestudiu SET [Program de studiu] = @value, [Ani] = @ani, [Ciclu de Invatamant] = @ciclu WHERE ID = @id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@value", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ani", comboBox2.SelectedIndex + 2);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ciclu", comboBox3.SelectedItem);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Row changed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
