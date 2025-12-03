<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Parcial_3.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"> Gestionar </h2>
        <asp:GridView ID="GridViewArticulos" runat="server" AutoGenerateColumns="False" 
            CssClass="table table-bordered"
            EmptyDataText="No hay artículos disponibles."
            DataKeyNames="Id"
            OnRowEditing="GridViewArticulos_RowEditing"
            OnRowUpdating="GridViewArticulos_RowUpdating"
            OnRowCancelingEdit="GridViewArticulos_RowCancelingEdit"
            OnRowDeleting="GridViewArticulos_RowDeleting">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Titulo" HeaderText="Título" />
                <asp:BoundField DataField="FechaPublicacion" HeaderText="Fecha Publicación" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="Autor" HeaderText="Autor" />
                <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha Registro" ReadOnly="True" />

                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" EditText="Editar articulo" UpdateText="Guardar informacion" DeleteText="Eliminar articulo"/>
            </Columns>
        </asp:GridView>

    </main>
</asp:Content>
