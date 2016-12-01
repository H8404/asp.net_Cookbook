<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>
<%@ Import Namespace="System.Web.Security" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="CSS/login.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Log in to cookbook</title>
</head>
<body>
    <form id="form1" runat="server" style="height:100%">
        <div class="container container-table">
            <div class="row vertical-center-row">
                <div class="text-center col-md-4 col-md-offset-4 well well-lg loginform">
                    <h2>Log in to CookBook</h2>
                    <div class="form-group">
                        <label>Username:</label>
                        <asp:TextBox runat="server" CssClass="form-control" ID="tbUsername"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Password:</label>
                        <asp:TextBox runat="server" TextMode="Password" ID="tbPasword" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="btnLogin_Click"></asp:Button>
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
    </form>
</body>
</html>
