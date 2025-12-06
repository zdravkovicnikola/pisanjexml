<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pisanjexml.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr>
               <td>
                   <asp:Label ID="Label1" runat="server" Text="Unesite redni broj ucenika: "></asp:Label>
               </td>
               <td>
                   <asp:TextBox ID="Tbrb" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td>
                   <asp:Label ID="Label2" runat="server" Text="Unesite prezime ucenika: "></asp:Label>
               </td>
               <td>
                   <asp:TextBox ID="Tbprezime" runat="server"></asp:TextBox>
               </td>
           </tr>
            <tr>
               <td>
                   <asp:Label ID="Label3" runat="server" Text="Unesite ime ucenika: "></asp:Label>
               </td>
               <td>
                   <asp:TextBox ID="Tbime" runat="server"></asp:TextBox>
               </td>
           </tr>
            <tr>
               <td>
                   <asp:Label ID="Label4" runat="server" Text="Unesite prosek ucenika: "></asp:Label>
               </td>
               <td>
                   <asp:TextBox ID="Tbprosek" runat="server"></asp:TextBox>
               </td>
           </tr>
            <tr>
               <td>
                   <asp:Button ID="Btunos" runat="server" Text="Unesi podatke" OnClick="Btunos_Click" />
               </td>
               <td>
                   <asp:Button ID="Btkraj" runat="server" Text="Kraj unosa" OnClick="Btkraj_Click" />
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
