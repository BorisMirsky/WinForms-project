using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace StudentForm
{
    public partial class Form2 : Form
    {
        private int selectedId;
        string connectionString = @"Data Source=C:\Users\Alexander\source\WinForms-project\WinForms1\StudentForm\Database\students_db.db;Integrated Security=True;journal mode=Off;";
        private DataRow dataRow;

        public Form2(DataRow row, int selectedId)
        {
            InitializeComponent();
            dataRow = row;
            this.selectedId = selectedId;
            nameBox1.Text = dataRow["Name"].ToString();
            emailBox1.Text = dataRow["Email"].ToString();
            phonBox1.Text = dataRow["Phone"].ToString();
            zipBox1.Text = dataRow["Zip"].ToString();
            hobbiesBox1.Text = dataRow["Hobbies"].ToString();
        }

        public SQLiteConnection sqlConnection { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void phonBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string updatedName = nameBox1.Text;
            string updatedEmail = emailBox1.Text;
            string updatedPhone = phonBox1.Text;
            string updatedZip = zipBox1.Text;
            string updatedHobbies = hobbiesBox1.Text;     
            UpdateDataInDataSource(selectedId, updatedName, updatedEmail, updatedPhone, updatedZip, updatedHobbies);
            DialogResult = DialogResult.OK;
            Close();          
        }

        private void UpdateDataInDataSource(int selectedId, string updatedName, string updatedEmail, string updatedPhone, string updatedZip, string updatedHobbies)
        {
            using (SQLiteConnection connection = new SQLiteConnection(this.connectionString))
            {
                string updateQuery = "UPDATE Students SET Name = @updatedName,Email=@updatedEmail, Phone = @updatedPhone,Zip=@updatedZip, Hobbies = @updatedHobbies where Id=@selectedId"; 

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@updatedName", updatedName);
                    command.Parameters.AddWithValue("@updatedEmail", updatedEmail);
                    command.Parameters.AddWithValue("@updatedPhone", updatedPhone);
                    command.Parameters.AddWithValue("@updatedZip", updatedZip);
                    command.Parameters.AddWithValue("@updatedHobbies", updatedHobbies);
                    command.Parameters.AddWithValue("@selectedId", selectedId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No data updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }

}        
