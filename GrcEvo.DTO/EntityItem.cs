using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class EntityItem
    {
        public int ID { get; set; }
        public string PrefixCode { get; set; }
        public int NumberCode { get; set; }
        public string Type { get; set; }
        public string Family { get; set; }
        public string SubFamily { get; set; }
        public string Brand { get; set; }
        public string ShortDescription { get; set; }
        public string Ean { get; set; }
        public string PackagingUnit { get; set; }
        public double PriceSaleET { get; set; }
        public double PricePurchaseET { get; set; }
        public double VatRate { get; set; }
        public bool InStock { get; set; }
        public double Stock { get; set; }
        public bool Blocked { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
