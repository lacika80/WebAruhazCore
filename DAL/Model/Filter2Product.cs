using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("Filter2Product")]
    public class Filter2Product
    {
        public int ProdId { get; set; }
        public virtual Product Product { get; set; }

        public int FId { get; set; }
        public virtual Filter Filter { get; set; }
    }
}
