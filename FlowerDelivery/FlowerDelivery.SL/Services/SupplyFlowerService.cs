using FlowerDelivery.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.SL.Services
{
    public class SupplyFlowerService
    {
        private DataManager dataManager;
        public SupplyFlowerService(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
    }
}
