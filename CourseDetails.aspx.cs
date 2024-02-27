using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;

namespace FitnessApp
{
    public partial class CourseDetails : System.Web.UI.Page
    {
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                DisplayCourses();
            }
            
        }

        public void fnConnection()
        {
            try
            {
                String constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                conn = new SqlConnection(constr);
                if (conn.State != ConnectionState.Open)
                {
                    
                    Response.Write("Connected");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        public DataSet GetAllCourses()
        {
            try
            {
                fnConnection();
                String qry = "select * from Courses";
                cmd = new SqlCommand(qry, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
                return null;
            }

        }
        protected void DisplayCourses()
        {
            DataSet dsCourses = GetAllCourses();
            foreach (DataRow row in dsCourses.Tables[0].Rows)
            {
                string courseName = row["C_Name"].ToString();
                string courseDesc = row["Desc"].ToString();

                string cardHtml = $@"
        <div class='col-md-4'>
            <div class='card'>
                <div class='card-body'>
                    <h5 class='card-title'>{courseName}</h5>
                    <p class='card-text'>{courseDesc}</p>
                    <p class='card-text'><small class='text-muted'>Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>";
                // Append the HTML to the Literal control
                litCourseCards.Text += cardHtml;
            }

        }
    }
}