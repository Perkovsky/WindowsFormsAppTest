using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private readonly string CONNECTION_STRING;

        public Form1()
        {
            InitializeComponent();

            CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadData("SELECT Date, Organization, City, Country, Manager, Count, Sum FROM Shipments");
        }

        private void LoadData(string query)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            var adapter = new SqlDataAdapter(query, connection);
            var builder = new SqlCommandBuilder(adapter);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Shipments");
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private bool IsCheckedEmpty()
        {
            return !cbDate.Checked && !cbOrganization.Checked && !cbCity.Checked && !cbCountry.Checked && !cbManager.Checked;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query;

            if (IsCheckedEmpty())
            {
                query = "SELECT Date, Organization, City, Country, Manager, Count, Sum FROM Shipments";
            }
            else
            {
                var groups = new List<string>();
                if (cbDate.Checked) groups.Add("Date");
                if (cbOrganization.Checked) groups.Add("Organization");
                if (cbCity.Checked) groups.Add("City");
                if (cbCountry.Checked) groups.Add("Country");
                if (cbManager.Checked) groups.Add("Manager");

                string strGroups = string.Join(",", groups.ToArray());
                query = string.Format("SELECT {0}, SUM(Count) As Count, SUM(Sum) As Sum FROM Shipments GROUP BY {0}", strGroups);
            }

            LoadData(query);
        }
    }
}
