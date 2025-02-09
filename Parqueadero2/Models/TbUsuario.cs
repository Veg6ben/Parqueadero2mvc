using System;
using System.Collections.Generic;

namespace Parqueadero2.Models;

public partial class TbUsuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? NumeroDePlaca { get; set; }

    public string? Modelo { get; set; }

    public string? Color { get; set; }
}
