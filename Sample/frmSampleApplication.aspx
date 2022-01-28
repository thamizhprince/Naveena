<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSampleApplication.aspx.cs" Inherits="Sample.frmSampleApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
    <table>
           <tr>
               <td><asp:Label runat="server" ID="firstname">First Name </asp:Label></td>
                <td><asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox> </td>
           </tr>
         <tr>
               <td><asp:Label runat="server" ID="lastname">Last Name </asp:Label></td>
                <td><asp:TextBox runat="server" ID="txtLastName"></asp:TextBox> </td>
           </tr>
        <tr>           
            <td></td>
            <td><asp:Button ID="btnSave" runat="server"  Text="Save"  BackColor="Green" OnClick="btnSave_Click"/>
                <asp:Button ID="btnClearAll" runat="server" Text="Clear All" BackColor="RoyalBlue" OnClick="btnClearAll_Click" /> </td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>
