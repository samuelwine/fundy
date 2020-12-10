using Fundy.Core.Entities;
using Fundy.Core.Records;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fundy.Infrastructure.Data.Config
{
    public class DonorConfiguration : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.OwnsOne(
                x => x.Name,
                name =>
                {
                    name.Property(p => p.Title).HasColumnName("Title");
                    name.Property(p => p.FirstName).HasColumnName("FirstName");
                    name.Property(p => p.LastName).HasColumnName("LastName");
                });

            builder.OwnsOne(
                x => x.HomeAddress
                );

            builder.OwnsOne(
                x => x.WorkAddress
                );
        }
    }
}
