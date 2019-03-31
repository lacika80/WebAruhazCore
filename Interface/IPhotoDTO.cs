using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interfaces
{
    public interface IPhotoDTO
    {
        int PhotoId { get; set; }
        bool? IsActivePhoto { get; set; }
        //product(0) or user(1) photo
        ushort PhotoType { get; set; }
        string ImagePath { get; set; }
        byte[] Image { get; set; }
    }
}
