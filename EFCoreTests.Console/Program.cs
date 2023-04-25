// See https://aka.ms/new-console-template for more information
using EFCoreTests.Console;
using EFCoreTests.Console.Models;
using System.Reflection.Metadata;

Console.WriteLine("Start App");

using (var db = new ContextModel())
{
    for (var i = 0; i < 20; i++)
    {
        var prod = new Shopify_Product { Name = $"Test{i}" };

        prod.Images.Add(new Shopify_ProductImage { Name = $"Test Image{i}1" });
        prod.Images.Add(new Shopify_ProductImage { Name = $"Test Image{i}2" });
        prod.Images.Add(new Shopify_ProductImage { Name = $"Test Image{i}3" });

        prod.Options.Add(new Shopify_ProductOption { Name = $"Test Option{i}1" });
        prod.Options.Add(new Shopify_ProductOption { Name = $"Test Option{i}2" });
        prod.Options.Add(new Shopify_ProductOption { Name = $"Test Option{i}3" });
        prod.Options.Add(new Shopify_ProductOption { Name = $"Test Option{i}4" });

        prod.Variants.Add(new Shopify_Product_Variant { Name = $"Test Variant{i}1" });
        prod.Variants.Add(new Shopify_Product_Variant { Name = $"Test Variant{i}2" });

        db.Add<Shopify_Product>(prod);
        db.SaveChanges();
    }
}


Console.WriteLine("Finish");