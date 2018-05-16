using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    Double annHours;
    Double payRate;
    Double totalAmt;
    String yearlyHours;
    String rateOfPay;
    String totalAmtString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void subBtn_Click(object sender, EventArgs e)
    {
        yearlyHours = txtAnnualHours.Text;
        rateOfPay = txtRate.Text;
        annHours = Convert.ToDouble(yearlyHours);
        payRate = Convert.ToDouble(rateOfPay);
        totalAmt = annHours * payRate;
        totalAmtString = Convert.ToString(totalAmt);
        totalAmount.Text = totalAmtString;
    }
}