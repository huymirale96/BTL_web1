<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangNhap1.aspx.cs" Inherits="BTL_web1.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="main">
         <span>Tài khoản </span>
          
          <asp:TextBox CssClass="txtDN" ID="txtTK" runat="server"></asp:TextBox>
          
          
         
          <asp:Label ID="ErroTK" runat="server" ForeColor="Red" Text="Nhập tên tài khoản !!!" Visible="False"></asp:Label>
          
          
         
        <br>
        <br>

        <div >Mật Khẩu </div>
          <div>
        <asp:TextBox CssClass="txtDN" ID="txtMK" runat="server"></asp:TextBox>
          <asp:Label ID="ErroMK" runat="server" ForeColor="Red" Text="Nhập Mật Khẩu!!!!" Visible="False"></asp:Label>
          <br />
          <br />
          <asp:Label ID="Erro" runat="server" ForeColor="Red" Text="Sai Tài Khoản hoặc Mật Khẩu" Visible="False"></asp:Label>
       </div>
        <br>
        <br>
        <div id="nut">
             <asp:Button ID="btnDN" runat="server" Text="Đăng nhập" CssClass="btn" OnClick="btnDN_Click" />
           <asp:Button ID="btnDK" runat="server" Text="Đăng ký" CssClass="btn" OnClick="btnDK_Click" />
           <asp:Button ID="btnHuy" runat="server" Text="Hủy" CssClass="btn" OnClick="btnHuy_Click" />
        </div>
        </div>
</asp:Content>