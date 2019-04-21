using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class DangKy : System.Web.UI.Page
    {
        List<TaiKhoan> danhsachTK;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDKKK_Click(object sender, EventArgs e)
        {
            danhsachTK = (List<TaiKhoan>)Session["danhsachTK"];

            String ten = txtDDN.Text;
            String mk = txtMK.Text;
            String mk2 = txtMK2.Text;
            if (txtDDN.Text.Equals(""))
            {
                ErroTK.Visible = true;
                ErroMK2.Visible = false;
                ErroMK.Visible = false;
            }
            else if (txtMK.Text.Equals(""))
            {
                ErroMK.Visible = true;
                ErroTK.Visible = false;
                ErroMK2.Visible = false;
            }
            else if (txtMK2.Text.Equals(""))
            {
                ErroMK2.Visible = true;
                ErroMK.Visible = false;
                ErroTK.Visible = false;
            }
            else if (txtMK2.Text.Equals(txtMK.Text) == false)
            {
                ErroMK2.Text = "Nhập lại mật khẩu sai";
                ErroMK2.Visible = true;
            }
            else
            {
                TaiKhoan nv = new TaiKhoan();
                nv.taiKhoan = ten;
                nv.MatKhau = mk;

                danhsachTK.Add(nv);
                Session["danhsachTK"] = danhsachTK;
                Response.Redirect("DangNhap.aspx");
            }


        }
    }
}