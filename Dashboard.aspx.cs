using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void course_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CourseDetails.aspx");
        }

        protected void client_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientInfo.aspx");
        }

        protected void exercise_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ManageExercise.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            Session.Clear();

            Response.Redirect("Login.aspx");
        }
    }
}