<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task1.aspx.cs" Inherits="Task1.Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           <%-- <input id="Reset1" type="reset" value="reset" />
            <input id="Button1" type="button" value="button" />--%>

            
           
            <asp:RadioButton ID="RadioButton1" name="calc" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="sum" /> 
            <asp:Label  for="RadioButton1" ID="Label1" runat="server" Text="+"></asp:Label>
            <asp:RadioButton  ID="RadioButton2"  name="calc" runat="server" Text="sub" /> 
            <asp:Label for="RadioButton2" ID="Label2" runat="server" Text="-"></asp:Label>
            <asp:RadioButton  ID="RadioButton3" name="calc" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="multiplication" />
            <asp:Label  for="RadioButton3" ID="Label3" runat="server" Text="*"></asp:Label>
            <asp:RadioButton  ID="RadioButton4" name="calc" runat="server" Text="division" />
            <asp:Label  for="RadioButton4" ID="Label4" runat="server" Text="/"></asp:Label>
              
        </div>
        
    </form>
</body>
</html>
