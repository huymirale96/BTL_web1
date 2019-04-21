<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="TaiKhoan.aspx.cs" Inherits="BTL_web1.TaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login" style="height:470px">
        <div class="login-triangle"></div>

        <h2 class="login-header" >Welcome to VSSG</h2>

        <form class="login-container">
            <p> <asp:Label ID="txtXN" runat="server"></asp:Label></p>
             <p><asp:Button ID="btnThoat" runat="server" CssClass="button" OnClick="btnThoat_Click" Text="EXIT" /></p>
        </form>

    </div>
</asp:Content>