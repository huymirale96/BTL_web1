using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_web1
{
    public partial class TaiKhoan
    {
        public String taiKhoan;
       public String MatKhau;

        public string getTaikhoan()
        {
            //get => taiKhoan; set => taiKhoan = value;
            return taiKhoan;
        }
        public void setTaiKhoan(string taikhoan)
        {
            taiKhoan = taikhoan;
        }
        public string getMatkhau()
        {
            //get => MatKhau; set => MatKhau = value; }
            return MatKhau;
        }
        public void setMatKhau(string matkhau)
        {
            MatKhau = matkhau;
        }
    }
}