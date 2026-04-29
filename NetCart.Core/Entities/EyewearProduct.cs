using NetCart.Core.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCart.Core.Entities;
public class EyewearProduct : Product
{
    /// <summary>
    /// Brand name (e.g., Ray-Ban, Oakley, Gucci, Warby Parker)
    /// </summary>
    public string Brand { get; private set; }

    /// <summary>
    /// Model name or number
    /// </summary>
    public string Model { get; private set; }

    /// <summary>
    /// Lens type (Standard, Polarized, Photochromic, Prescription, Mirrored)
    /// </summary>
    public LensType LensType { get; private set; }

    /// <summary>
    /// Frame material
    /// </summary>
    public FrameMaterial FrameMaterial { get; private set; }

    /// <summary>
    /// Gender/target demographic
    /// </summary>
    public Gender Gender { get; private set; }

    /// <summary>
    /// Frame color
    /// </summary>
    public string FrameColor { get; private set; }

    /// <summary>
    /// Lens color (e.g., "Black", "Brown", "Gray", "Blue Mirror")
    /// </summary>
    public string LensColor { get; private set; }

    /// <summary>
    /// UV protection level (e.g., "UV400", "100% UVA/UVB")
    /// </summary>
    public string UVProtection { get; private set; }

    /// <summary>
    /// Frame width in millimeters
    /// </summary>
    public decimal? FrameWidth { get; private set; }

    /// <summary>
    /// Lens width in millimeters
    /// </summary>
    public decimal? LensWidth { get; private set; }

    /// <summary>
    /// Bridge width in millimeters
    /// </summary>
    public decimal? BridgeWidth { get; private set; }

    /// <summary>
    /// Temple length in millimeters
    /// </summary>
    public decimal? TempleLength { get; private set; }

    /// <summary>
    /// Frame shape (e.g., "Wayfarer", "Aviator", "Round", "Cat-Eye", "Rectangular")
    /// </summary>
    public string? FrameShape { get; private set; }

    /// <summary>
    /// Whether the eyewear is prescription-ready (can have prescription lenses fitted)
    /// </summary>
    public bool IsPrescriptionReady { get; private set; }

    /// <summary>
    /// Whether the lenses are scratch-resistant
    /// </summary>
    public bool IsScratchResistant { get; private set; }

    /// <summary>
    /// Whether the lenses are anti-reflective
    /// </summary>
    public bool IsAntiReflective { get; private set; }

    /// <summary>
    /// Nose pad type (e.g., "Fixed", "Adjustable", "None")
    /// </summary>
    public string? NosePadType { get; private set; }

    /// <summary>
    /// Whether the product comes with a case
    /// </summary>
    public bool IncludesCase { get; private set; }

    /// <summary>
    /// Style/purpose (e.g., "Casual", "Sports", "Fashion", "Safety")
    /// </summary>
    public string? Style { get; private set; }
    public EyewearProduct(string name, string description, string sku, decimal price, int size, string color) : base(name, description, sku, price)
    {
       
    }
}
