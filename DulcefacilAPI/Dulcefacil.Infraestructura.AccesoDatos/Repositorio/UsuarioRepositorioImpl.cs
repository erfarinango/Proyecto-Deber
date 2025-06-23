using Dulcefacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulcefacil.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuarioRepositorioImpl : RepositorioImpl<Usuarios>, IUsuarioRepositorio
    {
        public UsuarioRepositorioImpl(DulcefacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
