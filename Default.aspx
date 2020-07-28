<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" ValidateRequest="false" Inherits="_Default" %>

<!DOCTYPE>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="ckeditor/ckeditor.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   <asp:TextBox ID="text" runat="server" TextMode="MultiLine"></asp:TextBox>
   <script>
       CKEDITOR.replace("text"); 
   </script> 


        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="save" OnClick="save"  />
         <asp:Button ID="Button2" runat="server" Text="show" OnClick="showData"  />
       
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
    </div>
    </form>
</body>
</html>
