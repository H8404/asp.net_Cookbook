<%@ Page Title="Your Recipes" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="showRecipes.aspx.cs" Inherits="showRecipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="jumbotron" Runat="Server">
    <h1>CookBook</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
            <div class="col-md-6 col-md-offset-3 bg-grey row">
                    <div class="dropdown open" style="z-index:0" >
                        <asp:DropDownList CssClass="dropdown-menu" aria-labelledby="dropdownMenuButton" ID="ddCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddCategory_SelectedIndexChanged"  >
                            <asp:ListItem >Select Category</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                <div runat="server" id="divData" class="row" style="margin-top:60px; margin-bottom:20px;">
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

