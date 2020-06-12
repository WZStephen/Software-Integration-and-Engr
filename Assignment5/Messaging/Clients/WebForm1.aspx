<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clients.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 747px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="To Whome (ID)"></asp:Label>
&nbsp;<asp:TextBox ID="receiverID" runat="server" OnTextChanged="receiverID_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="From (ID)"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="senderID" runat="server" OnTextChanged="senderID_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Message"></asp:Label>
        <br />
        <asp:TextBox ID="messageText" runat="server" Height="192px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="338px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="sendMessageButton" runat="server" Text="Send Message" OnClick="sendMessageButton_Click" />
    </form>
</body>
</html>
