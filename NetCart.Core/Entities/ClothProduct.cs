using NetCart.Core.Enum;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NetCart.Core.Entities
{
    public class ClothProduct : Product
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public Gender Gender { get; private set; }
        /// <summary>
        /// Additional available colors (if any)
        /// </summary>
        public List<string> AvailableColors { get; private set; }

        /// <summary>
        /// Fabric material (e.g., "100% Cotton", "65% Polyester 35% Cotton")
        /// </summary>
        public string Material { get; private set; }

        /// <summary>
        /// Care instructions (e.g., "Machine wash cold", "Dry clean only")
        /// </summary>
        public string? CareInstructions { get; private set; }

        /// <summary>
        /// Clothing fit type (e.g., "Regular Fit", "Slim Fit", "Relaxed Fit")
        /// </summary>
        public string? FitType { get; private set; }

        /// <summary>
        /// Style/occasion (e.g., "Casual", "Formal", "Sports", "Business")
        /// </summary>
        public string? Style { get; private set; }

        /// <summary>
        /// Season suitability (e.g., "Summer", "Winter", "All Season")
        /// </summary>
        public string? Season { get; private set; }

        /// <summary>
        /// Pattern type (e.g., "Solid", "Striped", "Floral", "Checkered")
        /// </summary>
        public string? Pattern { get; private set; }

        /// <summary>
        /// Sleeve length for tops (e.g., "Short Sleeve", "Long Sleeve", "Sleeveless")
        /// </summary>
        public string? SleeveLength { get; private set; }

        /// <summary>
        /// Whether the item is made from sustainable/eco-friendly materials
        /// </summary>
        public bool IsSustainable { get; private set; }

        public ClothProduct(string name, string description, string sku, decimal price, int size, string color) : base(name, description, sku, price)
        {
            Size = size;
            Color = color;
        }
    }
}
