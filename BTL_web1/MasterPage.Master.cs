using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_web1
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // dst.Text = Session["danhSachCacTrang"].ToString();   <p> <asp:Label ID="dst" runat="server"></asp:Label></p>
        }
    }
}