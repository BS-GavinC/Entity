using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configs
{
    internal class ShopConfig : IEntityTypeConfiguration<Shop>
    {
        void IEntityTypeConfiguration<Shop>.Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.HasCheckConstraint("CK_Email", "Email LIKE '__%@__%.%'");
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasData(new Shop
            {
                Id = 1,
                Name = "La Fine Fleure",
                Address = "Rue de la Tulipe N 52 Liege",
                Email = "LaFineFleur@fleur.be"
            }); ;
        }
    }
}
