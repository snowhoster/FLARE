using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using FLARE_TYPE;
using FLARE_DAL;

namespace FLARE_CFILE
{
    public class FlareCFILE
    {
        /// <summary>
        /// 公私場所編號
        /// </summary>
        public string FCODE { get; set; }
        /// <summary>
        /// 管制編號
        /// </summary>
        public string CCODE { get; set; }
        /// <summary>
        /// 檔案路徑
        /// </summary>
        public string PATH { get; set; }

        public FlareCFILE()
        {
            CCODE = "00000";
        }

        public string MakeMinuteFormat(FlareMinute data)
        {
            StringBuilder result = new StringBuilder ();
            result.Append(data.格式碼);
            result.Append(data.管道編號);
            result.Append(data.日期);
            result.Append(data.時間);
            if (data.格式碼 == "A980")
            {
                result.Append(data.平均值.PadRight(10, ' '));
            }
            else if (data.格式碼 == "A990")
            {
                result.Append(data.平均值.PadRight(6, ' '));
            }
            else
            {
                result.Append(data.平均值.PadRight(8, ' '));
            }
            
            result.Append(data.辨別碼);
            
           return result.ToString(); 
        }


        public string MakeHourFormat(FlareHour data)
        {
            StringBuilder result = new StringBuilder();
            result.Append(data.格式碼);
            result.Append(data.管道編號);
            result.Append(data.日期);
            result.Append(data.時間);
            if (data.格式碼 == "A280")
            {
                result.Append(data.平均值.PadRight(10, ' '));
            }
            else if (data.格式碼 == "A290")
            {
                result.Append(data.平均值.PadRight(6, ' '));
            }
            else
            {
                result.Append(data.平均值.PadRight(8, ' '));
            }

            result.Append(data.辨別碼);

            return result.ToString();
        }

        public string MakeCalibFormat(FlareCalib data)
        {
            StringBuilder result = new StringBuilder();
            result.Append(data.格式碼);
            result.Append(data.管道編號);
            result.Append(data.開始日期);
            result.Append(data.開始時間);
            result.Append(data.結束日期);
            result.Append(data.結束時間);
            result.Append(data.全幅.PadRight(6, ' '));
            result.Append(data.校正標準值.PadRight(9, ' '));
            result.Append(data.監測量測值.PadRight(9, ' '));
            result.Append(data.偏移.PadRight(9, ' '));
            result.Append(data.偏移百分率.PadRight(5, ' '));
            result.Append(data.校正標準值2.PadRight(9, ' '));
            result.Append(data.監測量測值2.PadRight(9, ' '));
            result.Append(data.偏移2.PadRight(9, ' '));
            result.Append(data.偏移百分率2.PadRight(5, ' '));

            return result.ToString();
        }

        /// <summary>
        /// 即時資料轉檔
        /// </summary>
        /// <param name="dtNow"></param>
        /// <param name="Datas"></param>
        /// <returns></returns>
        public bool MakeRealFile(DateTime dtNow,List<string> Datas)
        {
            string fileName =PATH + "FL" + dtNow.Month.ToString().PadLeft(2, '0') +
                                     dtNow.Day.ToString().PadLeft(2, '0') +
                                     dtNow.Hour.ToString().PadLeft(2, '0') +
                                     dtNow.Minute.ToString().PadLeft(2, '0') + "." + FCODE;

            FileStream file = new FileStream(fileName, FileMode.Create);
            string Head = "1000" + CCODE + "FLR" + Convert.ToChar(0x0A);

            file.Write(ASCIIEncoding.Default.GetBytes(Head), 0, Head.Length);
            foreach (var a in Datas)
            {
                string dat = a + Convert.ToChar(0x0A);
                file.Write(ASCIIEncoding.Default.GetBytes(dat), 0, dat.Length);
            }
            string EndCode = Convert.ToChar(0x04).ToString ();
            file.Write(ASCIIEncoding.Default.GetBytes(EndCode), 0, EndCode.Length);

            file.Close();
            return true;
        }

        public bool MakeDayFile(DateTime dtNow, List<string> Datas)
        {

            return true;
        }
    }
}
