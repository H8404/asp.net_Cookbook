<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="recipe.aspx.cs" Inherits="recipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1 runat="server" id="txtHeader"></h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class=" col-md-4 col-md-offset-4 bg-grey">
                <p runat="server" id="txtDescription"></p>
                <p runat="server" id="txtSteps"></p>
            </div>
        </div>
    </div>
</asp:Content>

