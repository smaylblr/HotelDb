﻿using Ismail.Examples.Work.Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity.EntityConfigurations
{
    public class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
    {
        private readonly DbContextOptions _options;
        public RoomEntityConfiguration(DbContextOptions options)
        {
            _options = options;
        }
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(c => c.Id);
        }

    }
}
