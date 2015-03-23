using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ReverseCodeFirst.Models.Mapping;

namespace ReverseCodeFirst.Models
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

        public DbSet<AssistenciaPorMe> AssistenciaPorMes { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
        public DbSet<EntidadeSocial> EntidadeSocials { get; set; }
        public DbSet<Filiacao> Filiacaos { get; set; }
        public DbSet<TipoDeAssistencia> TipoDeAssistencias { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssistenciaPorMeMap());
            modelBuilder.Configurations.Add(new BeneficiarioMap());
            modelBuilder.Configurations.Add(new DependenteMap());
            modelBuilder.Configurations.Add(new EntidadeSocialMap());
            modelBuilder.Configurations.Add(new FiliacaoMap());
            modelBuilder.Configurations.Add(new TipoDeAssistenciaMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
