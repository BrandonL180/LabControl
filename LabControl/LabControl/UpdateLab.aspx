<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateLab.aspx.cs" Inherits="login.Account.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Actulizar laboratorio</h2>
    <div class="container-fluid" style="height: 359px; width: 703px">
      
    <p>

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblnameUpdateLab" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnameUpdateLab" runat="server"></asp:TextBox>

    </p>
       <p>

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="lbldescription" runat="server" Text="Descripción"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="txtdescriptionlab" runat="server" Width="528px"></asp:TextBox>

           </p>
       <p>

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="lblshedule" runat="server" Text="Horario"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

           </p>
        <p>

            &nbsp;</p>
       <p>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="btnUpdateLab" runat="server" Text="Actulizar" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="btnCancelLab" runat="server" Text="Cancelar" />
           </p>
        </div>
        <div style="height: 80px">
        <div style="height: 54px; margin-top: 12px">
        </div>
    </div>
</asp:Content>