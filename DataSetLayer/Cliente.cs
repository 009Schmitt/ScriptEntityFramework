using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSetLayer
{
    public partial class Cliente : DbContext
    {
        public Cliente()
        {
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
