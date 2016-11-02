<%@ Page Title="Add recipe to CookBook" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="addRecipe.aspx.cs" Inherits="addRecipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class=" col-md-4 col-md-offset-4 bg-grey">
                <asp:Label runat="server" ID="lbmsg" Text="" CssClass="label"></asp:Label>
                <div class="form-group">
                    <label>Title: </label>
                    <!--<asp:Label ID="lbTitle" runat="server" Text="Title: "></asp:Label>-->
                    <asp:TextBox ID="tbTitle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Description: </label>
                    <!-- <asp:Label ID="lbDescription" runat="server" Text="Description: "></asp:Label>-->
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
                    <asp:TextBox ID="TextBox1" runat="server" Height="250px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Picture of endproduct: </label>
                    <asp:FileUpload id="FileUploadControl" runat="server" />
                </div>
                <div class="form-group">
                    <asp:Button ID="btnSaveToDatabase" runat="server" Text="Save" CssClass="btn btn-default" OnClick="btnSaveToDatabase_Click"/>
                </div>
                <asp:GridView ID="gvTest" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

