using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form6 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button2.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "Adauga Ciclu de invatamant";
                label4.Text = "";
                textBox2.Visible = false;
                button2.Text = "Adauga";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = "Adauga modificare Ciclu de invatamant";
                label4.Text = "Pozitia ciclului de modificat";
                textBox2.Visible = true;
                button2.Text = "Modifica";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = "Elimina ciclu de invatamant de pe pozitia :";
                label4.Text = "";
                textBox2.Visible = false;
                button2.Text = "Elimina";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();

            connetionString = link;


            if (comboBox1.SelectedIndex == 0)
            {

                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "INSERT INTO Ciclurideinvatamant ([Ciclu de invatamant]) VALUES (@value)";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Row inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                {
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
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "DELETE FROM Ciclurideinvatamant WHERE ID = @id";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", textBox1.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Row deleted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }


    }
}