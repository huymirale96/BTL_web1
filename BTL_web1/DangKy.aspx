<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BTL_web1.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div id="main">
         
        <span>Tài khoản </span>
        <asp:TextBox ID="txtDDN" runat="server"></asp:TextBox>
          
        <asp:Label ID="ErroTK" runat="server" ForeColor="Red" Text="Nhập tài khoản !!!" Visible="False"></asp:Label>
          
        <br>
        <br>

      
        <span >Mật Khẩu </span>
     <asp:TextBox ID="txtMK" runat="server"></asp:TextBox>
        
        <asp:Label ID="ErroMK" runat="server" ForeColor="Red" Text="Nhập Mật Khẩu" Visible="False"></asp:Label>
        
      <br>
        <br>
        <span >Nhập Lại Mật Khẩu </span>
        <asp:TextBox ID="txtMK2" runat="server"></asp:TextBox>
          
       
        <asp:Label ID="ErroMK2" runat="server" ForeColor="Red" Text="Nhập Mật Khẩu" Visible="False"></asp:Label>
          
       
        <br>
        <br>
        <div id="nut">
             
           <asp:Button ID="btnDK" runat="server" Text="Đăng ký" CssClass="btn" OnClick="btnDKKK_Click"  />
           <asp:Button ID="btnHuy" runat="server" Text="Hủy" CssClass="btn" />
        </div>
        </div>
       
</asp:Content>
