<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaOnlineAlbur.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanelLogin" runat="server">
        <ContentTemplate>
                <div class="col-lg-6 container formulario center-block">

                    <div class="row">
                        <fieldset class="col-xs-12 col-xs-offset-1">


                            <legend class="hidden-xs h3">Inicio de Sesi&oacute;n
                            </legend>

                            <div class="form-group">
                                <asp:Label ID="LblUsuario" runat="server"  CssClass="col-xs-12 h4" Text="Usuario o E-mail">                                    
                                </asp:Label>
                                <div class="col-xs-10 col-xs-offset-1">
                                    <asp:TextBox ID="usuario" runat="server" CssClass="form-control Input" />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="LblPassword" runat="server"  CssClass="col-xs-12 h4"  Text="Contraseña">
                                </asp:Label>
                                <div class="col-xs-10 col-xs-offset-1">
                                    <asp:TextBox runat="server" TextMode="Password" ID="password" CssClass="form-control col-xs-12 Input" />
                                </div>
                            </div>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <br />
                            <br />
                            <br />

                            <div class="form-group  ">
                                <asp:Label ID="Result" runat="server" Text=""></asp:Label>
                                <br />
                                <br />
                                <br />
                                <br />
                                <asp:Button ID="Iniciar" runat="server" CssClass="btn btn-primary center-block" Text="Aceptar" OnClick="Iniciar_Click"></asp:Button>

                            </div>


                        </fieldset>

                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
