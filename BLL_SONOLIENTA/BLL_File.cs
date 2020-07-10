using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL_DORMISIENTA
{
    public class BLL_File
    {
        // metodo para crear un directorio si no existe
        public Boolean Crear_Directorio(string UrlCompleta)
        {
            try
            {
                if (!System.IO.Directory.Exists(UrlCompleta))
                {
                    System.IO.Directory.CreateDirectory(UrlCompleta);
                }
                return true;
            }
            catch (Exception error)
            {
                Escribir_Log(error.ToString());
                 return false;
            }
        }

        // metodo para gusrdar un archivo en un directorio especifico
        public Boolean Guardar_Archivo(string urlDestino_completa, string nombre_archivo_con_extension, HttpPostedFileBase file)// se guardan los archivos con codigo en vez del file name 
        {
            Crear_Directorio(urlDestino_completa);

            try
            {
                file.SaveAs(urlDestino_completa + nombre_archivo_con_extension);
                return true;
            }
            catch (Exception error)
            {
                BLL_File.Escribir_Log(error.ToString());
                 return false;
            }

        }

        // metodo que permite resgitar las excepciones en un archivo txt
        public static void Escribir_Log(string log)
        {
            string ruta_logs = String.Format(@"" + ConfigurationManager.AppSettings.Get("Ruta_Logs"));// lee la propiedad ruta_logs del webconfig;

            if (!System.IO.File.Exists(ruta_logs))
            {
                if (!Directory.Exists(ruta_logs))
                {
                    Directory.CreateDirectory(ruta_logs);// se crea el directorio

                    // se crea el archivo
                    using (StreamWriter mylogs = System.IO.File.AppendText(ruta_logs + "LOGS_DORMISIENTA.txt")) //se crea el archivo
                    {
                        mylogs.Close();
                    }
                }
            }


            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(ruta_logs + "LOGS_SIGECOR.txt", true);

                //Write a line of text
                sw.WriteLine("\n");
                sw.WriteLine("-------------------------------------------------------------------------------------------------");
                sw.WriteLine("ERROR SIGECOR [ " + DateTime.Parse(DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss")) + " ] : ");
                sw.WriteLine("\n");

                sw.WriteLine(log);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                // return false;
            }

        }


    }
}





