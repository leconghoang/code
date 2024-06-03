using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ktracuoiki
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        LopKetNoi ketNoi=new LopKetNoi();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;

            }
            string sql = "select * from LOAITHIETBI ";
            DLLOAI.DataSource = ketNoi.DocDuLieu(sql);
            DLLOAI.DataBind(); 
        }
    }
}