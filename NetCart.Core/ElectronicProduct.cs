using NetCart.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NetCart.Core
{
    public class ElectronicProduct : Product
    {
        public string Brand { get; set; }
        public string ModelNumber { get; set; }
        public int ManifacturingYear { get; set; }

        public ElectronicProduct(string name, string description, string sku, decimal price
            , string brandName, string modelNumber, int manifacturingYear) : base(name, description, sku, price)
        {
            this.Brand = brandName;
            this.ModelNumber = modelNumber;
            this.ManifacturingYear = manifacturingYear;
            Display();
        }





    }
}
