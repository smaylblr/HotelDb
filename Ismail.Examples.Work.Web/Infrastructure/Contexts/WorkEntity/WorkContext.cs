using Ismail.Examples.Work.Web.Domain.Entities;
using Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity
{
    public class WorkContext:DbContext
    {
        private readonly DbContextOptions _dbContextOptions;
        public WorkContext(DbContextOptions options) : base(options)
        {
            _dbContextOptions = options;
        }



        public DbSet<Customer> Customer { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration(_dbContextOptions));

            base.OnModelCreating(modelBuilder);
        }
    }
}
