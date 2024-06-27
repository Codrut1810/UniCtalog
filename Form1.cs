namespace UniCatalog_2023
{
    using System.Data.SqlClient;

    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\OneDrive\Desktop\Proiect\Database1.mdf;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            cn = new SqlConnection(link);
            cn.Open()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.SelectedIndex == 0)
            {


                if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from Login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {


                if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from Logins where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {


                if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from Logint where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        Form4 f4 = new Form4();
                        f4.Show();
                        this.Hide();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {


                if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from Logints where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        Form5 f5 = new Form5();
                        f5.Show();
                        this.Hide();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
