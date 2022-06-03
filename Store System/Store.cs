using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System
{
    internal class Store
    {
        string storeName;
        string type;
        double revevue;
        public Store(string name, string type)
        {
            this.storeName = name;
            this.type = type;
        }
    }
}
