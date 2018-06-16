<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaOnlineAlbur.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article> 
    <div class="col-lg-12 center-block">
        <label class="label-info" lang="es">  
            <  if(isset($_SESSION['nick'])){echo 'Bienvenido '.$_SESSION['nick'];}
        >
  </label>
        
        <div class="col-lg-3"></div>        
        <img class="col-lg-5 center-block" src="public/img/11macmccardle-cityinamagnifyingglass.jpg" alt=""/>
        <div class="col-lg-3"></div>
    </div>
    
</article>
</asp:Content>
