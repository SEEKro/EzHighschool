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
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
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
                Debug.WriteLine("getPassoword with #Functie: " + functie + " #User: " + user);
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
            catch (SqlException ex)
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
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }

        [WebMethod]
        public virtual DataSet getGrades()
        {
            try
            {
                Debug.WriteLine("getGrades");
                SqlCommand getAllGradesCommand = new SqlCommand("GetAllGrades", con);
                DataSet gradesDataSet = new DataSet();
                SqlDataAdapter gradesAdapter;
                getAllGradesCommand.CommandType = CommandType.StoredProcedure;
                gradesAdapter = new SqlDataAdapter(getAllGradesCommand);
                gradesAdapter.Fill(gradesDataSet);
                return gradesDataSet;
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }

        [WebMethod(MessageName = "With parametter")]
        public virtual DataSet getGrades(string user)
        {
            try
            {
                Debug.WriteLine("getGrades");
                SqlCommand getAllGradesCommand = new SqlCommand("GetAllGradesByUser", con);
                DataSet gradesDataSet = new DataSet();
                SqlDataAdapter gradesAdapter;
                getAllGradesCommand.CommandType = CommandType.StoredProcedure;
                getAllGradesCommand.Parameters.AddWithValue("@username", user);
                gradesAdapter = new SqlDataAdapter(getAllGradesCommand);
                gradesAdapter.Fill(gradesDataSet);
                return gradesDataSet;
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }

        [WebMethod]
        public DataSet getAbsenteByUser(string user)
        {
            try
            {
                SqlCommand getAbsenteByUserCommand = new SqlCommand("GetAbesnteByUser", con);
                DataSet abesenteDataSet = new DataSet();
                SqlDataAdapter absenteAdapter;
                getAbsenteByUserCommand.CommandType = CommandType.StoredProcedure;
                getAbsenteByUserCommand.Parameters.AddWithValue("@username", user);
                absenteAdapter = new SqlDataAdapter(getAbsenteByUserCommand);
                absenteAdapter.Fill(abesenteDataSet);
                return abesenteDataSet;
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }

            return null;
        }

        [WebMethod]
        public int insertGrade(string user_profesor, string user_elev, string nume_materie, int nota, string data)
        {
            try
            {
                SqlCommand insertGradeCommand = new SqlCommand("InsertGrade", con);
                insertGradeCommand.CommandType = CommandType.StoredProcedure;
                insertGradeCommand.Parameters.AddWithValue("@user_elev", user_elev);
                insertGradeCommand.Parameters.AddWithValue("@user_profesor", user_profesor);
                insertGradeCommand.Parameters.AddWithValue("@nota", nota);
                insertGradeCommand.Parameters.AddWithValue("@data", data);
                insertGradeCommand.Parameters.AddWithValue("@nume_materie", nume_materie);
                return insertGradeCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }

            return 0;
        }

        [WebMethod]
        public int insertAbsenta(string user_elev, string nume_materie, string data)
        {
            try
            {
                SqlCommand insertAbsenta = new SqlCommand("InsertAbsenta", con);
                insertAbsenta.CommandType = CommandType.StoredProcedure;
                insertAbsenta.Parameters.AddWithValue("@user_elev", user_elev);
                insertAbsenta.Parameters.AddWithValue("@nume_materie", nume_materie);
                insertAbsenta.Parameters.AddWithValue("@data", data);
                return insertAbsenta.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }

            return 0;
        }

        [WebMethod]
        public int motivateAbsenta(int id_absenta)
        {
            try
            {
                SqlCommand motivateAbsenta = new SqlCommand("MotivateAbsenta", con);
                motivateAbsenta.CommandType = CommandType.StoredProcedure;
                motivateAbsenta.Parameters.AddWithValue("@id_absenta", id_absenta);
                return motivateAbsenta.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }

            return 0;
        }

        [WebMethod]
        public DataSet getMateriiByProfUser(string user_profesor)
        {
            try
            {
                SqlCommand getMateriiByUserCommand = new SqlCommand("GetMateriiByUser", con);
                DataSet materiiDataSet = new DataSet();
                SqlDataAdapter absenteAdapter;
                getMateriiByUserCommand.CommandType = CommandType.StoredProcedure;
                getMateriiByUserCommand.Parameters.AddWithValue("@user_profesor", user_profesor);
                absenteAdapter = new SqlDataAdapter(getMateriiByUserCommand);
                absenteAdapter.Fill(materiiDataSet);
                return materiiDataSet;
            }
            catch (SqlException ex)
            {
                string exception = ex.GetType().ToString();
            }
            return null;
        }
    }
}
