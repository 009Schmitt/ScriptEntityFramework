using DataSetLayer;
using System;

namespace DataAccessLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClienteDBContext())
            {
                var std = new Cliente();
                std.Nome = "Jorge";
                std.Idade = 45;
                std.Cpf = "476.344.935-34";
                std.Rg = "477.112-4";

                context.Clientes.Add(std);
                context.SaveChanges();
            }


        }
    }
}
