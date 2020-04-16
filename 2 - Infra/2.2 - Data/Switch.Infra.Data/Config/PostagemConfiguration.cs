using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entityes;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataPublicacao)
                .IsRequired();
            builder.Property(p => p.Texto)
                .IsRequired()
                .HasMaxLength(400);

            // Relacionamento invertido de postagem para usuario
            //builder.HasOne(p => p.Usuario)
            //    .WithMany(u => u.Postagens);

        }
    }
}
