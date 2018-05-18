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
        private List<SalesLine> salesOrderLines;
        protected void Page_Load(object sender, EventArgs e)
        {
            //BoundField bound = new BoundField();
            //bound.DataField = "Doc Type";
            //bound.HeaderText = "Doc Type";
            //bound.SortExpression = "Doc Type";
            //gdvSalesOrder.Columns.Add(bound);
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
                        gdvSalesOrder.DataSource = searchResults.SalesHeader;
                        gdvSalesOrder.DataBind();

                        gdvSalesLine.DataSource = searchResults.SalesLine;
                        gdvSalesLine.DataBind();
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