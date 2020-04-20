using FlowerDelivery.DAL;
using FlowerDelivery.SL.Services;

namespace FlowerDelivery.SL
{
    public class ServiceManager
    {
        public FlowerService Flowers { get; private set; }
        public PlantationFlowerService PlantationFlowers { get; private set; }
        public PlantationService Plantations { get; private set; }
        public WarehouseService Warehouses { get; private set; }
        public WarehouseFlowerService WarehouseFlowers { get; private set; }
        public SupplyService Supplies { get; private set; }
        public SupplyFlowerService SupplyFlowers { get; private set; }
        public ServiceManager(DataManager dataManager)
        {
            Flowers = new FlowerService(dataManager);
            Plantations = new PlantationService(dataManager);
            PlantationFlowers = new PlantationFlowerService(dataManager);
            Warehouses = new WarehouseService(dataManager);
            WarehouseFlowers = new WarehouseFlowerService(dataManager);
            Supplies = new SupplyService(dataManager);
            SupplyFlowers = new SupplyFlowerService(dataManager);

        }
    }
}
