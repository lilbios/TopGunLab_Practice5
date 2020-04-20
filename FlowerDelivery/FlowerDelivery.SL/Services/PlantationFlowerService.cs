using FlowerDelivery.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.SL.Services
{
    public class PlantationFlowerService
    {
        private DataManager dataManager;

        public PlantationFlowerService(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
    }
}
