﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dulcefacil.Infraestructura.AccesoDatos;

public partial class NOTIFICACION
{
    public int id_notificacion { get; set; }

    public int? id_actividad { get; set; }

    public int? id_empresa { get; set; }

    public string nombre { get; set; }

    public string descripcion { get; set; }

    public DateOnly? fecha_venta { get; set; }

    public virtual ACTIVIDAD id_actividadNavigation { get; set; }

    public virtual EMPRESA id_empresaNavigation { get; set; }
}