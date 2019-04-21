<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BTL_web1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login" style="height:470px">
        <div class="login-triangle"></div>

        <h2 class="login-header" >SIGN UP</h2>

        <form class="login-container" action="Login.aspx" method="post">
            <p><input type="text" placeholder="Username" name="username" id="username"/></p>
            <p><input type="password" placeholder="Password" name="password" id="password"/></p>
            <p><input type="password" placeholder="Confirm password" name="password2" id="password2"/></p>
            <p><button type="submit" value="SIGN UP" id="submit" name="submit">SIGN UP</button></p>
            <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
        </form>

    </div>
</asp:Content>
