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
            int cardCounter = 0;
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
                        <button type='button' class='btn btn-primary' data-toggle='modal' data-target='#exampleModal{cardCounter}'>
                            Launch
                        </button>
                        <p class='card-text'><small class='text-muted'>Last updated 3 mins ago</small></p>
                    </div>
                </div>
            </div>";

                // Append the HTML to the Literal control
                litCourseCards.Text += cardHtml;

                // Modal HTML for each card
                string modalHtml = $@"
            <!-- Modal for card {cardCounter} -->
            <div class='modal fade' id='exampleModal{cardCounter}' tabindex='-1' role='dialog' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                <div class='modal-dialog modal-dialog-scrollable' role='document'>
                    <div class='modal-content'>
                        <div class='modal-header'>
                            <h5 class='modal-title fs-5'>{courseName}</h5>
                            <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                                <span aria-hidden='true'>&times;</span>
                            </button>
                        </div>
                        <div class='modal-body'>
                            <p>{courseDesc}</p>
                            <!-- Additional modal content here if needed -->
                        </div>
                        <div class='modal-footer'>
                            <button type='button' class='btn btn-secondary' data-dismiss='modal'>Close</button>
                            <!-- Additional buttons here if needed -->
                        </div>
                    </div>
                </div>
            </div>";

                // Append the modal HTML to the form
                form1.Controls.Add(new LiteralControl(modalHtml));

                cardCounter++;
            }
        }


    }
}
