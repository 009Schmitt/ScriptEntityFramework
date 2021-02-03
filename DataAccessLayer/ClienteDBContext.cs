using DataSetLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccessLayer
{
    class ClienteDBContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Sua conexao do BD");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity => 
            {
                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idade)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });


        }
    }
}
