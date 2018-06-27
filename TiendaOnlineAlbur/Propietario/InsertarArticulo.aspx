<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="InsertarArticulo.aspx.cs" Inherits="TiendaOnlineAlbur.Propietario.InsertarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid ">
        <div class="row">
            
            <div class="col-md-12 ">
            

                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label label-info">Art&iacute;culo</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control text-primary" ID="txtNombre"></asp:TextBox>
                    
                </div>

                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label label-info">Marca</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control text-primary" ID="txtMarca" />

                </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label label-info">Precio</asp:Label>

                    <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" ID="txtPrecio" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label label-info">Categoria</asp:Label>                    
                    <asp:ListBox runat="server"  Rows="1" CssClass="form-control list-group" ID="lbxCategoria" >
                        <asp:ListItem>Mouse</asp:ListItem>
                        <asp:ListItem>Monitor</asp:ListItem>
                        <asp:ListItem>Teclado</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                        <asp:ListItem>CPU</asp:ListItem>                      
                    </asp:ListBox>
                </div>
                
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label label-info">Descripci&oacute;n</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" id="txtDescripcion" rows="3" ></asp:TextBox>
                </div>
                 <div class="form-group">
                <asp:Button ID="btnNuevoArticulo" CssClass="btn btn-toolbar center-block col-lg-2 btn-info" runat="server"  Text="Insertar" OnClick="btnNuevoArticulo_Click" />
                </div>
                 <div class="form-group col-lg-12 center-block" >
                <asp:Label ID="Result" runat="server" Text=" "></asp:Label>
                </div>
            </div>
            
        </div>

    </div>

    
</asp:Content>
