﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dulcefacil.Infraestructura.AccesoDatos;

public partial class Productos
{
    public int ID_Producto { get; set; }

    public string NombreProducto { get; set; }

    public string Descripción { get; set; }

    public int Stock { get; set; }

    public virtual ICollection<Detalle_Pedido> Detalle_Pedido { get; set; } = new List<Detalle_Pedido>();

    public virtual ICollection<PrecioProducto> PrecioProducto { get; set; } = new List<PrecioProducto>();
}