<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid text-center bg-grey">
        <div class="row text-center">
            <div class="col-sm-4">
                <div class="thumbnail">
                    <img src="paris.jpg" alt="Paris"/>
                    <p><strong>Paris</strong></p>
                    <p>Yes, we built Paris</p>
                </div>
            </div>
        <div class="col-sm-4">
            <div class="thumbnail">
                <img src="newyork.jpg" alt="New York"/>
                <p><strong>New York</strong></p>
                <p>We built New York</p>
            </div>
        </div>
        <div class="col-sm-4">
            <div class="thumbnail">
                <img src="sanfran.jpg" alt="San Francisco"/>
                <p><strong>San Francisco</strong></p>
                <p>Yes, San Fran is ours</p>
            </div>
        </div>
        </div>
    </div>
</asp:Content>

