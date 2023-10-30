using System;
using System.Collections.Generic;

namespace SistemaDeGerenc.MODEL;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public double? Saldo { get; set; }

    public int? IdDespesa { get; set; }

    public int? IdReceita { get; set; }

    public virtual Despesa? IdDespesaNavigation { get; set; }

    public virtual Receitum? IdReceitaNavigation { get; set; }
}
