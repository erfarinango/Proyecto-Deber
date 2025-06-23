using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PedidosRepositorioImpl : RepositorioImpl<Pedidos>, IPedidosRepositorio
    {
        public PedidosRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
