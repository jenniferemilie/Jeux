using Jeux.Models;
using Microsoft.EntityFrameworkCore;

namespace Jeux.Config
{
    public class JeuxConfig : IEntityTypeConfiguration<Jeu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Jeu> builder)
        {
            builder.HasKey(jx => jx.Id_Jeux);

            builder.Property(jx => jx.Id_Jeux).ValueGeneratedOnAdd();
            builder.Property(jx => jx.Titre_Jeux).HasMaxLength(250).IsRequired();
            builder.ToTable<Jeu>(t => t.HasCheckConstraint("CK_Note", "Note BETWEEN 0 AND 5"));
            
            
        }
    }
}
