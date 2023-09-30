using ModeloParcial.Datos.DAO;
using ModeloParcial.Datos.Interfaces;
using ModeloParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial.Servicios
{
    public class GestorOrdenes
    {
        private IDaoOrden daoOrden;

        public GestorOrdenes()
        {
            daoOrden = new DaoOrden();
        }

        public bool InsertOrden(OrdenRetiro oOrdenRetiro)
        {
            return daoOrden.InsertarOrden(oOrdenRetiro);
        }
    }
}
