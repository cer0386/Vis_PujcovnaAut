<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailZakaznika.aspx.cs" Inherits="Vis_web.DetailZakaznika" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="jmeno" runat="server" placeholder="Jméno"></asp:TextBox>
            <asp:TextBox ID="prijmeni" runat="server" placeholder="Příjmení"></asp:TextBox>
            <asp:TextBox ID="ridicak" runat="server"  placeholder="Číslo řidičského průkazu"></asp:TextBox>
            <asp:Button ID="hledat" runat="server" Text="Vyhledat " OnClick="hledat_Click" style="text-decoration: underline" />

            <asp:GridView ID="vsichniZak" runat="server" OnSelectedIndexChanged="vsichniZak_SelectedIndexChanged" AutoGenerateSelectButton="true">
                

            </asp:GridView>

        </div>
        <h3>
            Rezervace zákazníka</h3>
        <asp:GridView ID="rezervaceZak" runat="server" OnSelectedIndexChanged="rezervaceZak_SelectedIndexChanged" AutoGenerateSelectButton="true">
        </asp:GridView>
        <h3>
            Faktura a platba rezervace</h3>
        <asp:Label ID="fak" runat="server" Text="Rezervace"></asp:Label><br />
        <asp:Label ID="plat" runat="server" Text="Platba"></asp:Label>
        
        <h3>Auta na rezervaci</h3>
        <asp:GridView ID="autaRez" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Nový zákazník" />
        <asp:Button ID="Button2" runat="server" Text="Aktualizovat údaje" />
        <asp:Button ID="Button3" runat="server" Text="Smazat zákazníka" />
        <asp:Button ID="Button4" runat="server" Text="Zpět" OnClick="Button4_Click" />
    </form>
</body>
</html>
