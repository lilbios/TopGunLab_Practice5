using FlowerDelivery.DAL.Interfaces;

namespace FlowerDelivery.DAL
{
    public class DataManager
    {
        public IRepositoryFlower Flowers { private set; get; }
        public IRepositoryPlantation Plantations { private set; get; }
        public IRepositorySupply Supplies { private set; get; }
        public IRepositoryWarehouse Warehouses { private set; get; }
        public IRepositoryPlantationFlower RepositoryPlantationFlower { private set; get; }
        public IRepositoryWarehouseFlower RepositoryWarehouseFlower { private set; get; }
        public IRepositorySupplyFlower RepositorySupplyFlower { private set; get; }

        public DataManager(IRepositoryFlower repositoryFlower, IRepositoryPlantation repositoryPlantation,
                IRepositoryWarehouse repositoryWarehouse, IRepositorySupply repositorySupply,
                IRepositoryPlantationFlower repositoryPlantationFlower, IRepositorySupplyFlower repositorySupplyFlower,
                IRepositoryWarehouseFlower repositoryWarehouseFlower)
        {
            Flowers = repositoryFlower;
            Plantations = repositoryPlantation;
            Supplies = repositorySupply;
            Warehouses = repositoryWarehouse;
            RepositoryPlantationFlower = repositoryPlantationFlower;
            RepositoryWarehouseFlower = repositoryWarehouseFlower;
            RepositorySupplyFlower = repositorySupplyFlower;

        }
    }
}
