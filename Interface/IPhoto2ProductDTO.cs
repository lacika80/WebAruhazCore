using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPhoto2ProductDTO
    {
        int P2PId { get; set; }
        int ProdId { get; set; }
        int PhotoId { get; set; }
    }
}
