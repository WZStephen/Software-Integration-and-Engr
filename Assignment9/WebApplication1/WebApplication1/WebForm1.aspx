<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ForeColor="Blue" Text="Web Application Performing Automated MapReduce"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;
            <asp:Label ID="status_label" runat="server" Text="Status"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Choose the number of parallel threads"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="threads_tf" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;<asp:Button ID="perform_btn" runat="server" BackColor="#66CCFF" OnClick="Perform_btn_Click" Text="Perform MapReduce Computation" Width="270px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Single thread execution time:"></asp:Label>
&nbsp;<asp:Label ID="singleExeTime_label" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Multithread execution time:"></asp:Label>
&nbsp;<asp:Label ID="multiExeTime_label" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="result_label" runat="server" Text="Display Results"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
