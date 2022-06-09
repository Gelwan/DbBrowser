using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Dapper;

namespace DbBrowser
{
    public partial class MainForm : Form
    {
        private List<Person> result = new List<Person>();
        private Person oldSelectedPerson = new Person();
        public MainForm()
        {
            InitializeComponent();
            //DbAccess.GetDbList();
        }
        private void QueryResultListRefresh()
        {
            QueryResultList.DataSource = result;
            QueryResultList.DisplayMember = "FullInfo";
        }
        public void Search()
        {
            using (IDbConnection conn = DbAccess.GetDbCon())
            {
                string fName = firstNameTextBox.Text.Trim();
                string lname = LastNameTextBox.Text.Trim();
                string query = $"select id,first_name as firstName,second_name as lastName,email,phone_number as phone from people where first_name like '{fName}%' and second_name like '{lname}%'";
                if (QueryBox.Text.Trim().Length != 0) query = QueryBox.Text.Trim();
                try
                {
                    result = conn.Query<Person>(query).ToList();
                }
                catch
                {
                    //MessageBox mbox = new Form().;
                }
            }
            QueryResultListRefresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertBox form = new InsertBox();
            form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QueryResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selected = (Person)QueryResultList.SelectedItem;
            UpdateIdBox.Value = selected.id;
            UpdateFirstNameBox.Text = selected.firstName;
            UpdateLastNameBox.Text = selected.lastName;
            UpdateEmailBox.Text = selected.email;
            UpdatePhoneBox.Text = selected.phone;
            oldSelectedPerson = selected;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var id = UpdateIdBox.Value;
            var firsName = UpdateFirstNameBox.Text.Trim();
            var lastName = UpdateLastNameBox.Text.Trim();
            var email = UpdateEmailBox.Text.Trim();
            var phone = UpdatePhoneBox.Text.Trim();
            if (email == oldSelectedPerson.email && firsName == oldSelectedPerson.firstName && lastName == oldSelectedPerson.lastName && phone == oldSelectedPerson.phone) return;
            string query = $"UPDATE people SET first_name='{firsName}', second_name='{lastName}', email='{email}', phone_number='{phone}' WHERE id={id}";
            using(var conn = new System.Data.SqlClient.SqlConnection(DbAccess.GetConnsectionString()))
            {
                try
                {
                    conn.Execute(query);
                    Search();
                }
                catch
                {
                    MessageBox.Show("Update execute error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Person selected = (Person)QueryResultList.SelectedItem;
            string query = $"DELETE FROM people WHERE id={selected.id}";
            using (var conn = new System.Data.SqlClient.SqlConnection(DbAccess.GetConnsectionString()))
            {
                try
                {
                    conn.Execute(query);
                    Search();
                }
                catch
                {
                    MessageBox.Show("Delete execute error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
