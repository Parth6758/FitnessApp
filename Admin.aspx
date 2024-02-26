<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="FitnessApp.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: large;
        }
        .auto-style2 {
            width: 1187px;
        }
        .auto-style3 {
            text-align: left;
            width: 149px;
        }
        .auto-style5 {
            text-align: left;
            width: 149px;
            height: 24px;
        }
        .auto-style8 {
            text-align: left;
            height: 27px;
        }
        .auto-style10 {
            text-align: left;
            width: 149px;
            height: 26px;
        }
        .auto-style12 {
            text-align: left;
            height: 24px;
            width: 987px;
        }
        .auto-style13 {
            text-align: left;
            height: 26px;
            width: 987px;
        }
        .auto-style14 {
            text-align: left;
            width: 987px;
        }
        .auto-style15 {
            text-align: left;
            width: 149px;
            height: 28px;
        }
        .auto-style16 {
            text-align: left;
            width: 987px;
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Admin Page</strong><table border="1" class="auto-style2">
                <tr>
                    <td class="auto-style3">Name:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="Name" runat="server" Width="979px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="Email" runat="server" OnTextChanged="TextBox2_TextChanged" Width="978px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Password:</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="Password" runat="server" OnTextChanged="TextBox2_TextChanged" Width="978px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Confirm Password:</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="cpass" runat="server" OnTextChanged="TextBox2_TextChanged" Width="978px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Age:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="Age" runat="server" OnTextChanged="TextBox2_TextChanged" Width="980px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">City:</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="Ddlcity" runat="server">
                            <asp:ListItem>NewYork</asp:ListItem>
                            <asp:ListItem>Miami</asp:ListItem>
                            <asp:ListItem>Austin</asp:ListItem>
                            <asp:ListItem>Texas</asp:ListItem>
                            <asp:ListItem>LasVegas</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Height:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="Height" runat="server" OnTextChanged="TextBox2_TextChanged" Width="979px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Weight:</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="Weight" runat="server" OnTextChanged="TextBox2_TextChanged" Width="977px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Gender:</td>
                    <td class="auto-style14">
                        <asp:RadioButtonList ID="Rblgender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Course:</td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="Ddlcourse" runat="server">
                            <asp:ListItem>Full-Body</asp:ListItem>
                            <asp:ListItem>Upper-Body</asp:ListItem>
                            <asp:ListItem>Lower-Body</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">
                        <asp:Button ID="Insert" runat="server" OnClick="Insert_Click" Text="Insert " />
&nbsp;
                        <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update " />
                    &nbsp;
                        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete " />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </form>
</body>
</html>
