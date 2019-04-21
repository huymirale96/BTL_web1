using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class DangNhap : System.Web.UI.Page
    {
        List<TaiKhoan> danhSachTK;
        List<String> tenhienthi;
        List<String> x;
        String ten = "";

        /* TextBox txtTK = FindControl("txtTK");
          TextBox txtMK = Page.FindControl("txtMK") as TextBox;

          Label ErroTK = Page.FindControl("ErroTK") as Label;
          Label ErroMK = Page.FindControl("ErroMK") as Label;
          Label Erro = Page.FindControl("Erro") as Label;*/
        protected void Page_Load(object sender, EventArgs e)
        {
            x = (List<String>)Session["ten"];
            for (int i = 0; i < x.Count; ++i)
            {
                ten = x[x.Count - 1];
            }
            if (ten != "")
            {
                Response.Redirect("TaiKhoan.aspx");
            }


        }


        protected void btnDN_Click(object sender, EventArgs e)
        {

            tenhienthi = new List<string>();
            TextBox txtTK = (TextBox)Page.FindControl("txtTk");
            TextBox txtMK = (TextBox)Page.FindControl("txtMk");
            String tk = txtTK.Text;
            String mk = txtMK.Text;
            Boolean kt = kiemtratk();



            if (tk.Equals(""))
            {
                Label ErroTK = (Label)Page.FindControl("ErroTK");
                Label ErroMK = (Label)Page.FindControl("ErroMK");
                Label Erro = (Label)Page.FindControl("Erro");

                ErroTK.Visible = true;
                ErroMK.Visible = false;
                Erro.Visible = false;
            }
            else if (mk.Equals(""))
            {
                Label ErroTK = (Label)Page.FindControl("ErroTK");
                Label ErroMK = (Label)Page.FindControl("ErroMK");
                Label Erro = (Label)Page.FindControl("Erro");
                ErroTK.Visible = false;
                ErroMK.Visible = true;
                Erro.Visible = false;
            }
            else if (kt == false)
            {
                Label ErroTK = (Label)Page.FindControl("ErroTK");
                Label ErroMK = (Label)Page.FindControl("ErroMK");
                Label Erro = (Label)Page.FindControl("Erro");
                ErroTK.Visible = false;
                ErroMK.Visible = false;
                Erro.Visible = true;
            }
            else
            {
                tenhienthi.Add(tk);
                Session["ten"] = tenhienthi;
                Response.Redirect("DangNhap.aspx");
            }

        }
        Boolean kiemtratk()
        {
            TextBox txtTK = (TextBox)Page.FindControl("txtTk");
            TextBox txtMK = (TextBox)Page.FindControl("txtMk");
            String tk = txtTK.Text;
            String mk = txtMK.Text;
            danhSachTK = (List<TaiKhoan>)Session["danhSachTK"];
            Boolean kt = false;
            for (int i = 0; i < danhSachTK.Count; ++i)
            {
                var data = danhSachTK[i];
                if (data.taiKhoan.Equals(tk) && data.MatKhau.Equals(mk))
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
            TextBox txtTK = (TextBox)Page.FindControl("txtTk");
            TextBox txtMK = (TextBox)Page.FindControl("txtMk");
            Boolean kt = kiemtratk();
            if (kt == true)
            {
                return txtTK.Text;
            }
            else
            {
                return "";
            }
        }
        protected void btnDK_Click(object sender, EventArgs e)
        {
            Response.Redirect("DangKy.aspx");

        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}