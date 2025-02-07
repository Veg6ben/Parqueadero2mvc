using System;
using System.Collections.Generic;

namespace Parqueadero2.Models;

public partial class TbUsuarioss
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Precio { get; set; }
}
