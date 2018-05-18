using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Class_Objects;
using WebApplication.Codeunit;

namespace WebApplication
{
    public partial class SomeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch1_Click(object sender, EventArgs e)
        {
            WebService ws = new WebService();

            if (txtSearch.Text == "")
            {
                return;
            }
            SearchResults sr = ws.FindOrder(txtSearch.Text);
            List<GridView> gridList = new List<GridView>();

            GridView gv = new GridView();
            gv.DataSource = sr.SalesHeader;
            gv.DataBind();
            form1.Controls.Add(gv);

            
        }

        //static void ErrorText(string err)
        //{
        //    ClientScriptManager csm = new ClientScriptManager();
        //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + e.Message + "');", true);
        //}

    }
}