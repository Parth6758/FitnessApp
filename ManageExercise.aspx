<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageExercise.aspx.cs" Inherits="FitnessApp.ManageExercise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Exercise</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <style>
        .card {
            margin-bottom: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
            transition: 0.3s;
        }

            .card:hover {
                box-shadow: 0 8px 16px 0 rgba(0, 0, 0, 0.2);
            }

        body {
            font-family: monospace;
        }

        .card-body {
            padding: 20px;
        }

        .card-title {
            font-weight: bold;
            font-size: 18px;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Manage Exercise</h1>
            <div class="row">
                <!-- Course Selection -->
                <div class="col-md-4">
                    <div class="form-group">
                        <label for="ddlCourses">Select Course:</label>
                        <select class="form-control" id="ddlCourses" runat="server" onchange="courseSelectionChanged()">
                            <option value="Full-body">Full-body</option>
                            <option value="Upper-body">Upper-body</option>
                            <option value="Lower-body">Lower-body</option>
                        </select>
                    </div>
                </div>
            </div>
            <div id="exerciseContainer" runat="server" class="row">
                <!-- Exercise Cards will be dynamically added here -->
            </div>
        </div>
    </form>

    <script>
        function courseSelectionChanged() {
            // Implement logic to handle course selection change if needed
            // You can use AJAX to fetch exercises based on the selected course and update the UI
        }
    </script>
</body>
</html>
