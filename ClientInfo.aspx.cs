using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class ClientInfo : System.Web.UI.Page
    {
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayClients();
            }
        }

        protected void DisplayClients()
        {
            // Assuming you have a method to fetch client data from the database
            DataTable dtClients = GetClients();

            // Clear the content of the Literal control before adding new rows
            litClientRows.Text = "";

            // Loop through the client data and create table rows dynamically
            int rowNumber = 1;
            foreach (DataRow row in dtClients.Rows)
            {
                string Name = row["Name"].ToString();
                string Email = row["Email"].ToString();
                string Age = row["Age"].ToString();
                string Height = row["Height"].ToString();
                string Weight = row["Weight"].ToString();
                string Gender = row["Gender"].ToString();
                string Course = row["Course"].ToString();
                string Progress = row["Progress"].ToString();

                // Construct the table row HTML
                string rowHtml = $@"
                    <tr>
                        <th scope='row'>{rowNumber}</th>
                        <td>{Name}</td>
                        <td>{Email}</td>
                        <td>{Age}</td>
                        <td>{Height} cm</td>
                        <td>{Weight} kg</td>
                        <td>{Gender}</td>
                        <td>{Course}</td>
                        <td>
                           <div class='item_bar'>
                                <div class='progress' style='width: {Progress}%;'></div>
                            </div>
                        </td>
                    <tr>";

                // Append the row HTML to the Literal control
                litClientRows.Text += rowHtml;

                rowNumber++;
            }
        }

        // Method to fetch client data from the database
        private DataTable GetClients()
        {
            // Example code to fetch client data from the database
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Userinfo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}