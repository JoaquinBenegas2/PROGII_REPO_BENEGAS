using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carreras_2023.Entidades;

namespace Carreras_2023.Datos
{
    internal class DBHelper
    {
        private SqlConnection conexion;

        public DBHelper()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-6QIH5CB;Initial Catalog=CARRERAS_2023;Integrated Security=True");
        }

        public int ProximaCarrera()
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROXIMO_ID";

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parametro);
            cmd.ExecuteNonQuery();

            conexion.Close();

            if (Convert.IsDBNull(parametro.Value))
            {
                return 1;
            } else
            {
                return (int)parametro.Value;
            }
        }

        public DataTable EjecutarSPConsulta(string nombreSP)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public DataTable EjecutarSPConsultaConParametros(string nombreSP, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro parametro in listaParametros)
            {
                cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
            }

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public int EjecutarSPConParametros(string nombreSP, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro parametro in listaParametros)
            {
                cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
            }

            int filasAfectadas = cmd.ExecuteNonQuery();

            conexion.Close();

            return filasAfectadas;
        }

        public bool ConfirmarCarrera(Carrera oCarrera)
        {
            bool resultado = true;
            SqlTransaction transaction = null;

            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand();
                cmdMaestro.Connection = conexion;
                cmdMaestro.Transaction = transaction;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = "SP_INSERTAR_MAESTRO";
                cmdMaestro.Parameters.Clear();
                cmdMaestro.Parameters.AddWithValue("@nom_carrera", oCarrera.NomCarrera);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_carrera";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(parametro);

                cmdMaestro.ExecuteNonQuery();

                int idCarrera = (int)parametro.Value;

                SqlCommand cmdDetalle;
                foreach (DetalleCarrera detalleCarrera in oCarrera.ListaDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, transaction);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.Clear();
                    cmdDetalle.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@año_cursado", detalleCarrera.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", detalleCarrera.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", detalleCarrera.Asignatura.IdAsignatura);
                    cmdDetalle.ExecuteNonQuery();
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
