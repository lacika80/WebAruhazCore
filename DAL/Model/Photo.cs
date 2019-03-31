using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace DAL.Model
{
    [Table("Photo")]
    public class Photo : Interfaces.IPhotoDTO
    {
        [Key()]
        public int PhotoId { get; set; }
        [Required]
        public bool? IsActivePhoto { get; set; }
        [Required]
        //product(0) or user(1) photo
        public ushort PhotoType { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Photo2Product> Photo2Product { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        //public Category Category { get; set; }
    }
}
