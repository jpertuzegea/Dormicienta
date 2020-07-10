using BLL_DORMISIENTA;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Contactenos
    {
        private Dormisienta_Entities bd = new Dormisienta_Entities();

        public bool EnviarMensaje(CONTACTENOS Contactenos)
        {
            if (Contactenos != null)
            {// si el objeto es diferente de nulo
                try
                {
                    Contactenos.FechaSolicitud = (DateTime.UtcNow).AddHours(-5);
                    bd.CONTACTENOS.Add(Contactenos);
                    bd.SaveChanges();

                    string CorreoContacto = ConfigurationManager.AppSettings.Get("CorreoContacto");
                    string Mensaje =
                        "Datos del Cliente:\n\n" +
                        "Nombre: " + Contactenos.NombreSolicitate + "\n" +
                        "Telefono: " + Contactenos.TelefonoSolicitante + "\n" +
                        "Email: " + Contactenos.EmailSolicitante + "\n" +
                        "Fecha Solicitud: " + Contactenos.FechaSolicitud + "\n\n" +
                        "Asunto : " + Contactenos.Asunto + "\n" +
                        "Mensaje : " + Contactenos.Mensaje;

                    BLL_Email BLL_Email = new BLL_Email();
                    BLL_Email.EnviarCorreo(CorreoContacto, Contactenos.Asunto, Mensaje);

                    return true;
                }
                catch (Exception Error)
                {
                    BLL_File.Escribir_Log(Error.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public List<CONTACTENOS> ListarMensajes()
        {
            List<CONTACTENOS> List = null;
            try
            {
                List = bd.CONTACTENOS.ToList();
                return (List);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                return null;
            }

        }


    }
}
