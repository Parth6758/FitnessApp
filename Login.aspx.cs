using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace FitnessApp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fnConnection();
            }
        }
        public void fnConnection()
        {

            try
            {
                String constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                conn = new SqlConnection(constr);
                if (conn.State != ConnectionState.Open)

                    conn.Open();

                /*Response.Write("Database Connected Succesfully");*/


            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtpass.Text;

            DataTable dtClients = GetClients();

            // Loop through the client data and create table rows dynamically
          
            foreach (DataRow row in dtClients.Rows)
            {
                string Email = row["Email"].ToString();
                string Pass = row["Password"].ToString();
                // Check username and password (this is a basic example, not secure)
                if (email == Email && password == Pass)
                {
                    // Redirect to the home page or another page
                    Response.Redirect("~/Dashboard.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid username or password.";
                }
            }


        }

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