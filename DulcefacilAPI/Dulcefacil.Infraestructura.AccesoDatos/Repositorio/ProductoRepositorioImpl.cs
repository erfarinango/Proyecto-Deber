using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositorioImpl : RepositorioImpl<Productos>, IProductoRepositorio
    {
        public ProductoRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
