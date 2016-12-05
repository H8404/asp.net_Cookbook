<%@ Page Title="Add recipe to CookBook" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="addRecipe.aspx.cs" Inherits="addRecipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/addRecipe.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1>CookBook</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class=" col-md-4 col-md-offset-4 bg-grey">
                <div class="form-group">
                    <label>Title: </label>
                    <asp:TextBox ID="tbTitle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Description: </label>
                    <asp:TextBox ID="tbDescription" runat="server" Height="100px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Category: </label>
                    <asp:TextBox ID="tbCategory" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Ingredients: </label>
                    <asp:TextBox ID="tbIngredients" runat="server" Height="250px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Steps: </label>
                    <asp:TextBox ID="tbSteps" runat="server" Height="250px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </div>
                <!--<div class="form-group">
                    <label>Picture of endproduct</label>
                    <br />
                    <label class="btn btn-default btn-file" style="color:#ff944d">
                        Browse <asp:FileUpload id="FileUploadControl" runat="server"   onchange="$('#upload-file-info').html($(this).val());"/>
                    </label>
                    <span class='label label-info' id="upload-file-info"></span>
                </div>-->
                <div class="form-group">
                    <asp:Button ID="btnSaveToDatabase" runat="server" style="color:#ff944d" Text="Save" CssClass="btn btn-default"  OnClick="btnSaveToDatabase_Click"/>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap Modal Dialog -->
    <div class="modal fade"  id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog" style="z-index:2">
            <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            </div>
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h4 class="modal-title"><asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Close</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

