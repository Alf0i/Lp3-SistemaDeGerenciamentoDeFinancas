﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal interface IReceita
    {
        int Id_Receita { get; set; }
        float Data { get; set; }
        float Valor { get; set; }
        string? Categoria { get; set; }
        string? Descricao { get; set; }
    }
}
