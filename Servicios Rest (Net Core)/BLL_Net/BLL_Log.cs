using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BLL_Net
{
    public static class BLL_Log
    {
        public static void EscribirLog(string RutaLog, string Log)
        {
            string UrlCompleta = String.Format(@"" + RutaLog);

            if (!File.Exists(UrlCompleta))
            {
                if (!Directory.Exists(UrlCompleta))
                {
                    Directory.CreateDirectory(UrlCompleta);// se crea el directorio

                    // se crea el archivo
                    using (StreamWriter MyLogs = File.AppendText(UrlCompleta + "LogsWebApi.txt")) //se crea el archivo
                    {
                        MyLogs.WriteLine("");
                        MyLogs.Close();
                    }
                }
            }
            
                try
                {
                    StreamWriter sw = new StreamWriter(UrlCompleta + "LogsWebApi.txt", true);

                    sw.WriteLine("\n");
                    sw.WriteLine("-------------------------------------------------------------------------------------------------");
                    sw.WriteLine("ERROR  [ " + DateTime.Now + " ] : ");
                    sw.WriteLine("\n");
                    sw.WriteLine(Log);

                    sw.Close();
                }
                catch (Exception e)
                {
                    throw;
                }

             
        }
    }
}