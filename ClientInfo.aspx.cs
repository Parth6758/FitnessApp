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
            DataTable dtClients = GetClients();

            litClientRows.Text = "";

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
                        <td style='margin-top=20px'>
                            <svg xmlns='http://www.w3.org/2000/svg' width='14' height='14' fill='currentColor' class='bi bi-three-dots-vertical' viewBox='0 0 16 16'>
                            <path d='M9.5 13a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0m0-5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0m0-5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0'/>
                            </svg>
                        </td>
                    <tr>";

                litClientRows.Text += rowHtml;

                rowNumber++;
            }
        }

        protected void btnAddClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddClient.aspx");
        }
        
        protected void btnGoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dashboard.aspx");
        }


        private DataTable GetClients()
        {
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