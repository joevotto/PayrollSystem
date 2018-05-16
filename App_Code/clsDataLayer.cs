using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// These using statements declare that I am using Database classes in this application
using System.Data.OleDb;
using System.Net;
using System.Data;
/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // These lines declare a new datastore as well as connection and adapter
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // This declares a new SQL connection 
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // This declares a new data adapter and it selects all from userActivity tbl
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        // This declares a new userActivity object
        DS = new dsUserActivity();

        // This uses the dataadapter to fill the userActivity tbl
        sqlDA.Fill(DS.tblUserActivity);

        // This returns the userActivity datastore information
        return DS;
    }

    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // This declares a new database connection as well as opening it and setting commands
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
                    Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }
    public clsDataLayer()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
                                     string PayRate, string StartDate, string EndDate)
    {

        bool recordSaved;
        //This declares a new transaction 
        OleDbTransaction myTransaction = null;
        try
        {
            //This line creates a connection to the DB for the tblPersonnel
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //This opens a connection and prepares it for the transaction
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";
            // These lines define that the command entered will be saved into a strSQL variable
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // This line tells it to execute a non query
            command.ExecuteNonQuery();

            // These are update statements to be used in the grid
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";

            // This tells the program that the commands will be SQL strings
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // This tells the program to execute a nonquery
            command.ExecuteNonQuery();

            //This commits and saves the information entered into the DB
            myTransaction.Commit();

            // This closes the connection to the DB
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            //This undos the changes incase of errors
            myTransaction.Rollback();

            recordSaved = false;

        }

        return recordSaved;
    }

    // This function gets the user activity from the tblPersonnel

    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //create the connection string
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
        "Data Source=" + Database);



        if (String.IsNullOrEmpty(strSearch) == true)
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }

        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where lastName = '" + strSearch + "'", sqlConn);
        }


        // Defines DS and what each will consist of
        DS = new dsPersonnel();

        // Outputs the results from the information gathered
        sqlDA.Fill(DS.tblPersonnel);

        // Starts over for a new user
        return DS;
    }
    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // This defines a new user for the DS, as well as connection and adapter
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // This defines a new connection
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                      "Data Source=" + Database);

        // This returns all fields in the Security level field of the table
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                      "where UserName like '" + UserName + "' " +
                                      "and UserPassword like '" + UserPassword + "'", sqlConn);

        // New user to store in the dataset
        DS = new dsUser();

        // This fills the fields in the userLogin table
        sqlDA.Fill(DS.tblUserLogin);

        // Add your comments here
        return DS;

    }
    public static bool SaveUser(string Database, string UserName, string userPassword, string SecurityLevel)
    {
        bool recordSaved;

        try
        {
            //This line creates a connection to the DB for the tblPersonnel
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            // This inserts the information entered into the DB
            strSQL = "Insert into tblUserLogin " +
                     "(UserName, UserPassword, SecurityLevel, StartDate, EndDate) values ('" +
                     UserName + "', '" + userPassword + "', " + SecurityLevel + "')";
            // These lines define that the command entered will be saved into a strSQL variable
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // This line tells it to execute a non query
            command.ExecuteNonQuery();
            // This closes the connection to the DB
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            recordSaved = false;

        }

        return recordSaved;
    }
}