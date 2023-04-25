using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTests.Console.Models
{
    public class Shopify_ProductOption
    {
        public long ID { get; set; }

        public string Name { get; set; }

        [ForeignKey("Product")]
        public long ProductId { get; set; }

        public Shopify_Product Product { get; set; }
    }
}
