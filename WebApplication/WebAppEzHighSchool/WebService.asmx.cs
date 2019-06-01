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

        private DataSet makeGetRequest(String procedureName, List<string> parametters, List<Object> effectiveParametters)
        {
            try
            {
                SqlCommand getCommand = new SqlCommand(procedureName, con);
                DataSet getDataSet = new DataSet();
                SqlDataAdapter getAdapter;
                getCommand.CommandType = CommandType.StoredProcedure;
                int index = 0;
                foreach(string parametter in parametters)
                {
                    getCommand.Parameters.AddWithValue(parametter, effectiveParametters.ElementAt(index));
                    index++;
                }
                getAdapter = new SqlDataAdapter(getCommand);
                getAdapter.Fill(getDataSet);
                return getDataSet;
            }
            catch(SqlException ex)
            {
                string err = ex.GetType().ToString();
            }
            return null;
        }

        private int makePostRequest(String procedureName, List<string> parametters, List<Object> effectiveParametters)
        {
            try
            {
                SqlCommand getCommand = new SqlCommand(procedureName, con);
                getCommand.CommandType = CommandType.StoredProcedure;
                int index = 0;
                foreach (string parametter in parametters)
                {
                    getCommand.Parameters.AddWithValue(parametter, effectiveParametters.ElementAt(index));
                    index++;
                }
                return getCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string err = ex.GetType().ToString();
            }
            return 0;
        }

        [WebMethod]
        public DataSet getPassword(string functie, string user)
        {
            return makeGetRequest("GetPassword", 
                                  new List<string>() { "@functie", "@username" },
                                  new List<Object>() { functie, user});
            }

        [WebMethod]
        public DataSet getPersonalInfo(string functie, string user)
        {
            return makeGetRequest("GetPersonalInfo",
                                  new List<string>() { "@functie", "@username" },
                                  new List<Object>() { functie, user });
        }

        [WebMethod]
        public DataSet getMaterii()
        {
            return makeGetRequest("GetMaterii",
                                  new List<string>() {},
                                  new List<Object>() {});
        }

        [WebMethod]
        public virtual DataSet getGrades()
        {
            return makeGetRequest("GetAllGrades",
                                  new List<string>() {},
                                  new List<Object>() {});
        }

        [WebMethod(MessageName = "With parametter")]
        public virtual DataSet getGradesByUser(string user)
        {
            return makeGetRequest("GetAllGradesByUser",
                                  new List<string>() { "@username" },
                                  new List<Object>() { user });
        }

        [WebMethod(MessageName = "With parametters")]
        public virtual DataSet getGradesByUserAndMaaterie(string user, string materie)
        {
            return makeGetRequest("GetAllGradesByUserAndMaterie",
                                  new List<string>() { "@username", "@materie" },
                                  new List<Object>() { user, materie });
        }

        [WebMethod]
        public DataSet getAbsente(string user)
        {
            return makeGetRequest("GetAbsente",
                                new List<string>() { "@username"},
                                new List<Object>() { user });
        }

        [WebMethod]
        public int insertGrade(string user_profesor, string user_elev, string nume_materie, int nota, string data)
        {
            return makePostRequest("InsertGrade",
                                  new List<string>() { "@user_elev", "@user_profesor", "@nota", "@data", "@nume_materie" },
                                  new List<Object>() { user_elev, user_profesor, nota, data, nume_materie });
        }

        [WebMethod]
        public int insertAbsenta(string user_elev, string nume_materie, string data)
        {
            return makePostRequest("InsertAbsenta",
                                     new List<string>() { "@user_elev", "@nume_materie", "@data" },
                                     new List<Object>() { user_elev, nume_materie, data });
        }

        [WebMethod]
        public int motivateAbsenta(int id_absenta)
        {
            return makePostRequest("MotivateAbsenta",
                                     new List<string>() { "@id_absenta" },
                                     new List<Object>() { id_absenta });
        }

        [WebMethod]
        public DataSet getMateriiByProfUser(string user_profesor)
        {
            return makeGetRequest("GetMateriiByUser",
                                  new List<string>() { "@user_profesor" },
                                  new List<Object>() { user_profesor });
        }

        [WebMethod]
        public DataSet getAbsenteByMaterie(string nume_materie, string user_elev)
        {
            return makeGetRequest("GetAbsenteByMaterie",
                                  new List<string>() { "@user", "@materie" },
                                  new List<Object>() { user_elev, nume_materie });
            }

        [WebMethod]
        public DataSet getClase()
        {
            return makeGetRequest("GetAllClase",
                                  new List<string>() {  },
                                  new List<Object>() {  });
        }

        [WebMethod]
        public DataSet getClaseById(int id)
        {
            return makeGetRequest("GetEleviByClasa",
                                  new List<string>() { "@id" },
                                  new List<Object>() { id });
        }

        [WebMethod]
        public int insertElev(string nume, string data_nasterii, string user_elev, string password, int id_clasa)
        {
            return makePostRequest("InsertElev",
                                     new List<string>() { "@username", "@password", "@data_nasterii", "@id_clasa", "@nume" },
                                     new List<Object>() { user_elev, password, data_nasterii, id_clasa, nume });
        }

        [WebMethod]
        public int insertProfesor(string nume, string user_profesor, string password)
        {
            return makePostRequest("InsertProfesor",
                                     new List<string>() { "@username", "@password", "@nume" },
                                     new List<Object>() { user_profesor, password, nume });
        }
    }
}
