using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace DbBrowser
{
    public partial class InsertBox : Form
    {
        public InsertBox()
        {
            InitializeComponent();
            EmailGenChbox.CheckState = CheckState.Checked;
        }

        private void EmailGenChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(EmailTextBox.Enabled) EmailTextBox.Enabled = false;
            else EmailTextBox.Enabled = true;
            GenerateEmail();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateEmail();
        }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateEmail();
        }
        private void GenerateEmail()
        {
            if (EmailGenChbox.CheckState == CheckState.Unchecked) return;
            if (FirstNameTextBox.Text.Trim() == "" && LastNameTextBox.Text.Trim() == "") return;
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            if(firstName.Length >= 3) firstName = firstName.Substring(0, 3);
            if(lastName.Length >= 3) lastName = lastName.Substring(0, 3);
            EmailTextBox.Text = $"{firstName.ToLower()}{lastName.ToLower()}@qwe.pm";
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string phoneNum = PhoneNumberTextBox.Text.Trim();
            if (firstName.Length > 30 || lastName.Length > 30 || email.Length > 30) return;
            string query = $"insert into people(first_name,second_name,email,phone_number) values('{firstName}','{lastName}','{email}','{phoneNum}')";
            using (var conn = new System.Data.SqlClient.SqlConnection(DbAccess.GetConnsectionString()))
            {
                try
                {
                    conn.Execute(query);
                }
                catch
                {
                    MessageBox.Show("Insert execute error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
