<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="FitnessApp.AddClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Client</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        body {
            background-color: #f8f9fa;
            font-family: monospace;
        }

        .container {
            margin-top: 50px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        label {
            font-weight: bold;
        }

        .btn-primary {
            background-color: #007bff;
            border-color: #007bff;
        }

            .btn-primary:hover {
                background-color: #0056b3;
                border-color: #0056b3;
            }
    </style>
</head>
<body>
    <div style="text-align: center; margin-bottom: 30px">
        <h1>Add Clients</h1>
    </div>
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="Name">Name:</label>
                <asp:TextBox ID="Name" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="Email">Email:</label>
                <asp:TextBox ID="Email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="Age">Age:</label>
                <asp:TextBox ID="Age" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="City">City:</label>
                <asp:DropDownList ID="City" runat="server" CssClass="form-control">
                    <asp:ListItem Value="New York">New York</asp:ListItem>
                    <asp:ListItem Value="Los Angeles">Los Angeles</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="Height">Height (in cm):</label>
                <asp:TextBox ID="Height" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="Weight">Weight (in kg):</label>
                <asp:TextBox ID="Weight" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Gender:</label>
                <asp:RadioButtonList ID="Gender" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="form-group">
                <label for="Course">Course:</label>
                <asp:DropDownList ID="Course" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Full-body">Full-body</asp:ListItem>
                    <asp:ListItem Value="Upper-body">Upper-body</asp:ListItem>
                    <asp:ListItem Value="Lower-body">Lower-body</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="Progress">Progress:</label>
                <asp:TextBox ID="progress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
        </form>
            </div>
</body>
</html>
