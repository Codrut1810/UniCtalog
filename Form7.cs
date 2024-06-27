using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form7 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;

            button2.Visible = true;

            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "Adauga program de studii";
                comboBox3.Visible = true;
                label6.Visible = true;
                label4.Visible = false;
                label5.Visible = true;
                button2.Text = "Adauga";
                textBox2.Visible = false;
                comboBox2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = "Adauga modificare";
                label4.Text = "Pozitia programului-ul";
                comboBox3.Visible = true;
                label6.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                comboBox2.Visible = true;
                button2.Text = "Modifica";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = "Elimina program de studii:";
                comboBox3.Visible = false;
                label6.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBox2.Visible = false;
                comboBox2.Visible = false;
                button2.Text = "Elimina";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            comboBox3.Visible = false;
            label6.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            comboBox2.Visible = false;

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

        private void button2_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();

            connetionString = link;


            if (comboBox1.SelectedIndex == 0)
            {
                button2.Text = "Adauga";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "INSERT INTO Programedestudiu ([Program de studiu],[Ani],[Ciclu de Invatamant]) VALUES (@value,@ani,@ciclu)";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@ani", SqlDbType.VarChar).Value = comboBox2.SelectedIndex + 2;
                        cmd.Parameters.Add("@ciclu", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
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
                    button2.Text = "Modifica";
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
            else if (comboBox1.SelectedIndex == 2)
            {
                button2.Text = "Sterge";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "DELETE FROM Programedestudiu WHERE ID = @id ";

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
