using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
public partial class frmPersonalVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //These lines of code request the information passed from frmPersonnel and use it to fill the fields

        txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
            "\n" + Session["txtLastName"].ToString() +
            "\n" + Session["txtPayRate"].ToString() +
            "\n" + Session["txtStartDate"].ToString() +
            "\n" + Session["txtEndDate"].ToString();

        // This code tests if the information was entered correctly to the form
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"),
                                       Session["txtFirstName"].ToString(),
         Session["txtLastName"].ToString(),
               Session["txtPayRate"].ToString(),
         Session["txtStartDate"].ToString(),
         Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                                  "\nThe information was successfully saved!";

        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                                 "\nThe information was NOT saved.";
        }
    }
}