<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formulario2.aspx.cs" Inherits="ClienteWeb.Formulario2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <div class="container-fluid">
			<div class="row">
				<div class="col-md-4">
				</div>
				<div class="col-md-4">
					<div class="form-group">
					 	<label for="TxtDepartamento">Departamento</label>
                        <asp:TextBox ID="TxtDepartamento" runat="server" class="form-control"></asp:TextBox>
					</div>
                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="BtnBuscar_Click"/>
				</div>
				<div class="col-md-4">
				</div>
			</div>
			<br />
			<br />
			<div class="row">
				<div class="col-md-12">
					<asp:GridView ID="GridViewTiempo" runat="server" class="table tabla1"></asp:GridView>
				</div>
			</div>
		</div>
        
    </div>
</asp:Content>
