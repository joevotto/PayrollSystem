using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmAddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        //These lines check if the fields are correctly matched
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.mdb"),
            txtUser.Text, txtPass.Text, comboSecurityLevel.SelectedValue))
        {
            //This is returned if the match is correct
            lblErrorMessage.Text = "User Successfully Added!";
            GridView1.DataBind();
        }
        else
        {
            //this is returned if the match is incorrect
            lblErrorMessage.Text = "User Not Added!";
        }
    }
}