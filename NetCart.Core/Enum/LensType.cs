using System;
using System.Collections.Generic;
using System.Text;

namespace NetCart.Core.Enum;
public enum LensType
{
    /// <summary>
    /// Standard clear or tinted lenses
    /// </summary>
    Standard = 1,

    /// <summary>
    /// Polarized lenses that reduce glare
    /// </summary>
    Polarized = 2,

    /// <summary>
    /// Photochromic lenses that darken in sunlight (Transitions)
    /// </summary>
    Photochromic = 3,

    /// <summary>
    /// Prescription corrective lenses
    /// </summary>
    Prescription = 4,

    /// <summary>
    /// Mirrored reflective lenses
    /// </summary>
    Mirrored = 5,

    /// <summary>
    /// Gradient tinted lenses (darker at top)
    /// </summary>
    Gradient = 6
}

/// <summary>
/// Represents eyewear frame materials.
/// </summary>
public enum FrameMaterial
{
    /// <summary>
    /// Plastic/acetate frames
    /// </summary>
    Plastic = 1,

    /// <summary>
    /// Metal frames (stainless steel, aluminum, titanium)
    /// </summary>
    Metal = 2,

    /// <summary>
    /// Combination of metal and plastic
    /// </summary>
    Mixed = 3,

    /// <summary>
    /// Titanium frames (lightweight and durable)
    /// </summary>
    Titanium = 4,

    /// <summary>
    /// Wood/bamboo frames
    /// </summary>
    Wood = 5,

    /// <summary>
    /// Rimless/frameless design
    /// </summary>
    Rimless = 6
}
