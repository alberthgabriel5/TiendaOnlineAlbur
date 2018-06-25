<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TiendaOnlineAlbur.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-lg-12 container formulario center-block">

            <div class="row">
                <fieldset class="col-xs-10 col-xs-offset-1">


                    <legend class="hiden-xs h3">Registro
                    </legend>
                    <div class="form-group">
                        <label class="col-xs-12 h4" for="Nickname">
                            Usuario
                        </label>
                        <div class="col-xs-12 col-xs-offset-1">
                            <asp:TextBox ID="Nickname" runat="server" CssClass="form-control Input"  />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-12 h4" for="email">
                            E-mail
                        </label>
                        <div class="col-xs-12 col-xs-offset-1">
                            <asp:TextBox TextMode="Email" ID="email" runat="server" CssClass="form-control Input" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-12 h4" for="password">
                            Password
                        </label>
                        <div class="col-xs-12 col-xs-offset-1">
                            <asp:TextBox runat="server" TextMode="Password" ID="Pasword" CssClass="form-control col-xs-12 Input" />
                        </div>
                    </div>
                    <div class="form-group ">
                        <label class="col-xs-12 h4" for="age">
                            Edad
                        </label>
                        <div class="col-xs-12 col-xs-offset-1">
                        <asp:TextBox  runat="server" TextMode="Number" CssClass="form-control" id="txtAgeUser"  />
                         </div>
                        </div>
                    <div class="col-lg-12 form-group">
                        <asp:Label ID="Result" CssClass="alert-danger" runat="server" AssociatedControlID="Result"></asp:Label>
                    </div>
                    <div class="col-lg-12 form-group">
                        <asp:Button ID="btnRegistrar" runat="server"  CssClass="btn btn-primary center-block" Text="Registrar" OnClick="btnRegistrar_Click"></asp:Button>
                    </div>
                </fieldset>

            </div>

        </div>
    
          
</asp:Content>

