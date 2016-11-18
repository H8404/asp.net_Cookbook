<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="showRecipes.aspx.cs" Inherits="showRecipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1>Your Recipes</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div runat="server" id="divData" class="col-md-6 col-md-offset-3 bg-grey list-group">

            </div>
        </div>
    </div>
</asp:Content>

