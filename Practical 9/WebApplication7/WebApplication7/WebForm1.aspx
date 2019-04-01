<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxt1" runat="server" 
            ControlToValidate="txtbox1" Display="Dynamic" 
            ErrorMessage="Please Enter Number" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxt1" runat="server" 
            ControlToValidate="txtbox1" ErrorMessage="Enter Only Number " ForeColor="Red" 
            ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="txtbox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxt2" runat="server" 
            ControlToValidate="txtbox2" Display="Dynamic" 
            ErrorMessage="Please Enter Number" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="rev2" runat="server" 
            ControlToValidate="txtbox2" ErrorMessage="Enter Only Number" 
            ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnadd" runat="server" Text="ADD" onclick="btn1_Click" />
        <asp:Button ID="btnsub" runat="server" Text="SUB" onclick="btnsub_Click" />
        <asp:Button ID="btnmul" runat="server" Text="MUL" onclick="btnmul_Click" />
        <asp:Button ID="btndiv" runat="server" Text="DIV" onclick="btndiv_Click" />
        <br />
        <asp:Label ID="lblresult" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
