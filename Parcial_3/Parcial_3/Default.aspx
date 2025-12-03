<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <div>
        <asp:TextBox ID="nombreB" runat="server" Placeholder="Buscar por título"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="buscar_Click" />
        <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
        <asp:GridView ID="GridViewResultados" runat="server" AutoGenerateColumns="true" 
                      EmptyDataText="No se encontraron artículos.">
        </asp:GridView>
       </div>
    </main>

</asp:Content>
