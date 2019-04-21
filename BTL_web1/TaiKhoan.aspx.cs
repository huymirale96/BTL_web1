using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class TaiKhoan : System.Web.UI.Page
    {
      
        String ten = "";
        List<String> x;
        protected void Page_Load(object sender, EventArgs e)
        {
            x = (List<String>)Session["ten"];
            for (int i = 0; i < x.Count; ++i)
            {
                ten = x[x.Count - 1];
            }

            txtXN.Text = "WELCOM " + ten;
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            x = (List<String>)Session["ten"];

            for (int i = 0; i < x.Count; ++i)
            {
                ten = x[x.Count - 1];
                x.Remove(ten);
            }
            Session["ten"] = x;
            Response.Redirect("Login.aspx");
        }
    }
}