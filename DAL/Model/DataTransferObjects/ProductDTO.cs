using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    public class ProductDTO : Interfaces.IProductDTO
    {
        public int ProdId { get; set; }
        public bool? IsActiveProd { get; set; }
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public decimal NetPrice { get; set; }
        public decimal VAT { get; set; }
        public decimal BrutPrice { get; set; }
        public uint ProdSeen { get; set; }
        public DateTime ProdCreated { get; set; }
        public DateTime ProdPriceChanged { get; set; }
        public virtual ICollection<Filter2Product> Filter2Product { get; set; }
        public virtual ICollection<Photo2Product> Product2Photo { get; set; }
    }
}
