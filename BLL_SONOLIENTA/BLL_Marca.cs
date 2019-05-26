using MODELOS_SONOLIENTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Marca
    {
        public List<MarcaModel> ListarMarcas()
        {
            try
            {
                //  return bd.marca.toList();
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}