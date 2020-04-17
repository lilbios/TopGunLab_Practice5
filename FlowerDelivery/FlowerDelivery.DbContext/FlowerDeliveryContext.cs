using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerDelivery.DTO.Entities;

namespace FlowerDelivery.DBContext
{
    public class FlowerDeliveryContext:DbContext
    {
        FlowerDelivery.DTO.Entities.

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyFlower> SupplyFlowers { get; set; }
        public DbSet<WarehouseFlower> WarehouseFlowers { get; set; }
        public DbSet<PlantationFlower> PlantationFlowers { get; set; }
        
    }
}
