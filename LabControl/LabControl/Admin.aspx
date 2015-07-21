<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="login.Account.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:LinkButton ID="hlbtnCreateUser" runat="server" OnClick="hlbtnCreateUser_Click">Crear Usuario</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:" Visible="False"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="lblErrorNombre" runat="server" ForeColor="Red" Text="*Nombre no puede estar vacido" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblEmail" runat="server" Text="Correo:" Visible="False"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="lblErrorCorreo" runat="server" ForeColor="Red" Text="*Correo no puede estar vacido" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label runat="server" Text="Carnet:" ID="lblStudentId" Visible="False"></asp:Label>
        <asp:TextBox ID="txtStudentId" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="lblErrorCarnet" runat="server" ForeColor="Red" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblRole" runat="server" Text="Rol:" Visible="False"></asp:Label>
         <asp:DropDownList id="RolList" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" Visible="False">

                  <asp:ListItem Selected="True" Value="1"> Administrador </asp:ListItem>
                  <asp:ListItem Value="2"> Logistica </asp:ListItem>
                  <asp:ListItem Value="3"> Estudiante </asp:ListItem>
                  <asp:ListItem Value="4"> Profesor </asp:ListItem>
            

               </asp:DropDownList>

    </p>
    <p>
        <asp:Button ID="btnGuardarNewUser" runat="server" Text="Guardar" OnClick="Button1_Click1" Visible="False" Height="25px" Width="82px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Visible="False">Cancelar</asp:LinkButton>
    </p>
    <div style="height: 80px">
        <div style="height: 54px; margin-top: 12px">
        </div>
    </div>
</asp:Content>
