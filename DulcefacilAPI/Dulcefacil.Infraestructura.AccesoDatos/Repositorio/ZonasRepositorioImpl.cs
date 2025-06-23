using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ZonasRepositorioImpl : RepositorioImpl<Zonas>, IZonasRepositorio
    {
        public ZonasRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
