﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTests.Console.Models
{
    public class Shopify_Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public ICollection<Shopify_Product_Variant> Variants { get; set; } = new List<Shopify_Product_Variant>();

        public ICollection<Shopify_ProductImage> Images { get; set; } = new List<Shopify_ProductImage>();

        public ICollection<Shopify_ProductOption> Options { get; set; } = new List<Shopify_ProductOption>();

    }
}
