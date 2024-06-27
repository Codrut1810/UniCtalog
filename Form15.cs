using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form15 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();

            connetionString = link;
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "UPDATE Profesori SET  [Nume] = @Nume, [Prenume] = @Prenume,[Titlu] = @Titlu,[Post] = @Post WHERE [Marca] = @Marca";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {

                    cmd.Parameters.Add("@Prenume", SqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@Titlu", SqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@Post", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                    cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = textBox1.Text;
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
