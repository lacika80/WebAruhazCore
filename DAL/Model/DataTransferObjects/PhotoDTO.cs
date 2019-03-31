using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL.Model.DataTransferObjects
{
    public class PhotoDTO : Interfaces.IPhotoDTO
    {
        public int PhotoId { get; set; }
        public bool? IsActivePhoto { get; set; }
        //product(0) or user(1) photo
        public ushort PhotoType { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Photo2Product> Product2Photo { get; set; }
        public byte[] Image { get; set; }
    }
}
