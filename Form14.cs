using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form14 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
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
            button2.Text = "Modifica";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "UPDATE Student SET  [Nume] = @Nume, [Prenume] = @Prenume,[Media de Inscriere] = @Media,[Specializarea] = @Specializarea, [Initiala tata] = @Initiala,[Anu inscrierii]=@Anul,[CNP] = @CNP WHERE [Numar matricol] = @Numar";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {

                    cmd.Parameters.Add("@Prenume", SqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@Media", SqlDbType.VarChar).Value = textBox1.Text;
                    cmd.Parameters.Add("@Specializarea", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                    cmd.Parameters.Add("@Initiala", SqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@Numar", SqlDbType.VarChar).Value = textBox4.Text;
                    cmd.Parameters.Add("@Anul", SqlDbType.VarChar).Value = textBox6.Text;
                    cmd.Parameters.Add("@CNP", SqlDbType.VarChar).Value = textBox7.Text;
                    cmd.ExecuteNonQuery();

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Row changed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
