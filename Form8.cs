using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form8 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form8()
        {
            InitializeComponent();
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

                string sql = "INSERT INTO Discipline ([Cod discipline],[Nume],[Acronim],[Numar de credite],[Program de studii],[An de studiu],[Semestru])" +
                    " VALUES (@Cod,@Nume,@Acronim,@Numar,@Program,@An,@Semestru)";

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
            else if (comboBox1.SelectedIndex == 2)
            {

                cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "DELETE FROM Discipline WHERE [Cod discipline] = @Cod ";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {

                        cmd.Parameters.Add("@Cod", SqlDbType.VarChar).Value = textBox2.Text;
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
                textBox2.Visible = true;
                textBox5.Visible = true;
                label9.Visible = true;
                comboBox4.Visible = true;
                label6.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label7.Visible = true;
                textBox4.Visible = true;
                label8.Visible = true;
                comboBox2.Visible = true;
                button2.Visible = true;


                button2.Text = "Adauga";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                textBox5.Visible = true;
                label9.Visible = true;
                comboBox4.Visible = true;
                label6.Visible = true;
                comboBox3.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label7.Visible = true;
                textBox4.Visible = true;
                label8.Visible = true;
                comboBox2.Visible = true;
                button2.Visible = true;

                button2.Text = "Modifica";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label10.Visible = false;
                textBox5.Visible = false;
                textBox2.Visible = true;
                label4.Visible = true;
                textBox5.Visible = false;
                label9.Visible = false;
                comboBox4.Visible = false;
                label6.Visible = false;
                comboBox3.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                label7.Visible = false;
                textBox4.Visible = false;
                label8.Visible = false;
                comboBox2.Visible = false;
                button2.Visible = true;
                button2.Text = "Elimina";
            }
        }


        private void Form8_Load_1(object sender, EventArgs e)
        {
            label10.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label9.Visible = false;
            comboBox4.Visible = false;
            label6.Visible = false;
            comboBox3.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            label8.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;
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
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}


