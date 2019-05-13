using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services;

namespace WebAppEzHighSchool
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private const String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                                  AttachDbFilename=|DataDirectory|\Database1.mdf;
                                                  Integrated Security=True";

        private SqlConnection con = new SqlConnection();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public WebService()
        {
            try
            {
                con.ConnectionString = connectionString;
                con.Open();
                AllocConsole();
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
        }
       
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet getPassword(string functie, string user)
        {
            try
            {
                Debug.WriteLine("getPassoword with #Functie: " + functie + " #User: "+ user);
                SqlCommand getPasswordCommand = new SqlCommand("GetPassword", con);
                DataSet passwordDataSet = new DataSet();
                SqlDataAdapter passowrdAdapter;
                getPasswordCommand.CommandType = CommandType.StoredProcedure;
                getPasswordCommand.Parameters.AddWithValue("@functie", functie);
                getPasswordCommand.Parameters.AddWithValue("@username", user);
                passowrdAdapter = new SqlDataAdapter(getPasswordCommand);
                passowrdAdapter.Fill(passwordDataSet);
                return passwordDataSet;
            }
            catch(SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }

        [WebMethod]
        public DataSet getPersonalInfo(string functie, string user)
        {
            try
            {
                Debug.WriteLine("getPersonalInfo with #Functie: " + functie + " #User: " + user);
                SqlCommand getInfoCommand = new SqlCommand("GetPersonalInfo", con);
                DataSet infoDataSet = new DataSet();
                SqlDataAdapter passowrdAdapter;
                getInfoCommand.CommandType = CommandType.StoredProcedure;
                getInfoCommand.Parameters.AddWithValue("@functie", functie);
                getInfoCommand.Parameters.AddWithValue("@username", user);
                passowrdAdapter = new SqlDataAdapter(getInfoCommand);
                passowrdAdapter.Fill(infoDataSet);
                return infoDataSet;
            }
            catch(SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }
    }
}
