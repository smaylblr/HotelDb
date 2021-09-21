using Ismail.Examples.Work.Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity.EntityConfigurations
{
    public class HotelEntityConfiguration : IEntityTypeConfiguration<Hotel>
    {
        private readonly DbContextOptions _options;
        public HotelEntityConfiguration(DbContextOptions options)
        {
            _options = options;
        }
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(c => c.Id);
        }

    }
}
