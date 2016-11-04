<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="CSS/login.css" rel="stylesheet" />
    <title>Log in to cookbook</title>
</head>
<body>
    <form id="form1" runat="server" style="height:100%">
        <div class="container container-table">
            <div class="row vertical-center-row">
                <div class="text-center col-md-4 col-md-offset-4 well well-lg loginform">
                    <h2>Log in to CookBook</h2>
                    <div class="form-group">
                        <label>Email:</label>
                        <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="tbEmail"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Password:</label>
                        <asp:TextBox runat="server" TextMode="Password" ID="tbPasword" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="btnLogin_Click"></asp:Button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
