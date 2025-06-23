using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClientesRepositorioImpl : RepositorioImpl<Clientes>, IClientesRepositorio
    {
        public ClientesRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
