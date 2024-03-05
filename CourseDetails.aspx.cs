using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    //   Response.Write("Connected");
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

            // Clear the content of the Literal control before adding new cards
            litCourseCards.Text = "";

            // Open a new row before displaying the cards
            litCourseCards.Text += "<div class='row'>";

            foreach (DataRow row in dsCourses.Tables[0].Rows)
            {
                string courseName = row["C_Name"].ToString();
                string courseDesc = row["Desc"].ToString();

                // Construct the card HTML
                string cardHtml = $@"
        <div class='col-md-4'>
            <div class='card mb-4'>
                <h5 class='card-header'>{courseName}</h5>
                <div class='card-body'>
                    <p class='card-text'>{courseDesc}</p>
                    <button type='button' class='btn btn-primary' data-toggle='modal' data-target='#exampleModal{litCourseCards.Controls.Count}'>
                        Enrolled Clients
                    </button>
                </div>
            </div>
        </div>";

                // Append the card HTML to the Literal control
                litCourseCards.Text += cardHtml;

            }
            litCourseCards.Text += "</div>";
        }


    }
}
