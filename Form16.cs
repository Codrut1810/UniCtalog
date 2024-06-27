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
    public partial class Form16 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        string link2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mike\Desktop\UniCatalog-2023\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT [Numar matricol] FROM Student";
            string connetionString = null;
            connetionString = link;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Numar matricol"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = textBox1.Text;
            char selected = select[0];
            string connetionString = link2;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();

            string selectQuery = "SELECT [Grupa] FROM Student WHERE [Numar matricol] = @value1";
            string selectedLetter3 = string.Empty;

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@value1", comboBox2.SelectedItem);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    selectedLetter3 = reader["Grupa"].ToString();
                    int position = selectedLetter3.Length - 1;
                    char[] charArray = selectedLetter3.ToCharArray();
                    charArray[position] = selected;
                    selectedLetter3 = new string(charArray);

                    reader.Close();

                    string updateQuery = "UPDATE Student SET Grupa = @grupa WHERE [Numar matricol] = @primaryKeyValue";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@grupa", selectedLetter3);
                        updateCommand.Parameters.AddWithValue("@primaryKeyValue", comboBox2.SelectedItem);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    reader.Close();
                }
            }

            connection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
