using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


  
namespace FitnessApp
    {
        public partial class ManageExercise : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    DisplayExercises("Full-body");
                }
            }

            protected void DisplayExercises(string course)
            {
                List<Exercise> exercises = FetchExercisesFromDatabase(course);

                exerciseContainer.Controls.Clear();

                foreach (Exercise exercise in exercises)
                {
                    Panel cardPanel = new Panel();
                    cardPanel.CssClass = "card col-md-4 mb-4";

                    Panel cardBody = new Panel();
                    cardBody.CssClass = "card-body";

                    Label exerciseNameLabel = new Label();
                    exerciseNameLabel.Text = exercise.Name;
                    exerciseNameLabel.CssClass = "card-title";

                    cardBody.Controls.Add(exerciseNameLabel);

                    cardPanel.Controls.Add(cardBody);

                  
                    exerciseContainer.Controls.Add(cardPanel);
                }
            }

            private List<Exercise> FetchExercisesFromDatabase(string course)
            {
               
                return new List<Exercise>
            {
                new Exercise { Name = "Exercise 1", ImageUrl = "exercise1.jpg" },
                new Exercise { Name = "Exercise 2", ImageUrl = "exercise2.jpg" },
                new Exercise { Name = "Exercise 3", ImageUrl = "exercise3.jpg" },
                 new Exercise { Name = "Exercise 4", ImageUrl = "exercise3.jpg" },
                  new Exercise { Name = "Exercise 5", ImageUrl = "exercise3.jpg" },
                   new Exercise { Name = "Exercise 6", ImageUrl = "exercise3.jpg" },
                    new Exercise { Name = "Exercise 7", ImageUrl = "exercise3.jpg" },
                     new Exercise { Name = "Exercise 8", ImageUrl = "exercise3.jpg" },
                      new Exercise { Name = "Exercise 9", ImageUrl = "exercise3.jpg" },
                // Add more exercises as needed
            };
            }

            public class Exercise
            {
                public string Name { get; set; }
                public string ImageUrl { get; set; }
            }
        }
    }







