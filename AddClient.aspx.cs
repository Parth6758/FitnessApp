using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class AddClient : System.Web.UI.Page
    {
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)

        {
            try
            {
                fnconnection();
                string qry = "INSERT INTO Userinfo (Name, Email, Age, City, Height, Weight, Gender, Course, Progress) VALUES (@Name, @Email, @Age, @City, @Height, @Weight, @Gender, @Course, @Progress)";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Name", Name.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Age", Age.Text);
                cmd.Parameters.AddWithValue("@City", City.SelectedValue);
                cmd.Parameters.AddWithValue("@Height", Height.Text);
                cmd.Parameters.AddWithValue("@Weight", Weight.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender.SelectedValue);
                cmd.Parameters.AddWithValue("@Course", Course.SelectedValue);
                cmd.Parameters.AddWithValue("@Progress", Convert.ToInt32(progress.Text));

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    /*Response.Write("User Inserted");*/
                }
                else
                {
                    Response.Write("User Not Inserted");
                }
            }
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

            public void fnconnection()
        {
            try
            {
                String constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                conn = new SqlConnection(constr);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    Response.Write("Connected");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}