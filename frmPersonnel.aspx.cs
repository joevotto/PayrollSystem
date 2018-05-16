using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Add your comments here
        if (Session["SecurityLevel"] == "A")
        {

            btnSubmit.Visible = true;

            //Add your comments here 
        }
        else
        {

            btnSubmit.Visible = false;

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string frstNameVal = txtFirstName.Text;
        string lstNameVal = txtLastName.Text;
        string payRateVal = txtPayRate.Text;
        string strtDateVal = txtStartDate.Text;
        string endDateVal = txtEndDate.Text;
        string errorMesssage = "";
        bool allOK = true;
        if (Request["txtFirstName"].ToString().Trim() == "")
        {
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            errorMesssage = errorMesssage + "First Name may not be empty.";
            allOK = false;
        }
        else
        {
            txtFirstName.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtLastName"].ToString().Trim() == "")
        {
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            errorMesssage = errorMesssage + "Last Name may not be empty.";
            allOK = false;
        }
        else
        {
            txtLastName.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtPayRate"].ToString().Trim() == "")
        {
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            errorMesssage = errorMesssage + "Pay Rate may not be empty.";
            allOK = false;
        }
        else
        {
            txtPayRate.BackColor = System.Drawing.Color.White;
        }
        try
        {
            DateTime.Parse(txtStartDate.Text);
        }
        catch
        {
            txtStartDate.Text = DateTime.Today.ToShortDateString();
        }
        if (Request["txtStartDate"].ToString().Trim() == "")
        {
     
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            errorMesssage = errorMesssage + "Start Date may not be empty.";
            allOK = false;
        }
        else
        {
            txtStartDate.BackColor = System.Drawing.Color.White;
        }
        try
        {
            DateTime.Parse(txtEndDate.Text);
        }
        catch
        {
            txtEndDate.Text = DateTime.Today.ToShortDateString();
        }

        if (Request["txtEndDate"].ToString().Trim() == "")
        {
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            errorMesssage = errorMesssage + "End Date may not be empty.";
            allOK = false;
        }
        else
        {
            txtEndDate.BackColor = System.Drawing.Color.White;
        }

        if (allOK)
        {
            DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
            DateTime endDate = DateTime.Parse(Request["txtEndDate"]);

            if (DateTime.Compare(startDate, endDate) > 0)
            {
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                errorMesssage = errorMesssage + "The end date must be a later date than the start date.";
                allOK = false;
            }
            else
            {
                txtStartDate.BackColor = System.Drawing.Color.White;
                txtEndDate.BackColor = System.Drawing.Color.White;
            }

        }

        if (allOK)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;
            Response.Redirect("frmPersonalVerified.aspx");  
        }
        else
        {
            lblError.Text = errorMesssage;  
        }
    }
}