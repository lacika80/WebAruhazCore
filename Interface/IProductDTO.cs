using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IProductDTO
    {
        int ProdId { get; set; }
        bool? IsActiveProd { get; set; }
        string ProdName { get; set; }
        string ProdDescription { get; set; }
        decimal NetPrice { get; set; }
        decimal VAT { get; set; }
        decimal BrutPrice { get; set; }
        uint ProdSeen { get; set; }
        DateTime ProdCreated { get; set; }
        DateTime ProdPriceChanged { get; set; }
    }
}
