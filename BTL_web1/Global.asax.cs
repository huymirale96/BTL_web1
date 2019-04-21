using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_web1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // // Application("SoNguoiOnline") = 0;
            //  Application("LuotNguoiGheTham") = 0;
            Application["OnlineUsers"] = 0;
            Application["soLanTham"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            TaiKhoan tk = new TaiKhoan();
            tk.setTaiKhoan("admin");
            tk.setMatKhau("admin");
            list.Add(tk);
            Session["danhSachTK"] = list;//new List<TaiKhoan>();
            Session["ten"] = new List<String>();
            //Session["soLanDn"] = 0;
            Session["danhSachCacTrang"] = "";


            //int x11 = (int)Application["soLanTham"];
            //Application["soLanTham"] = x11 + 1;

            /*{
                int count_visit = 0;
                //Kiểm tra file count_visit.txt nếu không tồn  tại
                if (System.IO.File.Exists(Server.MapPath("count_visit.txt")) == false)
                {
                    count_visit = 1;
                }
                
                else
                {
                   
                    System.IO.StreamReader read = new System.IO.StreamReader(Server.MapPath("count_visit.txt"));
                    count_visit = int.Parse(read.ReadLine());
                    read.Close();
                    // Tăng biến count lên
                   // count_visit = 0;
                    count_visit++;
                }
               
                Application.Lock();

                Application["count_visit"] = count_visit;

                Application.UnLock();

                // Lưu dử liệu vào file 
                System.IO.StreamWriter writer = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
                writer.WriteLine(count_visit);
                writer.Close();
            }

            Application.Lock();
            Application["OnlineUsers"] = (int)Application["OnlineUsers"] + 1;
            Application.UnLock();
        }

           
        //Cách dùng: Cho thẻ này vào html : Số lượt truy cập: <%=Aplication["count_visit"].toString()%>*/
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineUsers"] = (int)Application["OnlineUsers"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}