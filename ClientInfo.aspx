<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientInfo.aspx.cs" Inherits="FitnessApp.ClientInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FitTrackr (Admin) - Clients</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link rel="stylesheet" href="~/ClientInfoCss.css" />
</head>
<body>
    <div style="margin: 40px 80px">
        <form id="form1" runat="server">
            <div style="text-align:center; margin-bottom:30px">
                <h1>Clients</h1> 
            </div>
            <div class="table-responsive">
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th scope="col"></th>
                            <th scope="col">Name</th>
                            <th scope="col">Email</th>
                            <th scope="col">Age</th>
                            <th scope="col">Height</th>
                            <th scope="col">Weight</th>
                            <th scope="col">Gender</th>
                            <th scope="col">Course</th>
                            <th scope="col">Progress</th>s
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="litClientRows" runat="server"></asp:Literal>
                    </tbody>
                </table>
            </div>
        </form>
    </div>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="~/ClientInfoJs.js"></script>
</body>
</html>
