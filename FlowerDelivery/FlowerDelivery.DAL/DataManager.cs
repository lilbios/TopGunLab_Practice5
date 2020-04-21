using FlowerDelivery.DAL.Interfaces;

namespace FlowerDelivery.DAL
{
    public class DataManager
    {
        public IRepositoryFlower Flowers { private set; get; }
        public IRepositoryPlantation Plantations { private set; get; }
        public IRepositorySupply Supplies { private set; get; }
        public IRepositoryWarehouse Warehouses { private set; get; }
        public IRepositoryPlantationFlower PlantationFlowers { private set; get; }
        public IRepositoryWarehouseFlower WarehouseFlowers { private set; get; }
        public IRepositorySupplyFlower SupplyFlowers { private set; get; }

        public DataManager(IRepositoryFlower repositoryFlower, IRepositoryPlantation repositoryPlantation,
                IRepositoryWarehouse repositoryWarehouse, IRepositorySupply repositorySupply,
                IRepositoryPlantationFlower repositoryPlantationFlower, IRepositorySupplyFlower repositorySupplyFlower,
                IRepositoryWarehouseFlower repositoryWarehouseFlower)
        {
            Flowers = repositoryFlower;
            Plantations = repositoryPlantation;
            Supplies = repositorySupply;
            Warehouses = repositoryWarehouse;
            PlantationFlowers = repositoryPlantationFlower;
            WarehouseFlowers = repositoryWarehouseFlower;
            SupplyFlowers = repositorySupplyFlower;

        }
    }
}
