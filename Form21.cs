using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;



namespace UniCatalog_2023
{
    public partial class Form21 : Form
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";
        string excel = "C:\\Users\\PC\\OneDrive\\Desktop\\Proiect\\Note.xlsx";
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = excel;
            string name = comboBox1.Text + comboBox2.Text + comboBox3.Text;
            string worksheetName = name;

            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet(worksheetName);

            var range = worksheet.RangeUsed();
            var rows = range.RowsUsed();

            string dataText = string.Empty;

            foreach (var row in rows)
            {
                var cells = row.Cells();

                foreach (var cell in cells)
                {
                    dataText += cell.Value.ToString() + "\t";
                }

                dataText += Environment.NewLine;
            }

            MessageBox.Show(dataText, "Worksheet Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form21_Load_1(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
