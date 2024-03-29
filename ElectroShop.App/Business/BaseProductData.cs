﻿namespace ElectroShop.App.Business;

public class BaseProductData
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ProductImagePath { get; set; } = string.Empty;
    public string ProductPageUrl { get; set; } = string.Empty;
}
