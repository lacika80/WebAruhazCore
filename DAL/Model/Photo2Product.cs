using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Product2Photo")]
    public class Photo2Product
    {
        public int ProdId { get; set; }
        public virtual Product Product { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
