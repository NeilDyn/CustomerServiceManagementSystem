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
        enum ObjectList
        {
            SalesHeader,
            SalesLine,
            ShipmentHdr,
            ShipmentLine,
            Package,
            PackageLine,
            SOImportBuffer
        }
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
            int idCount = 0;
            bool finishload = false;

            do
            {
                GridView gv = new GridView();
                gv.ID = "gv" + idCount;
                ObjectList oj = (ObjectList)idCount;
                idCount++;

                switch (oj)
                {
                    case ObjectList.SalesHeader:
                        if (sr.SalesHeader != null)
                        {
                            gv.DataSource = sr.SalesHeader;
                        }
                        break;
                    case ObjectList.SalesLine:
                        if (sr.SalesLine != null)
                        {
                            gv.DataSource = sr.SalesLine;
                        }
                        break;
                    case ObjectList.ShipmentHdr:
                        if (sr.SalesShipmentHeader != null)
                        {
                            gv.DataSource = sr.SalesShipmentHeader;
                        }
                        break;
                    case ObjectList.ShipmentLine:
                        if (sr.SalesShipmentLine != null)
                        {
                            gv.DataSource = sr.SalesShipmentLine;
                        }
                        break;
                    case ObjectList.Package:
                        if (sr.PostedPackage != null)
                        {
                            gv.DataSource = sr.PostedPackage;

                        }
                        break;
                    case ObjectList.PackageLine:
                        if (sr.PostedPackageLine != null)
                        {
                            gv.DataSource = sr.PostedPackageLine;
                        }
                        break;
                    case ObjectList.SOImportBuffer:
                        if (sr.SOImportBuffer != null)
                        {
                            gv.DataSource = sr.SOImportBuffer;
                        }
                        break;
                    default:
                        finishload = true;
                        break;
                }

                gv.DataBind();
                gridList.Add(gv);
            } while (!finishload);

            foreach (GridView item in gridList)
            {
                form1.Controls.Add(item);
            }
            //form1.Controls.Add(gv);
            

            
        }

        //static void ErrorText(string err)
        //{
        //    ClientScriptManager csm = new ClientScriptManager();
        //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + e.Message + "');", true);
        //}

    }
}