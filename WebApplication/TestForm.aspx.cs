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

        protected void gdvSalesOrder_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GridView salesLine = e.Row.FindControl("gdvSalesLines") as GridView;
                salesOrderLines = new List<SalesLine>();

                if (e.Row.RowIndex == 0)
                {
                    salesLine.ShowHeader = true;
                }
                else
                {
                    salesLine.ShowHeader = false;
                }

                foreach (SalesLine line in searchResults.SalesHeader[e.Row.RowIndex].SalesLine)
	            {
                    salesOrderLines.Add(line);
	            }

                salesLine.DataSource = salesOrderLines;
                salesLine.DataBind();
            }
        }
    }
}