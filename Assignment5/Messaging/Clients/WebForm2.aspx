<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Clients.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Receiver ID"></asp:Label>
&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="receiverID" runat="server" OnTextChanged="receiverID_TextChanged"></asp:TextBox>
&nbsp;<asp:Button ID="receiveButton" runat="server" Text="Receive Now" OnClick="receiveButton_Click" />
            <br />
            <br />
            <asp:CheckBox ID="purgeCheckBox" runat="server" Text="Purge" OnCheckedChanged="purgeCheckBox_CheckedChanged" />
            <br />
        </div>
        <br />
        <asp:TextBox ID="MessageText" runat="server" Height="191px" OnTextChanged="MessageText_TextChanged" TextMode="MultiLine" Width="308px"></asp:TextBox>
        <br />
    </form>
</body>
</html>

