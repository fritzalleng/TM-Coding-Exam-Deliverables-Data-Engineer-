using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Data;
using DailyCheckins.Classes;

namespace DailyCheckins
{
    /// <summary>
    /// Summary description for CheckinData
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CheckinData : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]

        public void arya()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            AllUsers[] getuser = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.ConnectionString)) 
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.checkin", connection);
                    sda.SelectCommand.CommandType = System.Data.CommandType.Text;
                    DataTable datatable = new DataTable();
                    sda.Fill(datatable);
                    getuser = new AllUsers[datatable.Rows.Count];
                    int Count = 0;
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {

                            getuser[Count] = new AllUsers();
                            getuser[Count].user = Convert.ToString(datatable.Rows[i]["user"]);
                            getuser[Count].timestamp = Convert.ToString(datatable.Rows[i]["timestamp"]);
                            getuser[Count].hours = Convert.ToString(datatable.Rows[i]["hours"]);
                            getuser[Count].project = Convert.ToString(datatable.Rows[i]["project"]);
                            Count++;
                    }

                    datatable.Clear();
                    connection.Close();

                }

            }catch(Exception ex)
            {

            }
            var JSonData = new
            {
                getuser = getuser
            };
            HttpContext.Current.Response.Write(ser.Serialize(JSonData));
        }
    }
}
