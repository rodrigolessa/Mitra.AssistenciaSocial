using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Mitra.AssistenciaSocial.UI.WPF.Models.Mapping;

namespace Mitra.AssistenciaSocial.UI.WPF.Models
{
    public partial class MitraContext : DbContext
    {
        static MitraContext()
        {
            Database.SetInitializer<MitraContext>(null);
        }

        public MitraContext()
            : base("Name=MitraContext")
        {
        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
        public DbSet<EntidadeSocial> EntidadeSocials { get; set; }
        public DbSet<Filiacao> Filiacaos { get; set; }
        public DbSet<TipoDeAssistencia> TipoDeAssistencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BeneficiarioMap());
            modelBuilder.Configurations.Add(new DependenteMap());
            modelBuilder.Configurations.Add(new EntidadeSocialMap());
            modelBuilder.Configurations.Add(new FiliacaoMap());
            modelBuilder.Configurations.Add(new TipoDeAssistenciaMap());
        }
    }
}
