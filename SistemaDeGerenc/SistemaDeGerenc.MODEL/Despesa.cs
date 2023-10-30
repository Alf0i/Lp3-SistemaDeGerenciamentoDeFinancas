using System;
using System.Collections.Generic;

namespace SistemaDeGerenc.MODEL.DBContext;

public partial class Despesa
{
    public int IdDespesa { get; set; }

    public DateTime? Data { get; set; }

    public double? Valor { get; set; }

    public string? Categoria { get; set; }

    public string? Descricao { get; set; }
}
