using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Codeunit;
using WebApplication.Class_Objects;

namespace WebApplication
{
    public partial class TestForm : System.Web.UI.Page
    {
        private WebService webService;
        private SearchResults searchResults;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchNo.Text;

            if (searchValue != null && !string.IsNullOrWhiteSpace(searchValue))
            {
                webService = new WebService();

                try
                {
                    searchResults = new SearchResults();
                    searchResults = webService.FindOrder(searchValue);

                    if (searchResults != null)
                    {
                        gdvOrder.DataSource = searchResults;
                        gdvOrder.DataBind();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "XML port returned null value" + "');", true);
                    }
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                }                        
            }
        }
    }
}