
using System.Data.Entity;
using FlowerDelivery.DTO.Entities;

namespace FlowerDelivery.DBContext
{
    public class FlowerDeliveryContext:DbContext
    {

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyFlower> SupplyFlowers { get; set; }
        public DbSet<WarehouseFlower> WarehouseFlowers { get; set; }
        public DbSet<PlantationFlower> PlantationFlowers { get; set; }
        
    }
}
