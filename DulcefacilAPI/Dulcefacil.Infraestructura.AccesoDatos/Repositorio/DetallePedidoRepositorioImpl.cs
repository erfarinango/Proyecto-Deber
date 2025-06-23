using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class DetallePedidoRepositorioImpl : RepositorioImpl<Detalle_Pedido>, IDetallePedidoRepositorio
    {
        public DetallePedidoRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
