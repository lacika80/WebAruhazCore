using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace DAL.Model
{
    [Table("Category")]
    public class Category 
    {
        [Key()]
        public int CatId { get; set; }
        [Required]
        public bool? IsActiveCat { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
