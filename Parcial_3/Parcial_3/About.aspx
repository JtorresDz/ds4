<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Parcial_3.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"> Almacenar </h2>
        
        <div class="Formulario" Style="display: flex; flex-direction: column; gap: 15px;">
            <asp:TextBox ID="nombreA" runat="server" Placeholder="Título"></asp:TextBox>
            <asp:TextBox ID="fechaA" runat="server" TextMode="Date"></asp:TextBox>
            <asp:TextBox ID="descripcionA" runat="server" TextMode="MultiLine" CssClass="descripcionBox" Placeholder="Descripción"></asp:TextBox>
            <asp:TextBox ID="autorA" runat="server" Placeholder="Autor"></asp:TextBox>
            <asp:Button ID="almacenar" runat="server" Text="Guardar" OnClick="almacenar_Click" />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </main>
</asp:Content>