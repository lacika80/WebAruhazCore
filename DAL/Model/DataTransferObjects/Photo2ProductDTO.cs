using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    public class Photo2ProductDTO : Interfaces.IPhoto2ProductDTO
    {
        public int P2PId { get; set; }
        public int ProdId { get; set; }
        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual Product Product { get; set; }
    }
}
