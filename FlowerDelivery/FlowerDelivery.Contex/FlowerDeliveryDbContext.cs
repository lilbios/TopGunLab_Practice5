using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.Contex
{
    public class FlowerDeliveryDbContext:DbContext
    {
          public DbSet<Flower> Flowers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyFlower> SupplyFlowers { get; set; }
        public DbSet<WarehouseFlower> WarehouseFlowers { get; set; }
        public DbSet<PlantationFlower> PlantationFlowers { get; set; }

        public FlowerDeliveryDbContext()
            :base("Server = (localdb)\\mssqllocaldb; Database=flowerdeliverydb;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
