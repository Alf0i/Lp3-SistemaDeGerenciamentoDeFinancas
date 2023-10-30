using System;
using System.Collections.Generic;

namespace SistemaDeGerenc.MODEL;

public partial class Receitum
{
    public int IdReceita { get; set; }

    public DateTime? Data { get; set; }

    public double? Valor { get; set; }

    public string? Categoria { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
