using FlowerDelivery.DAL;
using FlowerDelivery.DAL.Implementations;
using FlowerDelivery.DAL.Interfaces;
using Ninject.Modules;

namespace FlowerDelivery.Web.App_Start
{
    public class NinjectWebCommon : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositoryFlower>().To<FlowerRepository>();
            Bind<IRepositoryPlantation>().To<PlantationRepository>();
            Bind<IRepositoryPlantationFlower>().To<PlantationFlowerRepository>();
            Bind<IRepositoryWarehouse>().To<WarehouseRepository>();
            Bind<IRepositoryWarehouseFlower>().To<WarehouseFlowerRepository>();
            Bind<IRepositorySupply>().To<SupplyRepository>();
            Bind<IRepositorySupplyFlower>().To<SupplyFlowerRepository>();
            Bind<DataManager>().ToSelf();
        }
    }
}