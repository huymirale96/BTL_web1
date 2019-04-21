using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class Login : System.Web.UI.Page
    {
        List<TaiKhoan> danhSachTK;
        List<String> tenhienthi;
        List<String> x;
        String ten = "";
        //int soLan = (int) Session["soLanDn"];
        protected void Page_Load(object sender, EventArgs e)
        {
            x = (List<String>)Session["ten"];
            int x3 = (int)Session["soLanDn"];
            for (int i = 0; i < x.Count; ++i)
            {
                ten = x[x.Count - 1];
            }
            if (ten != "")
            {
                
                Response.Redirect("TaiKhoan.aspx");
            }

            string username = Request.Form["username"];
            string password = Request.Form["password"];
            tenhienthi = new List<string>();
            if (Request.Form["submit"] == "LOGIN")
            {
                Boolean kt = kiemtratk();
                if (Request.Form["username"] == "")
                {
                    lbError.Text = "USERNAME IS EMPTY!!!!";
                }
                else if (Request.Form["password"] == "")
                {
                    lbError.Text = "PASSWORD IS EMPTY!!!!";
                }
                else if (kt == true)
                {
                    Session["soLanDn"] = x3 + 1;
                    tenhienthi.Add(username);
                    Session["ten"] = tenhienthi;
                    Response.Redirect("DangNhap.aspx");
                    
                }
                else
                {
                    lbError.Text = "USERNAME OR PASSWORD IS WRONG!!!!";
                }

            }
        }
        Boolean kiemtratk()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            danhSachTK = (List<TaiKhoan>)Session["danhSachTK"];
            Boolean kt = false;
            for (int i = 0; i < danhSachTK.Count; ++i)
            {
                var data = danhSachTK[i];
                if (data.taiKhoan.Equals(username) && data.MatKhau.Equals(password))
                {
                    kt = true;
                    break;
                }
                else
                {
                    kt = false;

                }
            }
            return kt;
        }
        public String tentk()
        {
            string username = Request.Form["username"];
            Boolean kt = kiemtratk();
            if (kt == true)
            {
                return username;
            }
            else
            {
                return "";
            }
        }

        protected void btnDK_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}