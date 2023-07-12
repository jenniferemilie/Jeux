using Jeux.Models;
using Microsoft.EntityFrameworkCore;

namespace Jeux.Config
{
    public class JeuxConfig : IEntityTypeConfiguration<Jeu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Jeu> builder)
        {
            
        }
    }
}
