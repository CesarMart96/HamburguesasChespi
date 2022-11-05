using System;
using System.Collections.Generic;

namespace HamburguesasChespi.Models
{
    public partial class Pedido
    {
        public string Nombre { get; set; } = null!;
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Descripcion { get; set; }
    }
}
