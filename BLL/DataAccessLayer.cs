using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BLL
{
    public class DataAccessLayer
    {

        private SqlConnection conexion = new SqlConnection("initial catalog=AUTOS_DB; data source=.; integrated security=sspi");
        private SqlCommand comando = new SqlCommand();
        public SqlDataReader lector { get; set; }

        public void setearProcedimientoAlmacenado(string procedure) {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = procedure;
        }

        public void setearConsultaEmbebida(string consulta) {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void abrirConexion() {
            conexion.Open();
        }

        public void ejecutarLectura() {
            comando.Connection = conexion;
            lector = comando.ExecuteReader();
        }
        public void ejectutarAcciones() {
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
        }

    }
}
