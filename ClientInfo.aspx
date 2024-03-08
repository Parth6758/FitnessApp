<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientInfo.aspx.cs" Inherits="FitnessApp.ClientInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FitTrackr (Admin) - Clients</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link rel="stylesheet" href="~/ClientInfoCss.css" />

    <style>
        body {
            font-family: monospace;
        }
    </style>
</head>
<body>
    <div style="margin: 40px 80px">
        <form id="form1" runat="server">
            <div style="text-align: center; margin-bottom: 30px">
                <h1>Clients</h1>
            </div>
            <div style="position: absolute; top: 40px; right: 50px">
                <asp:Button ID="btnAddClient" runat="server" Text="Add Client" CssClass="btn btn-primary" OnClick="btnAddClient_Click" />
            </div>
            <div style="position: absolute; top: 40px; left: 50px">
                <asp:Button ID="btnGoHome" runat="server" Text="Home" CssClass="btn btn-primary" OnClick="btnGoHome_Click" />
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
                            <th scope="col">Progress</th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="litClientRows" runat="server"></asp:Literal>
                    </tbody>
                </table>
            </div>

            <div class="dots-menu btn-group">
                <a data-toggle="dropdown" class="btn btn-primary">Click me!</a>
                <ul class="dropdown-menu">
                    <li><a href="#"><i class="fa fa-pencil"></i>Edit</a></li>
                    <li class="delete-row">
                        <a href="" data-toggle="modal" data-target="#alert-modal"><i class="fa fa-trash-o"></i>Delete</a>
                    </li>
                </ul>
            </div>
        </form>
    </div>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="~/ClientInfoJs.js"></script>
</body>
</html>
