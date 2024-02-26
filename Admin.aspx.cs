using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FitnessApp
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public static int Id;

        public void fnconnection()
        {
            try { 
                String constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                conn = new SqlConnection(constr);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                  //Response.Write("Connected");
                }
            }
           catch( Exception ex ) {
            
            }
         }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                fnconnection();
                
            }
            fnbindgridview();
        }

        protected void fnbindgridview()
        {
            try
            {
                fnconnection();
                String qry = "select * from Userinfo";
                cmd = new SqlCommand(qry, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet(); 
                sda.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void insert()
        {
            try
            {
                fnconnection();
                String qry = "insert into Userinfo (Name,Email,Password,C_password,Age,City,Height,Weight,Gender,Course) VALUES (@Name,@Email,@Password,@C_password,@Age,@City,@Height,@Weight,@Gender,@Course)";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("Name", Name.Text);
                cmd.Parameters.AddWithValue("Email", Email.Text);
                cmd.Parameters.AddWithValue("Password", Password.Text);
                cmd.Parameters.AddWithValue("C_password", cpass.Text);
                cmd.Parameters.AddWithValue("Age", Age.Text);
                cmd.Parameters.AddWithValue("City", Ddlcity.Text);
                cmd.Parameters.AddWithValue("Height", Height.Text);
                cmd.Parameters.AddWithValue("Weight", Weight.Text);
                cmd.Parameters.AddWithValue("Gender", Rblgender.Text);
                cmd.Parameters.AddWithValue("Course", Ddlcourse.Text);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Response.Write("User Inserted");
                }
                else
                {
                    Response.Write("User Not Inserted");
                }
                conn.Close();
                fnbindgridview();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void update()
        {
            try
            {
                fnconnection();
                String qry = "update Userinfo SET Name = @Name, Email = @Email, Password = @Password, C_password = @C_password, Age = @Age, City = @City, Height = @Height, Weight = @Weight, Gender = @Gender, Course = @Course where Id = @Id";
                cmd = new SqlCommand (qry, conn);
                
                cmd.Parameters.AddWithValue("Name", Name.Text);
                cmd.Parameters.AddWithValue("Email", Email.Text);
                cmd.Parameters.AddWithValue("Password", Password.Text);
                cmd.Parameters.AddWithValue("C_password", cpass.Text);
                cmd.Parameters.AddWithValue("Age", Age.Text);
                cmd.Parameters.AddWithValue("City", Ddlcity.Text);
                cmd.Parameters.AddWithValue("Height", Height.Text);
                cmd.Parameters.AddWithValue("Weight", Weight.Text);
                cmd.Parameters.AddWithValue("Gender", Rblgender.Text);
                cmd.Parameters.AddWithValue("Course", Ddlcourse.Text);
                cmd.Parameters.AddWithValue("Id", Id);

                int res = cmd.ExecuteNonQuery();
                if(res > 0)
                {
                    Response.Write("User Updated");
                }
                else
                {
                    Response.Write("User not Updated");
                }
                conn.Close ();
                fnbindgridview();
            }
            catch (Exception e)
            {

                Response.Write(e.ToString());
            }
        }

        public void delete()
        {
            try
            {
                fnconnection();
                String qry = "DELETE FROM Userinfo WHERE Id = @Id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("Id",Id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Response.Write("Data Removed");
                }
                else
                {
                    Response.Write("Not deleted");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void Insert_Click(object sender, EventArgs e)
        {
            insert();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow rw = GridView1.SelectedRow;
            Id = Convert.ToInt32(rw.Cells[1].Text);
            Name.Text = rw.Cells[2].Text;
            Email.Text = rw.Cells[3].Text;
            Password.Text = rw.Cells[4].Text;
            cpass.Text = rw.Cells[5].Text;
            Age.Text = rw.Cells[6].Text;
            //   Ddlcity.Text = rw.Cells[7].Text;
            Height.Text = rw.Cells[8].Text;
            Weight.Text = rw.Cells[9].Text;
            //    Rblgender.Text = rw.Cells[10].Text;
            //    Ddlcourse.Text = rw.Cells[11].Text;

            for (int i = 0; i < Ddlcity.Items.Count; i++)
            {
                if (Ddlcity.Items[i].Text == rw.Cells[7].Text.Trim())
                {
                    Ddlcity.SelectedIndex = i;
                    
                    break;

                }
            }
            for (int i = 0; i < Rblgender.Items.Count; i++)
            {
                if (Rblgender.Items[i].Text == rw.Cells[10].Text.Trim())
                {
                    Rblgender.Items[i].Selected = true;
                    break;
                }
            }
            for (int i = 0; i < Ddlcourse.Items.Count; i++)
            {
                if (Ddlcourse.Items[i].Text == rw.Cells[11].Text.Trim())
                {
                    Ddlcourse.SelectedIndex = i;
                    break;
                }
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            update();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}