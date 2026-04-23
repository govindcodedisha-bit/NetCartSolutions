using NetCart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NetCart.Core
{
    public class ClothProduct : Product
    {
        public int Size { get; set; }
        public string Color { get; set; }

        public ClothProduct(string name, string description, string sku, decimal price, int size, string color) : base(name, description, sku, price)
        {
            Size = size;
            Color = color;
        }
    }
}
