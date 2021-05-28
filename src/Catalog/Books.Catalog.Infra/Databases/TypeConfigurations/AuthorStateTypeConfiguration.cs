using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Domain.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Books.Catalog.Infra.Databases.TypeConfigurations
{
    public class AuthorStateTypeConfiguration : IEntityTypeConfiguration<AuthorState>
    {
        public void Configure(EntityTypeBuilder<AuthorState> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FirstName).IsRequired();
            builder.Property(m => m.LastName).IsRequired();
        }
    }
}
