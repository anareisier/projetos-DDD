using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Email)
                .IsRequired();
                
        }
    }
}
