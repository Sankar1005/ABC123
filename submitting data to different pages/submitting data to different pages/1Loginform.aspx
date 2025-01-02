<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1Loginform.aspx.cs" Inherits="submitting_data_to_different_pages.Loginform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Enter User Name:</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td>
                        <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="Right">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
