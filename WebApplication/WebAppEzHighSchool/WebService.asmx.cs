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
                Debug.WriteLine("Functie: " + functie + " User: "+ user);
                SqlCommand getPasswordCommand = new SqlCommand("GetPassword", con);
                getPasswordCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter passowrdAdapter;
                DataSet passwordDataSet = new DataSet();
                getPasswordCommand.Parameters.AddWithValue("@functie", functie);
                getPasswordCommand.Parameters.AddWithValue("@user", user);
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
    }
}
