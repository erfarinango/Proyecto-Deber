using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RolesRepositorioImpl : RepositorioImpl<Roles>, IRolesRepositorio
    {
        public RolesRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
