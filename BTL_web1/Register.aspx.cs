using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class Register : System.Web.UI.Page
    {
        List<TaiKhoan> danhsachTK;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string password2 = Request.Form["password2"];
            danhsachTK = (List<TaiKhoan>)Session["danhsachTK"];
            if (Request.Form["submit"] == "SIGN UP")
            {
                if (Request.Form["username"] == "")
                {
                    lbError.Text = "USERNAME IS EMPTY!!!!";
                }
                else if (Request.Form["password"] == "")
                {
                    lbError.Text = "PASSWORD IS EMPTY!!!!";
                }
                else if (Request.Form["password2"] == "")
                {
                    lbError.Text = "CONFIRM PASSWORD IS EMPTY!!!!";
                }
                else if (Request.Form["password"] != Request.Form["password2"])
                {
                    lbError.Text = "CONFIRM PASSWORD IS WRONG!!!!";
                }
                else
                {
                    TaiKhoan nv = new TaiKhoan();
                    nv.setTaiKhoan(Request.Form["username"]);
                    nv.MatKhau = Request.Form["password"];

                    danhsachTK.Add(nv);
                    Session["danhsachTK"] = danhsachTK;
                    Response.Redirect("Login.aspx");
                }


            }
        }
    }
}
