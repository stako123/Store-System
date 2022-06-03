using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System
{
    internal class StoreController
    {
        List<Store> _stores;
        public StoreController()
        {
            _stores = new List<Store>();
        }
        public string CreateStore(List<string> args)
        {
            _stores.Add(new Store(args[0],args[1]));
            return CreateStore(args);
        }
        public string ReceiveProduct(List<string> args)
        {
            
        }

        public string SellProduct(List<string> args)
        {
            
        }

        public string StoreInfo(List<string> args)
        {
            
        }

        public string Shutdown()
        {
            
        }

    }
}
