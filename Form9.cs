using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form9 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
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
            label10.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label9.Visible = false;
            textBox7.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            comboBox3.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            label8.Visible = false;
            textBox6.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
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

                string sql = "INSERT INTO Student ([Prenume],[Nume],[Media de Inscriere],[Specializarea],[Initiala tata],[Numar matricol],[Anu inscrierii],[CNP],[Email])" +
                    " VALUES (@Prenume,@Nume,@Media,@Specializarea,@Initiala,@Numar,@Anul,@CNP,@Email)";

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
                        string email = textBox2.Text.ToLower() + textBox5.Text.ToLower() + ".unitmail.ro";
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
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

                    string sql = "UPDATE Student SET  [Nume] = @Nume, [Prenume] = @Prenume,[Media de Inscriere] = @Media,[Specializarea] = @Specializarea, [Initiala tata] = @Initiala,[Anu inscrierii]=@Anul,[CNP] = @CNP,[Email]=@Email WHERE [Numar matricol] = @Numar";

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
                            string email = textBox2.Text.ToLower() + textBox5.Text.ToLower() + ".unitmail.ro";
                            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
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
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "DELETE FROM Student WHERE [Numar matricol] = @Numar ";

                try
                {
                    button2.Text = "Sterge";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {

                        cmd.Parameters.Add("@Numar", SqlDbType.VarChar).Value = textBox4.Text;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;

            if (comboBox1.SelectedIndex == 0)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox5.Visible = true;
                label9.Visible = true;
                textBox7.Visible = true;
                label6.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label7.Visible = true;
                textBox4.Visible = true;
                label8.Visible = true;
                textBox6.Visible = true;
                button2.Visible = true;
                textBox1.Visible = true;

                button2.Text = "Adauga";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                textBox5.Visible = true;
                label9.Visible = true;
                textBox6.Visible = true;
                label6.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label7.Visible = true;
                textBox4.Visible = true;
                textBox1.Visible = true;
                label8.Visible = true;
                textBox7.Visible = true;
                button2.Visible = true;

                button2.Text = "Modifica";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label10.Visible = false;
                textBox5.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                label4.Visible = false;
                textBox5.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                label6.Visible = false;
                comboBox3.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                label7.Visible = true;
                textBox4.Visible = true;
                label8.Visible = false;
                textBox6.Visible = false;
                button2.Visible = true;
                button2.Text = "Elimina";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
