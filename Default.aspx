<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="400px" align="center" border="3">
                <tr valign="top">
                    <td align="right">
                        <asp:Label ID="lblName" runat="server" Text="Guess a Name" />
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtName" runat="server" ToolTip="Enter Any Name" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnGuess" runat="server" Text="Guess!" OnClick="btnGuess_Click" /><br />
                        <asp:Label ID="lblResult" runat="server" Text="" />
                    </td>
                </tr>                
            </table>
        </div>
    </form>
</body>
</html>
