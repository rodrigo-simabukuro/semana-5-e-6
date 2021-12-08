using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proj_semana5e6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_semana5e6.Mappings
{
    public class CaminhaoMap : IEntityTypeConfiguration<Caminhao>
    {
        public void Configure(EntityTypeBuilder<Caminhao> builder)
        {
            builder.ToTable("Caminhão");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnType("varchar(max)");
            builder.Property(p => p.DataCriacao).HasColumnType("datetime");
        }
    }
}
