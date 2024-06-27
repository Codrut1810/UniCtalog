using System.Data;
using System.Data.SqlClient;

namespace UniCatalog_2023
{
    public partial class Form10 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";

        public Form10()
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

                string sql = "INSERT INTO Profesori ([Prenume],[Nume],[Titlu],[Post],[Marca],[Email])" +
                    " VALUES (@Prenume,@Nume,@Titlu,@Post,@Marca,@Email)";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@Prenume", SqlDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = textBox5.Text;
                        cmd.Parameters.Add("@Titlu", SqlDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@Post", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                        cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = textBox1.Text;
                        string email = textBox2.Text.ToLower() + textBox5.Text.ToLower() + ".unitprofmail.ro";
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

                    cnn = new SqlConnection(connetionString);
                    cnn.Open();

                    string sql = "UPDATE Profesori SET  [Nume] = @Nume, [Prenume] = @Prenume,[Titlu] = @Titlu,[Post] = @Post,[Email]=@Email WHERE [Marca] = @Marca";

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {

                            cmd.Parameters.Add("@Prenume", SqlDbType.VarChar).Value = textBox2.Text;
                            cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = textBox5.Text;
                            cmd.Parameters.Add("@Titlu", SqlDbType.VarChar).Value = textBox3.Text;
                            cmd.Parameters.Add("@Post", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                            cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = textBox1.Text;
                            string email = textBox2.Text.ToLower() + textBox5.Text.ToLower() + ".unitprofmail.ro";
                            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
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

                string sql = "DELETE FROM Profesori  WHERE [Marca] = @Marca";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {

                        cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = textBox1.Text;
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

        private void Form10_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            comboBox3.Visible = false;
            button2.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;

            if (comboBox1.SelectedIndex == 0)
            {

                label10.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                textBox2.Visible = true;
                textBox1.Visible = true;
                textBox3.Visible = true;
                comboBox3.Visible = true;
                button2.Visible = true;

                button2.Text = "Adauga";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label10.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                textBox2.Visible = true;
                textBox1.Visible = true;
                textBox3.Visible = true;
                comboBox3.Visible = true;
                button2.Visible = true;
                button2.Text = "Modifica";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label10.Visible = false;
                label4.Visible = false;
                label3.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                textBox2.Visible = false;
                textBox1.Visible = true;
                textBox3.Visible = false;
                comboBox3.Visible = false;
                button2.Visible = true;

                button2.Text = "Elimina";
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
