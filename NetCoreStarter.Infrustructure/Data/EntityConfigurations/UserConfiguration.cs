using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Infrustructure.Data.EntityModels;

namespace TestPractice.Infrustructure.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.AddressId).IsRequired();

            builder.HasOne(x => x.Address)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
