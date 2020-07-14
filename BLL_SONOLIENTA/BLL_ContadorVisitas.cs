using BLL_DORMISIENTA;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL_SONOLIENTA
{
    public class BLL_ContadorVisitas
    {
        private Dormisienta_Entities bd = new Dormisienta_Entities();

        public void RegistrarVisita()
        {
            try
            {
                CONTADORVISITAS CONTADORVISITAS = new CONTADORVISITAS();
                CONTADORVISITAS.Ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                CONTADORVISITAS.FechaVisita = DateTime.Parse(DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));
                bd.CONTADORVISITAS.Add(CONTADORVISITAS);
                bd.SaveChangesAsync(); 
            }
            catch (Exception Error)
            {
                BLL_File.Escribir_Log(Error.ToString()); 
            }
        }


        public List<CONTADORVISITAS> ListarVisitas()
        {
            List<CONTADORVISITAS> List = null;
            try
            {
                List = bd.CONTADORVISITAS.ToList();
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
