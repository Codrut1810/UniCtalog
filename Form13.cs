using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form13 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT [Program de studiu] FROM Programedestudiu";
            string connetionString = null;
            connetionString = link;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                comboBox3.Items.Add(reader["Program de studiu"].ToString());
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

            string sql = "UPDATE Discipline SET  [Nume] = @Nume, [Acronim] = @Acronim,[Program de studii] = @Program,[Numar de credite] = @Numar, [An de studiu] = @An, [Semestru] = @Semestru WHERE [Cod discipline] = @Cod";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {

                    cmd.Parameters.Add("@Cod", SqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@Acronim", SqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@Numar", SqlDbType.VarChar).Value = textBox4.Text;
                    cmd.Parameters.Add("@Program", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                    cmd.Parameters.Add("@An", SqlDbType.VarChar).Value = comboBox2.SelectedItem;
                    cmd.Parameters.Add("@Semestru", SqlDbType.VarChar).Value = comboBox4.SelectedItem;

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
