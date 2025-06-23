using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PrecioProductoRepositorioImpl : RepositorioImpl<PrecioProducto>, IPrecioProductoRepositorio
    {
        public PrecioProductoRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
