using Extranet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Extranet.Infrastructure.Persistence.Configuratioins
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            //definir chavas primárias
            builder
                .HasKey(p => p.Id);

            //Relacionamentos
            builder
                .HasOne(p => p.Freelancer)// um freelancer
                .WithMany(p => p.FreelanceProjects)// um freelancer tem muitos projetos
                .HasForeignKey(p => p.IdFreelancer)// chave estrangeira do relacionamento
                .OnDelete(DeleteBehavior.Restrict);// Comportamento quando houver a remoção da entidades do relacionamento
                                                   // restrict é recomendado para impedir que seja excluido uma entidade que tenha relacionamento com outras.

            builder
                .HasOne(p => p.Client)
                .WithMany(p => p.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
