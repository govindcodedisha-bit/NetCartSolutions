using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NetCart.Core.Enum;
namespace NetCart.Core.Entities;

public abstract class Product
{
    /// <summary>
    /// Unique identifier for the product
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Product name
    /// </summary>
    public string Name { get; private set; } 

    /// <summary>
    /// Detailed product description
    /// </summary>
    public string Description { get; private set; } 
    /// <summary>
    /// Stock Keeping Unit - unique product code
    /// </summary>
    public string SKU { get; private set; }

    /// <summary>
    /// Product price
    /// </summary>
    public decimal Price { get; private set; }

    /// <summary>
    /// Product image URL
    /// </summary>
    public string? ImageUrl { get; private set; }

    /// <summary>
    /// Category ID this product belongs to
    /// </summary>
    public string? CategoryId { get; private set; }

    /// <summary>
    /// Current product status
    /// </summary>
    public ProductStatus Status { get; private set; }

    /// <summary>
    /// Current stock status
    /// </summary>
    public StockStatus StockStatus { get; private set; }

    /// <summary>
    /// Quantity available in stock
    /// </summary>
    public int StockQuantity { get; private set; }

    /// <summary>
    /// Average rating (0-5 stars)
    /// </summary>
    public decimal Rating { get; private set; }

    /// <summary>
    /// Product weight in kilograms (for shipping calculation)
    /// </summary>
    public decimal? Weight { get; private set; }

    /// <summary>
    /// Is this product featured/highlighted?
    /// </summary>
    public bool IsFeatured { get; private set; }

    /// <summary>
    /// Date when product was created
    /// </summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// Date when product was last updated
    /// </summary>
    public DateTime UpdatedAt { get; private set; }


    /// <summary>
    /// Private parameterless constructor for ORM/Serialization frameworks
    /// </summary>
    private Product()
    {
        Id = string.Empty;
        Name = string.Empty;
        Description = string.Empty;
        SKU = string.Empty;
        Price = 0;
    }

    /// <summary>
    /// Public constructor with validation - ensures product is always created in valid state
    /// OOP Principle: Encapsulation - validation logic contained within the class
    /// </summary>
    public Product(
        string name,
        string description,
        string sku,
        decimal price,
        string? categoryId = null,
        decimal? weight = null,
        string? imageUrl = null)
    {
        // Validation - ensures object is always in valid state
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name is required", nameof(name));

        if (string.IsNullOrWhiteSpace(sku))
            throw new ArgumentException("SKU is required", nameof(sku));

        if (price == null)
            throw new ArgumentNullException(nameof(price));

        // Initialize with default values
        Id = Guid.NewGuid().ToString();
        Name = name;
        Description = description ?? string.Empty;
        SKU = sku;
        Price = price;
        CategoryId = categoryId;
        Weight = weight;
        ImageUrl = imageUrl;
        Status = ProductStatus.Active;
        StockStatus = StockStatus.OutOfStock;
        StockQuantity = 0;
        Rating = 0;
        IsFeatured = false;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Updates product price
    /// </summary>
    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice == null)
            throw new ArgumentNullException(nameof(newPrice));

        Price = newPrice;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Sets the category for this product
    /// </summary>
    public void SetCategory(string? categoryId)
    {
        CategoryId = categoryId;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Updates stock quantity and automatically adjusts stock status
    /// OOP Principle: Encapsulation - business logic contained within the class
    /// SOLID Principle: Single Responsibility - Product manages its own stock logic
    /// </summary>
    public void UpdateStock(int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Stock quantity cannot be negative", nameof(quantity));

        StockQuantity = quantity;

        // Automatic status calculation - encapsulated business rule
        if (quantity == 0)
            StockStatus = StockStatus.OutOfStock;
        else if (quantity <= 10)
            StockStatus = StockStatus.LowStock;
        else
            StockStatus = StockStatus.InStock;

        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Adds stock quantity
    /// </summary>
    public void AddStock(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be positive", nameof(quantity));

        UpdateStock(StockQuantity + quantity);
    }

    /// <summary>
    /// Removes stock quantity
    /// </summary>
    public void RemoveStock(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be positive", nameof(quantity));

        if (quantity > StockQuantity)
            throw new InvalidOperationException("Cannot remove more stock than available");

        UpdateStock(StockQuantity - quantity);
    }

    /// <summary>
    /// Activates the product
    /// </summary>
    public void Activate()
    {
        Status = ProductStatus.Active;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Deactivates the product
    /// </summary>
    public void Deactivate()
    {
        Status = ProductStatus.Inactive;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Marks product as discontinued
    /// </summary>
    public void Discontinue()
    {
        Status = ProductStatus.Discontinued;
        StockStatus = StockStatus.OutOfStock;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Updates the product image
    /// </summary>
    public void UpdateImage(string? imageUrl)
    {
        ImageUrl = imageUrl;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Updates product weight (for shipping calculation)
    /// </summary>
    public void UpdateWeight(decimal? weight)
    {
        if (weight.HasValue && weight.Value < 0)
            throw new ArgumentException("Weight cannot be negative");

        Weight = weight;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Sets or updates the product rating
    /// </summary>
    public void UpdateRating(decimal rating)
    {
        if (rating < 0 || rating > 5)
            throw new ArgumentException("Rating must be between 0 and 5");

        Rating = rating;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Marks product as featured
    /// </summary>
    public void SetAsFeatured()
    {
        IsFeatured = true;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Removes featured status
    /// </summary>
    public void RemoveFromFeatured()
    {
        IsFeatured = false;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Checks if product is available for purchase
    /// </summary>
    public bool IsAvailable()
    {
        return Status == ProductStatus.Active && StockQuantity > 0;
    }

    /// <summary>
    /// Checks if product is low on stock
    /// </summary>
    public bool IsLowStock()
    {
        return StockStatus == StockStatus.LowStock;
    }

}
