<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="FitnessApp.CourseDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <title>Course Details</title>

    <style>
    body {
        font-family: monospace;
        }
    </style>
</head>

<body>
    <div style="margin: 40px 80px">
        <form id="form1" runat="server">
            <h1>Course Details</h1>
            <div id="courseContainer" runat="server" class="row">
                <!-- Cards will be dynamically added here -->
                <asp:Literal ID="litCourseCards" runat="server"></asp:Literal>
            </div>
        </form>
    </div>
</body>
</html>
