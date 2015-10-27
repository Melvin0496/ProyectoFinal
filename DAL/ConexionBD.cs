using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ConexionBD
    {
        private SqlConnection Con;
        private SqlCommand Cmd;

        public ConexionBD()
        {
            Con = new SqlConnection("Data source = JUNIOR-PC\\ROOT; Initial Catalog = ProyectoFinalBD; Integrated Security = true");
            Cmd = new SqlCommand();
        }

        public  bool Ejecutar(String Comando)
        {
            bool retorno = false;
            try
            {
                Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Comando;
                Cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Con.Close();
            }
            return retorno;
        }
        public DataTable ObtenerDatos(String comando)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = comando;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                Con.Close();
            }

            return dt;
        }
    }
}
