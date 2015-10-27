using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Area { get; set; }
        public string Fecha { get; set; }

        ConexionBD conexion = new ConexionBD();
        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombre = "";
            this.NombreUsuario = "";
            this.Contrasena = "";
            this.Area = "";
            
        }
        public Usuarios(int UsuarioId,string Nombre,string NombreUsuario,string Contrasena, string Area,string Fecha)
        {
            this.UsuarioId = UsuarioId;
            this.Nombre = Nombre;
            this.NombreUsuario = NombreUsuario;
            this.Contrasena = Contrasena;
            this.Area = Area;
            this.Fecha = Fecha;
        }

        public string VerificarUsuario()
        { string repuesta;
            try
            {

                repuesta = conexion.ObtenerDatos(String.Format("Select NombreUsuario From Usuarios Where NombreUsuario = '{0}'", this.NombreUsuario)).Rows[0]["NombreUsuario"].ToString();

            }
            catch (Exception ex)
            {
                return "";

            }
            return repuesta;
        }

        public string VerificarContrasena()
        {
            string repuesta2 ="";
            try
            {

                repuesta2 = conexion.ObtenerDatos(String.Format("Select Contrasena From Usuarios Where Contrasena = '{0}'", this.Contrasena)).Rows[0]["Contrasena"].ToString();

            }
            catch (Exception ex)
            {
                return "";

            }
            return repuesta2;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert Into Usuarios (Nombre,NombreUsuario,Contrasena,Area,Fecha) Values('{0}','{1}','{2}','{3}','{4}')", this.Nombre,this.NombreUsuario,this.Contrasena,this.Area,this.Fecha));
            return retorno;
        }
 
        public override bool Editar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Update Actores Set Nombre= '{0} ,NombreUsuario='{1}',Contrasena='{2}',Area='{3}',Fecha='{4}'' Where UsuarioId = {5}", this.Nombre, this.NombreUsuario, this.Contrasena, this.Area, this.Fecha,this.UsuarioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete  Usuarios Where UsuarioId = {0}",this.UsuarioId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            dt = (conexion.ObtenerDatos(String.Format("Select UsuarioId, Nombre,NombreUsuario,Contrasena,Area,Fecha From Usuarios Where UsuarioId = {0}",idBuscado)));
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.Area = dt.Rows[0]["Area"].ToString();
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by  " + orden;

            return conexion.ObtenerDatos(("Select " + campos +
                " From Usuarios Where " + condicion + ordenFinal));
        }
    }
}
