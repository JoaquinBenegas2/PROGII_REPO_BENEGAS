using ModeloParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Datos
{
    public class DBHelper
    {
        private static DBHelper instancia = null;
        private SqlConnection conexion;

        public DBHelper()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-6QIH5CB;Initial Catalog=db_ordenes;Integrated Security=True");
        }

        public static DBHelper ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }

        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            comando.Parameters.Clear();
            foreach (Parametro parametro in listaParametros)
            {
                comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
            }

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public object Consultar(string nombreSP, SqlParameter parametroSalida)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            comando.Parameters.Add(parametroSalida);
            comando.ExecuteNonQuery();

            conexion.Close();

            return parametroSalida.Value;
        }

        public bool ConfirmarOrden(OrdenRetiro oOrdenRetiro)
        {
            SqlTransaction transaction = null;
            bool resultado = true;

            try
            {
                conexion.Open();

                transaction = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand();
                cmdMaestro.Connection = conexion;
                cmdMaestro.Transaction = transaction;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = "SP_INSERTAR_ORDEN";

                cmdMaestro.Parameters.AddWithValue("@responsable", oOrdenRetiro.Responsable);

                SqlParameter parametroSalida = new SqlParameter();
                parametroSalida.ParameterName = "@nro";
                parametroSalida.SqlDbType = SqlDbType.Int;
                parametroSalida.Direction = ParameterDirection.Output;

                cmdMaestro.Parameters.Add(parametroSalida);

                cmdMaestro.ExecuteNonQuery();


                int nroOrden = (int)parametroSalida.Value;
                int nroDetalle = 1;

                SqlCommand cmdDetalle;
                foreach (DetalleOrden detalleOrden in oOrdenRetiro.Detalles)
                {
                    cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = conexion;
                    cmdDetalle.Transaction = transaction;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "SP_INSERTAR_DETALLES";

                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nroOrden);
                    cmdDetalle.Parameters.AddWithValue("@detalle", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@codigo", detalleOrden.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalleOrden.Cantidad);

                    cmdDetalle.ExecuteNonQuery();

                    nroDetalle++;
                }

                transaction.Commit();
            }
            catch
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }

                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resultado;
        }
    }
}
