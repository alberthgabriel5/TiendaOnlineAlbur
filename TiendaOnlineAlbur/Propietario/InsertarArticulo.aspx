<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="InsertarArticulo.aspx.cs" Inherits="TiendaOnlineAlbur.Propietario.InsertarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid ">
        <div class="row">
            <div class="col-md-4 col-sm-4 col-xs-12"></div>
            <div class="col-md-4 col-sm-4 col-xs-12 ">                          
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="control-label">Art&iacute;culo</asp:Label>
                        <asp:TextBox runat="server"  CssClass="form-control" name="nombre" id="nombre" placeholder="Nombre"></asp:TextBox>
                        <%--<div class="selectContainer">
                           <select class="form-control" name="nombre" id="nombre" required>
                               <option value="Televisor">Televisor</option>
                               <option value="Computadora">Computadora</option>
                               <option value="Celular">Celular</option>
                            </select>
                        </div>--%>
                    </div>
                    <div class="form-group">
                        <label for="marca">Marca</label>
                        <input type="text" class="form-control" name="marca" id="marca" placeholder="marca" required />

                    </div>
                    <div class="form-group">
                        <label for="precio">Precio</label>
                        <input type="number" class="form-control" name="precio" id="precio" placeholder="precio" required />
                    </div>

                    <div class="form-group">
                        <label for="categoria">Categoria</label>
                        <input type="text" class="form-control" name="categoria" id="categoria" placeholder="categoria" required />
                    </div>

                    <div class="form-group">
                        <label for="descripcion">Descripci&oacute;n</label>
                        <textarea class="form-control" name="descripcion" id="descripcion" rows="3" required></textarea>
                    </div>
                    <!--               <button type="submit" name="usuarioActual" id="usuarioActual" class="btn btn-primary btn-block">Insertar</button>-->
                    <!--llamada con ajax-->
                    <input type="button" name="usuarioActual" id="usuarioActual" value="enviar"
                        onclick="llamar()" />
                </form>
                <!--FIN DEL FORMULARIO-->
                <%-- <script>
                function llamar(){
                    insertarArticulo($('#nombre').val(),
                    $('#marca').val(),$('#precio').val(),$('#categoria').val(),
                    $('#descripcion').val(),'');
                }
            </script>--%>
                <asp:Button ID="btnNuevoArticulo" runat="server" OnClick="btnNuevoArticulo_Click" Text="PRESS ME" />
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12"></div>
        </div>

    </div>


</asp:Content>
