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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.House).IsRequired();

            builder.Property(x => x.Road).IsRequired();

            builder.Property(x => x.City).IsRequired();

        }
    }
}
