using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // This saves the employee information into the database
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");

        if (Session["SecurityLevel"] != "U")
        {
            btnAddEmp.Visible=true;
            imgBtnNewEmployee.Visible = true;
            lblBtnUserActivity.Visible = true;
            imgBtnUserActivity.Visible = true;
            btnManageUsers.Visible = true;
            imgManageUsers.Visible = true;
        }

    }

}