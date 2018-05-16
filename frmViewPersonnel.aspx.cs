using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            
            string strSearch = Convert.ToString( Request["txtSearchName"]);

            //Declare the DataSet
            dsPersonnel myDateSet = new dsPersonnel();


            myDateSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strSearch);

            //Set the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDateSet;

            //Bind the DataSet
            grdViewPersonnel.DataBind();
        }
    }



    protected void grdViewPersonnel_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
