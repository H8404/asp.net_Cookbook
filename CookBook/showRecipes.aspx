<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="showRecipes.aspx.cs" Inherits="showRecipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1>Your Recipes</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 col-md-offset-3 bg-grey list-group">
                <div class="btn-group">
                    <asp:DropDownList ID="ddCategory" runat="server" OnSelectedIndexChanged="ddCategory_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div runat="server" id="divData">

                </div>
            </div>
        </div>
    </div>
</asp:Content>

