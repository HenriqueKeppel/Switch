using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entityes;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        // Configuração por convenção -- não é necessário definir cada uma das propriedades da classe e irá trabalhar com as convenções padroes do
        // entity framework
        // Desvantagens: vc não define o tamanho das colunas na tabela
        // Vantagens: mais produtivo se esses detalhes não são importantes
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; } 
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Identificacao> Identificacao { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        // Fluent-api por configuracao
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new AmigoConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());
            modelBuilder.ApplyConfiguration(new StatusRelacionamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ProcurandoPorConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        // Fluent-Api direto
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuario>(entity => {
        //        entity.HasKey(u => u.Id);
        //        entity.Property(u => u.Nome)
        //                .IsRequired()
        //                .HasMaxLength(400);
        //    });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}