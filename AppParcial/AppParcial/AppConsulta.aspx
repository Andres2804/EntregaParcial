<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppConsulta.aspx.cs" Inherits="AppParcial.AppConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 167px">
    
        <asp:GridView ID="tabla" runat="server">
        </asp:GridView>
        <asp:Button ID="btnConsulta" runat="server" OnClick="btnConsulta_Click" Text="Consultar" />
        <br />
    
    </div>
    </form>
</body>
</html>
