using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using FLARE_TYPE;


namespace FLARE_DAL
{
    public class FlareDAL
    {
        string ConnString = "";
        string errorMsg;
        NLog.Logger logger = NLog.LogManager.GetLogger("Flare");

        public FlareDAL()
        {
            //使用應用程式組態檔連線方式,需加入參考[System.configuration.dll]
            ConnString = ConfigurationManager.ConnectionStrings["FlareConnectionString"].ConnectionString;
            
        }

        #region 取得KEY流水號

        /// <summary>
        /// 取得欄位唯一碼!!
        /// </summary>
        /// <param name="KeyID">取得Key之代碼，為3碼字串</param>
        /// <returns>回傳###000XXXXXXXXX，###為Key值，000為民國年，XXXXXXXXX為九碼流水號!!</returns>
        public string GetKeyValue(string KeyID)
        {
            string retrunValue = "";

            using (SqlConnection connection1 = new SqlConnection(ConnString))
            {
                try
                {
                    connection1.Open();

                    string strKeyValue = "";

                    //KyeID 加上三碼民國年碼
                    string thisYear = (DateTime.Now.Year - 1911).ToString("000");
                    KeyID = KeyID + thisYear;


                    string strSQL = "SELECT * from tbKeyGen Where keyID='" + KeyID + "'";
                    SqlDataAdapter da1 = new SqlDataAdapter(strSQL, connection1);
                    DataTable DT = new DataTable();
                    da1.Fill(DT);
                    da1.Dispose();

                    int ivalue = 0;
                    if (DT.Rows.Count > 0)
                    {
                        ivalue = int.Parse(DT.Rows[0]["keyNum"].ToString()) + 1;
                        strSQL = "Update tbKeyGen Set keyNum =" + ivalue.ToString() + " Where keyID='" + KeyID + "'";
                        SqlCommand cmd1 = new SqlCommand(strSQL, connection1);
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        ivalue = 1;
                        strSQL = "Insert Into tbKeyGen (KeyID,keyNum) Values('" + KeyID + "'," + ivalue.ToString() + ")";
                        SqlCommand cmd1 = new SqlCommand(strSQL, connection1);
                        cmd1.ExecuteNonQuery();
                    }

                    strKeyValue = KeyID + ivalue.ToString().PadLeft(9, '0');
                    retrunValue =  strKeyValue;
                }
                catch
                {
                    retrunValue =  "";

                }
            }


            return retrunValue;
        }

        //取得計畫編號
        public string GetKeyValueByType(int KeyInt)
        {
            string retrunValue = "";

            using (SqlConnection connection1 = new SqlConnection(ConnString))
            {
                try
                {
                    connection1.Open();

                    string strKeyValue = "";
                    string thisYear = (DateTime.Now.Year - 1911).ToString("000");
                    string KeyID = thisYear + KeyInt.ToString("00");

                    string strSQL = "SELECT * from tbKeyGen Where keyID='" + KeyID + "'";
                    SqlDataAdapter da1 = new SqlDataAdapter(strSQL, connection1);
                    DataTable DT = new DataTable();
                    da1.Fill(DT);
                    da1.Dispose();

                    int ivalue = 0;
                    if (DT.Rows.Count > 0)
                    {
                        ivalue = int.Parse(DT.Rows[0]["keyNum"].ToString()) + 1;
                        strSQL = "Update tbKeyGen Set keyNum =" + ivalue.ToString() + " Where keyID='" + KeyID + "'";
                        SqlCommand cmd1 = new SqlCommand(strSQL, connection1);
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        ivalue = 1;
                        strSQL = "Insert Into tbKeyGen (KeyID,keyNum) Values('" + KeyID + "'," + ivalue.ToString() + ")";
                        SqlCommand cmd1 = new SqlCommand(strSQL, connection1);
                        cmd1.ExecuteNonQuery();
                    }

                    strKeyValue = KeyID + ivalue.ToString().PadLeft(7, '0');
                    retrunValue = strKeyValue;
                }
                catch
                {

                    retrunValue =  "";

                }
            }

            return retrunValue;
        }

        #endregion

        #region DAS 資料處理

        public bool SetMinToFlare(List<FlareMinute> Data)
        {
            bool result = false;
            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return result;
        }

        public bool SetHourToFlare(List<FlareHour> Data)
        {
            bool result = false;
            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return result;
        }

        public bool SetCalibToFlare(List<FlareCalib> Data)
        {
            bool result = false;
            DataTable dtMin = new DataTable();
            string strSQL = "";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                da.Fill(dtMin);
                da.Dispose();
            }
            return result;
        }

        #endregion

    }
}
