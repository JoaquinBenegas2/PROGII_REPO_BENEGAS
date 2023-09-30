using ModeloParcial.Datos.Interfaces;
using ModeloParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Datos.DAO
{
    internal class DaoMaterial : IDaoMaterial
    {
        public List<Material> ObtenerMateriales()
        {
            string nombreSP = "SP_CONSULTAR_MATERIALES";

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar(nombreSP);

            List<Material> listaMateriales = new List<Material>();  
            foreach(DataRow row in dataTable.Rows)
            {
                Material oMaterial = new Material();
                oMaterial.Codigo = Convert.ToInt32(row["codigo"]);
                oMaterial.Nombre = Convert.ToString(row["nombre"]);
                oMaterial.Stock = Convert.ToInt32(row["stock"]);

                listaMateriales.Add(oMaterial);
            }

            return listaMateriales;
        }
    }
}
