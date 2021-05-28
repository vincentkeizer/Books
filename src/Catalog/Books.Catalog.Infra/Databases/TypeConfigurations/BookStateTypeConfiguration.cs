using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Domain.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Books.Catalog.Infra.Databases.TypeConfigurations
{
    public class BookStateTypeConfiguration : IEntityTypeConfiguration<BookState>
    {
        public void Configure(EntityTypeBuilder<BookState> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Author)
                   .WithMany(m => m.Books)
                   .HasForeignKey(m => m.AuthorId);
            builder.Property(m => m.Title).IsRequired();
        }
    }
}
