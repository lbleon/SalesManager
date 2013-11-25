using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.IO;
namespace SalesManager.Common
{
    /// <summary>
    /// Log 的摘要说明。
    /// </summary>
    public sealed class Log
    {
        private static readonly string logPath = ConfigurationSettings.AppSettings["LogPath"];

        #region Methods

        static StreamWriter CreateLogFile(string FileName)
        {
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            string FilePath = logPath + "\\" + FileName + " " + DateTime.Today.ToString("yyyyMMdd") + ".log";
            if (!File.Exists(FilePath))
            {
                return File.CreateText(FilePath);
            }
            return File.AppendText(FilePath);
        }
        public static void WriteErrorInfo(string s, Exception ex)
        {
            lock (thisLock)
            {
                StreamWriter SW = CreateLogFile("Error");

                SW.WriteLine(DateTime.Today.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("hh:mm:ss") + "  " + s);
                SW.WriteLine(ex.Message);
                SW.WriteLine(ex.StackTrace);
                Write(s);
            }
        }
        private static Object thisLock = new Object();
        public static void Write(string s)
        {
            string sFileName = null;
            StreamWriter SW;
            lock (thisLock)
            {

                sFileName = logPath;
                if (!Directory.Exists(sFileName)) Directory.CreateDirectory(sFileName);

                sFileName = logPath + "\\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
                if (!File.Exists(sFileName))
                    SW = File.CreateText(sFileName);
                else
                    SW = File.AppendText(sFileName);
                SW.WriteLine(DateTime.Today.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("hh:mm:ss") + "  " + s);
                SW.Close();
            }
        }
        public static void ThrowException(string ErrMsg)
        {
            Write(ErrMsg);
            throw new Exception(ErrMsg);
        }
        public static void Read(string filename, ref string sMsg)
        {
            string sFileName = null;

            sFileName = logPath;
            if (!Directory.Exists(sFileName)) Directory.CreateDirectory(sFileName);

            sFileName = logPath + "\\" + filename;//+".log"
            if (!File.Exists(sFileName)) return;
            //
            StreamReader SR;
            string S;
            SR = File.OpenText(sFileName);
            S = SR.ReadLine();
            while (S != null)
            {
                sMsg += S + "\r\n";
                S = SR.ReadLine();
            }
            SR.Close();
        }

        #endregion
    }
}
