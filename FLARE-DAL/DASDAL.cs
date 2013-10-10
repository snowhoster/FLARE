using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using FLARE_TYPE;
using System.Data.SqlClient;


namespace FLARE
{
    class DASDAL
    {
        string ConnString = "";
        string errorMsg;
        NLog.Logger logger = NLog.LogManager.GetLogger("Flare");

        public DASDAL()
        {
            //使用應用程式組態檔連線方式,需加入參考[System.configuration.dll]
            ConnString = ConfigurationManager.ConnectionStrings["DASConnectionString"].ConnectionString;
            
        }

        #region DAS 資料處理

        public List<FlareMinute> GetMinToFlare(string tagno, DateTime STime, DateTime ETime)
        {
            List<FlareMinute> Result = new List<FlareMinute>();

            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return Result;
        }

        public List<FlareHour> GetHourToFlare(string tagno, DateTime STime, DateTime ETime)
        {
            List<FlareHour> Result = new List<FlareHour>();
            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return Result;
        }

        public List<FlareCalib> GetCalibToFlare(string tagno, DateTime STime, DateTime ETime)
        {
            List<FlareCalib> Result = new List<FlareCalib>();
            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return Result;
        }

        #endregion
    }
}
