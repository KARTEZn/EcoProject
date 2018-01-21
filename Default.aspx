<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select File &nbsp;<asp:FileUpload ID="FileUploader" runat="server" /><br />
        <br />
        <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadButton_Click" /><br />
        <br />
         <asp:Label ID="Label1" runat="server"></asp:Label><br /> 
</div>
    </form>
</body>
</html>
