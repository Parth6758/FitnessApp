<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FitnessApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: monospace;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        #loginContainer {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.1);
            padding: 30px;
            width: 300px;
            text-align: center;
        }

        h2 {
            color: #333;
        }

        #lblMessage {
            color: red;
        }

        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }

        #btnLogin {
            background-color: #007bff;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            #btnLogin:hover {
                background-color: #0056b3;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="loginContainer">
            <h2>Login</h2>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Username"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
