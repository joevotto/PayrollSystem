using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
         // This line defines a login using the datastore
        dsUser dsUserLogin;

        // This variable holds the value of the A or U in the dropdown list
        string SecurityLevel;

        // This is used to store the information stored in the DB to login
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"),
                         Login1.UserName, Login1.Password);

        // this is an if statement, if the count is less than 1 it returns false
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            // These lines declare emails that the system will send
            if (clsBusinessLayer.SendEmail("joseph1@yahoo.com",
            "websterrip@hotmail.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            { 

                Login1.FailureText = Login1.FailureText +
" Your incorrect login information was sent to webmaster@coolbizpro.com";

            }
            return;
        }

        // This gets the text from the dropdown menu and stores it as a string
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        // this is a switch statement checking for the security level selected
        switch (SecurityLevel)
        {
                 case "A":
                // this returns the level as admin
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";

                break;
            case "U":
                // this returns the level as user
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
                 }
        }
} 