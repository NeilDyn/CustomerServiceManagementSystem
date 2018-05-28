using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Codeunit;
using WebApplication.Class_Objects;
using System.Data;

namespace WebApplication
{
    public partial class TestForm : System.Web.UI.Page
    {
        private WebService webService;
        private SearchResults searchResults;

        private string[] channel;

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

                    if (searchResults == null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "XML port returned null value" + "');", true);

                        searchResults = new SearchResults();
                    }
                    else
                    {
                        channel = searchResults.TestAddress[0].Channel;

                        string[] split = channel[0].Split(';');
                        txtSellToCustomerNo.Text = split[0];
                        txtSellToCustomerName.Text = split[1];
                        txtOrderDate.Text = split[2];
                        txtShipToName.Text = split[3];
                        txtShipToAddress.Text = split[4];
                        txtShipToCity.Text = split[5];
                    }
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No records found." + "');", true);
                searchResults = new SearchResults();
            }
         
            gdvSalesOrder.DataSource = searchResults.SalesHeader;
            gdvSalesLine.DataSource = searchResults.SalesLine;
            gdvShipmentHeader.DataSource = searchResults.SalesShipmentHeader;
            gdvShipmentLines.DataSource = searchResults.SalesShipmentLine;
            gdvPostedPackage.DataSource = searchResults.PostedPackage;
            gdvPackageLine.DataSource = searchResults.PostedPackageLine;
            gdvReturnReceiptHeader.DataSource = searchResults.ReturnReceiptHeader;
            gdvReturnReceiptLines.DataSource = searchResults.ReturnReceiptLine;
            gdvPostedReceive.DataSource = searchResults.PostedReceive;
            gdvPostedReceiveLines.DataSource = searchResults.PostedReceiveLine;
            gdvCreditMemoHeader.DataSource = searchResults.SalesCreditMemo;
            gdvCreditMemoLines.DataSource = searchResults.SalesCreditMemoLines;
            gdvInvoiceHeader.DataSource = searchResults.SalesInvoiceHeader;
            gdvInvoiceLines.DataSource = searchResults.SalesInvoiceLine;

            gdvSalesOrder.DataBind();
            gdvSalesLine.DataBind();
            gdvShipmentHeader.DataBind();
            gdvShipmentLines.DataBind();
            gdvPostedPackage.DataBind();
            gdvPackageLine.DataBind();
            gdvReturnReceiptHeader.DataBind();
            gdvReturnReceiptLines.DataBind();
            gdvPostedReceive.DataBind();
            gdvPostedReceiveLines.DataBind();
            gdvCreditMemoHeader.DataBind();
            gdvCreditMemoLines.DataBind();
            gdvInvoiceHeader.DataBind();
            gdvInvoiceLines.DataBind();
        }

    }
}