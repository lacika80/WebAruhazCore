using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Model
{
    [Table("Product")]
    public class Product : Interfaces.IProductDTO
    {
        [Key()]
        public int ProdId { get; set; }
        [Required]
        public bool? IsActiveProd { get; set; }
        [Required]
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        [Required, Column(TypeName = "decimal(8, 2)")]
        public decimal NetPrice { get; set; }
        [Required, Column(TypeName = "decimal(4, 3)")]
        public decimal VAT { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal BrutPrice { get; set; }
        public uint ProdSeen { get; set; }
        public DateTime ProdCreated { get; set; }
        public DateTime ProdPriceChanged { get; set; }
        //public int CatId { get; set; }
        // public int PhotoId { get; set; }

        public int PhotoId { get; set; }
        [ForeignKey("PhotoId")]
        public Photo Photo { get; set; }

        public int CatId { get; set; }
        [ForeignKey("CatId")]
        public Category Category { get; set; }

        public virtual ICollection<Filter2Product> Filter2Product { get; set; }

        public virtual ICollection<Photo2Product> Photo2Product { get; set; }
    }
}
