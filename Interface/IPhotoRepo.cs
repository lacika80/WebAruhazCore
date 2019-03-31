using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Interfaces
{
    public interface IPhotoRepo
    {
        /// <summary>
        /// random képfeltöltés
        /// </summary>
        /// <param name="picture"></param>
        void UploadPicture(FileStream picture);
        /// <summary>
        /// Kép csatolása a termékhez
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="prodId"></param>
        void UploadPicture(FileStream picture, int prodId);
        /// <summary>
        /// Kép inaktívvá tétele
        /// </summary>
        /// <param name="pId"></param>
        void DeletePicture(int pId);
        /// <summary>
        /// Minden kép lekérése
        /// </summary>
        /// <returns></returns>
        ICollection<IPhotoDTO> GetPictures();
        /// <summary>
        /// 1 termék képeinek lekérése
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        ICollection<IPhotoDTO> GetPictures(int prodId);
        /// <summary>
        /// terméklista képeinek lekérése
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        ICollection<IPhotoDTO> GetPictures(List<int> prodId);
        /// <summary>
        /// 1 felhasználó képének lekérése
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IPhotoDTO GetPictureByUserId(int userId);
        /// <summary>
        /// több felhasználó képeinek lekérése
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        ICollection<IPhotoDTO> GetPictureByUserId(List<int> userId);


    }
}
