using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using BLL_Net.Entidades;

namespace BLL_Net
{
    public class BLL_Aunteticate
    {
        private string ConnectionString = null;


        public BLL_Aunteticate(string conecicon)
        {
            ConnectionString = conecicon;
        }


        public List<Users> ListAllUsers()
        {
            try
            {
                // Este metodo de conexion a Bd fue sugerido por Edilberto Almanza (ARQ), con el fin de evitar usar las librerias Sistran que son muy pesadas para el proposito de este desarrollo
                DataTable dt = new DataTable();
                List<Users> List = new List<Users>();
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_LIST_USERS_INTEGRATION_WEB_API", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.CommandTimeout = cn.ConnectionTimeout;
                    /*
                    cmd.Parameters.AddWithValue("@txt_nombre_avisa", claimsReport.NombreAvisa);
                    cmd.Parameters.AddWithValue("@Nro_Unidades", claimsReport.NroUnidades);
                    */
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt = dr.GetSchemaTable();

                    int nCols = dr.FieldCount;
                    string[] sData = null;


                    while (dr.Read())
                    {
                        Users Users = new Users();
                        sData = new string[nCols];
                        for (int nCol = 0; nCol < nCols; nCol++)
                        {
                            Users.Id = (int)dr.GetValue(0);
                            Users.FirstName = dr.GetValue(1).ToString();
                            Users.LastName = dr.GetValue(2).ToString();
                            Users.Username = dr.GetValue(3).ToString();
                            Users.Password = dr.GetValue(4).ToString();
                            Users.Role = dr.GetValue(5).ToString();
                            Users.Token = dr.GetValue(6).ToString();
                            Users.RefreshToken = dr.GetValue(7).ToString();
                        }
                        List.Add(Users);
                    }
                    dr.Close();
                }
                return List;
            }
            catch (Exception error)
            {
                return null;
            }
        }


        public Boolean UpdateUsersToken(int? Id, string Token, string TokenRefresh)
        {
            try
            {
                // Este metodo de conecicon a Bd fue sugerido por Edilberto Almanza (ARQ), con el fin de evitar usar las librerias Sistran que son muy pesadas para el proposito de este desarrollo
                DataTable dt = new DataTable();
                List<Users> List = new List<Users>();
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_UPDATE_USERS_INTEGRATION_WEB_API_TOKEN", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.CommandTimeout = cn.ConnectionTimeout;

                    cmd.Parameters.AddWithValue("@PI_ID", Id);
                    cmd.Parameters.AddWithValue("@PI_TOKEN_USER", Token);
                    cmd.Parameters.AddWithValue("@PI_TOKEN_REFRESH_USER", TokenRefresh);
                   
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt = dr.GetSchemaTable();
  
                    dr.Close(); 
                    return true;
                }
               
            }
            catch (Exception error)
            {
                return false;
            }

        }

    }
}