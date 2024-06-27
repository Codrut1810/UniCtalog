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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniCatalog_2023
{
    public partial class Form18 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT [Nume],[Prenume] FROM Student";
            string connetionString = null;
            connetionString = link;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nume"].ToString() + ' ' + reader["Prenume"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT [Email] FROM Student WHERE [Nume]=@nume AND [Prenume]=@prenume";
            string connetionString = null;
            connetionString = link;
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                char separator = ' ';
                string[] parts = comboBox1.Text.Split(separator);
                command.Parameters.AddWithValue("@nume", parts[0]);
                command.Parameters.AddWithValue("@prenume", parts[1]);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    {
                        label1.Text = reader["Email"].ToString();
                    }
                }
            }
        }
    }
}
