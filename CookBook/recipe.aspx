<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="recipe.aspx.cs" Inherits="recipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1 >CookBook</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class=" col-md-6 col-md-offset-3 ">
                <h2 runat="server" id="txtHeader" style="color:#ff944d"></h2>
                <hr />
                <p runat="server" id="txtDescription" style="font-size:16px"></p>
                <hr />
                <p runat="server" id="txtIngredients" style="font-size:16px"></p>
                <hr />
                <p runat="server" id="txtSteps" style="font-size:16px"></p>
                <hr />
                <div id="buttons" class="btnCss" style="margin-bottom:20px;">
                    <a id="btnEdit" runat="server" class="btn btn-default" style="color:#ff944d" href="editRecipe.aspx">Edit</a>
                    <asp:Button ID="btnConfirm" CssClass="btn btn-default" style="color:#ff944d; margin-left:10px;" runat="server" Text="Delete" OnClick="btnConfirm_Click"/>
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
                            <asp:button ID="btnRemove" runat="server" class="btn btn-danger btn-ok" OnClick="btnRemove_Click" Text="Delete"></asp:button>
                            <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Close</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

