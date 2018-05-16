using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// **** Add the following at the top of the class file
//This line declares we are using the .Net Mail framework
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    //**** Add the following code inside the body of public class clsBusinessLayer ****

    public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
    string Subject, string Body)
    {
        try
        {

            // This declares a new MailMessage object
            MailMessage MyMailMessage = new MailMessage();

            // This declares a new MailMessage Sender
            MyMailMessage.From = new MailAddress(Sender);

            // This declares a new MailMessage Recipient
            MyMailMessage.To.Add(new MailAddress(Recipient));

            // This if statement checks for non empty string fields
            if (bcc != null && bcc != string.Empty)
            {
                // This sets the MailMessage to send a bcc of the message
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }

            // This checks for non empty string fields
            if (cc != null && cc != string.Empty)
            {
                // This sets the MailMessage to send a cc of the message
                MyMailMessage.CC.Add(new MailAddress(cc));
            }

            // This sets the subject line of the message
            MyMailMessage.Subject = Subject;

            // This sets the message body
            MyMailMessage.Body = Body;

            // This declares that the body will include HTML
            MyMailMessage.IsBodyHtml = true;

            // This delcares that the priority of the email is normal
            MyMailMessage.Priority = MailPriority.Normal;

            // This declares a new SmptpClient
            SmtpClient MySmtpClient = new SmtpClient();

            //These lines declare a port for the email as well as an IP
            MySmtpClient.Port = 25;
            MySmtpClient.Host = "127.0.0.1";

            // This sends the previously defined message
            MySmtpClient.Send(MyMailMessage);

            // This returns true if the message was sent
            return true;
        }
        catch (Exception ex)
        {

            // This is called if there are no exceptions
            return false;
        }

    }
	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}