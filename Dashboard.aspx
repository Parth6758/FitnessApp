<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FitnessApp.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand mx-auto" href="#">FitTrackr Admin</a>
        </div>
    </nav>

    <div style="margin:40px 80px">
        <form id="form1" runat="server">
            <div>
                <!-- Courses -->
                <div class="card" style="margin-bottom: 15px">
                    
                    <div class="card-body">
                        <h1>Courses</h1>
                        <p>Everything we see in the world around us has a shape. We can find different basic shapes such as the square, rectangle, and oval or the rectangular prism, cylinder, and sphere in the objects we see around us. These geometric shapes appear in objects...</p>
                        <asp:Button ID="course" runat="server" Text="More" OnClick="course_Click" />
                    </div>
                </div>

                <!-- Clients -->
                <div class="card" style="margin-bottom: 15px">
                    
                    <div class="card-body">
                        <h1>Clients</h1>
                        <p>Everything we see in the world around us has a shape. We can find different basic shapes such as the square, rectangle, and oval or the rectangular prism, cylinder, and sphere in the objects we see around us. These geometric shapes appear in objects...</p>
                        <asp:Button ID="client" runat="server" Text="More" OnClick="client_Click" />
                    </div>
                </div>

                <!-- Exercise -->
                <div class="card" style="margin-bottom: 15px">
                    
                    <div class="card-body">
                        <h1>Exercises</h1>
                        <p>Everything we see in the world around us has a shape. We can find different basic shapes such as the square, rectangle, and oval or the rectangular prism, cylinder, and sphere in the objects we see around us. These geometric shapes appear in objects...</p>
                        <asp:Button ID="exercise" runat="server" Text="More" OnClick="exercise_Click" />

                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
