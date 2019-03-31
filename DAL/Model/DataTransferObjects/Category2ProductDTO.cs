using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    public class Category2ProductDTO : Interfaces.ICategory2ProductDTO
    {
        public int C2PId { get; set; }
        public int ProdId { get; set; }
        public int CatId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
