using OfficeOpenXml;
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
    public partial class Form20 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        string excel = "C:\\Users\\PC\\OneDrive\\Desktop\\Proiect\\Note.xlsx";

        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(reader["Program de studiu"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int i = 1;
            int j = 1;

            string selectQuery = "SELECT [Nume] FROM Discipline WHERE [An de studiu]=@an AND [Semestru]=@semestru AND [Program de studii]=@studiu";
            string connetionString = link;
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                int an = comboBox2.SelectedIndex + 1;
                command.Parameters.AddWithValue("@studiu", comboBox1.Text);
                command.Parameters.AddWithValue("@an", an);
                command.Parameters.AddWithValue("@semestru", comboBox3.SelectedIndex + 1);
                SqlDataReader reader = command.ExecuteReader();

                string selectQuery1 = "SELECT [Nume],[Prenume] FROM Student WHERE [Anu inscrierii]=@an1 AND [Specializarea]=@studiu";
                string connetionString1 = link;
                using (SqlConnection connection1 = new SqlConnection(connetionString1))
                {
                    connection1.Open();
                    SqlCommand command1 = new SqlCommand(selectQuery1, connection1);
                    command1.Parameters.AddWithValue("@an1", 2023 - an);
                    command1.Parameters.AddWithValue("@studiu", comboBox1.Text);
                    SqlDataReader reader1 = command1.ExecuteReader();


                    FileInfo excelFile = new FileInfo(excel);
                    using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
                    {

                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == comboBox1.Text + comboBox2.Text + comboBox3.Text);


                        if (worksheet == null)
                        {
                            worksheet = excelPackage.Workbook.Worksheets.Add(comboBox1.Text + comboBox2.Text + comboBox3.Text);
                        }

                        while (reader.Read())
                        {
                            worksheet.Cells[1, i + 1].Value = reader["Nume"];
                            i++;
                        }
                        worksheet.Cells[1, i + 1].Value = "Medie";
                        while (reader1.Read())
                        {
                            string nume = reader1["Nume"].ToString() + ' ' + reader1["Prenume"].ToString();
                            worksheet.Cells[j + 1, 1].Value = nume;
                            j++;
                        }
                        worksheet.Cells[j + 1, 1].Value = "Medie Finala";
                        worksheet.Cells.AutoFitColumns();

                        excelPackage.Save();
                    }

                    reader1.Close();
                }

                reader.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo excelFile = new FileInfo(excel);
            using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
            {

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[comboBox1.Text + comboBox2.Text + comboBox3.Text];


                excelPackage.Workbook.Worksheets.Delete(worksheet);


                excelPackage.Save();
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

