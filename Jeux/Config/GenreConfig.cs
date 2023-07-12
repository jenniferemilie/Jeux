using Jeux.Models;
using Microsoft.EntityFrameworkCore;

namespace Jeux.Config
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(G => G.Id_Genres);
            builder.Property(g => g.Id_Genres).ValueGeneratedOnAdd();
        }
    }
}
