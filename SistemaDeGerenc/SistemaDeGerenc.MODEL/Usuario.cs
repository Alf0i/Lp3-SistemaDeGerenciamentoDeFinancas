﻿using System;
using System.Collections.Generic;

namespace SistemaDeGerenc.DAL.DBContext;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }
}
