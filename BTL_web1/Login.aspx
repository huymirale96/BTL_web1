<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" enableEventValidation="false" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BTL_web1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login" style="height:470px">
        <div class="login-triangle"></div>

        <h2 class="login-header" >Welcome to VSSG</h2>

        <form class="login-container" method="post" onsubmit="return ktra()">
            <p><input type="text" placeholder="Username" name="username" id="username"/></p>
            <p><input type="password" placeholder="Password" name="password" id="password"/></p>
        
            <p><button type="submit" value="LOGIN" id="submit" name="submit">LOGIN</button></p>
          
           <p>  <asp:Button ID="btnDK" runat="server" Text="SIGN UP" CssClass="button" OnClick="btnDK_Click" OnClientClick="return alert1();" /></p>
            <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
            </form>


    </div>
</asp:Content>