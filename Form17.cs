using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCatalog_2023
{
    public partial class Form17 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        string link2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";

        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
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
                comboBox2.Items.Add(reader["Program de studiu"].ToString());

            }
            reader.Close();
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = link2;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();

            string selectQuery = "SELECT  [Ciclu de Invatamant] FROM Programedestudiu WHERE [Program de studiu] = @value1";
            string selectedLetter3 = string.Empty;

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@value1", comboBox2.SelectedItem);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    selectedLetter3 = reader["Ciclu de Invatamant"].ToString();

                }
                reader.Close();
            }
            char letter = selectedLetter3[0];
            char upperLetter = char.ToUpper(letter);

            string selectedItem1 = comboBox1.SelectedItem.ToString();
            char lastLetter1 = selectedItem1[selectedItem1.Length - 1];
            string selectedItem2 = comboBox2.SelectedItem.ToString();
            char lastLetter2 = selectedItem2[selectedItem2.Length - 1];

            string grupa = upperLetter + "F" + char.ToUpper(lastLetter2).ToString() + lastLetter1.ToString();

            string selectQuery1 = "SELECT [Numar matricol] FROM Student WHERE [Anu inscrierii] = @value1 AND Specializarea = @value2 ";

            using (SqlCommand command = new SqlCommand(selectQuery1, connection))
            {
                command.Parameters.AddWithValue("@value1", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@value2", comboBox2.SelectedItem.ToString());

                SqlDataReader reader = command.ExecuteReader();

                int n = int.Parse(textBox1.Text);
                int k = 0;
                int g = 1;

                while (reader.Read())
                {

                    if (k == n)
                    {
                        g++;
                        k = 0;

                    }
                    k++;
                    string grupaf = grupa + g.ToString();

                    string updateQuery = "UPDATE Student SET Grupa = @grupa WHERE [Numar matricol] = @primaryKeyValue";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@grupa", grupaf);
                        updateCommand.Parameters.AddWithValue("@primaryKeyValue", reader["Numar matricol"]);

                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }


}

